using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Helpers.Identity;
using System.Diagnostics;

namespace Project.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IValidator<SignUpVM> _signUpValidator;
        private readonly IValidator<LogInVM> _loginValidator;
        private readonly IMapper _iMapper;

        public AuthenticationController(UserManager<AppUser> userManager, IValidator<SignUpVM> signUpValidator, IMapper iMapper, SignInManager<AppUser> signInManager, IValidator<LogInVM> loginValidator)
        {
            _userManager = userManager;
            _signUpValidator = signUpValidator;
            _iMapper = iMapper;
            _signInManager = signInManager;
            _loginValidator = loginValidator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            Debug.WriteLine("Se abre el formulario");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM request)
        {
            var validation = await _signUpValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                Debug.WriteLine("Validación fallida");
                validation.AddToModelState(this.ModelState);
                return View(request);
            }

            var user = _iMapper.Map<AppUser>(request);

            var userCreateResult = await _userManager.CreateAsync(user, request.Password);

            if (!userCreateResult.Succeeded)
            {
                ViewBag.Result = "NotSucceed";
                foreach (var error in userCreateResult.Errors)
                {
                    Debug.WriteLine($"Error UserManager: {error.Code} - {error.Description}");
                }

                ModelState.AddModelErrorList(userCreateResult.Errors);
                return View(request);
            }
            return RedirectToAction("LogIn", "Authentication");
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM request, string? returnUrl=null)
        {
            returnUrl = returnUrl ?? Url.Action("Index", "Dashboard", new { Area = "Admin"});   
            var validation = await _loginValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                ViewBag.Result = "NotSucceed";
                validation.AddToModelState(this.ModelState);
                return View();
            }
            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser == null) 
            {
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(new List<string> { "Email or password is wrong" });
                return View();
            }

            var logInResult = await _signInManager.PasswordSignInAsync(hasUser, request.Password, request.RememberMe, true);

            if (logInResult.Succeeded) 
            {
                return Redirect(returnUrl!);
            }

            if (logInResult.IsLockedOut) 
            { 
                ViewBag.ReturnUrl = "LockedOut";
                ModelState.AddModelErrorList(new List<string> {"Your account is locked our for 60 seconds!"});
                return View();
            }

            ViewBag.ReturnUrl = "FailedAttempt";
            ModelState.AddModelErrorList(new List<string> { "Email or password is wrong", $"Failed Attempt: {await _userManager.GetAccessFailedCountAsync(hasUser)}" });
            return View();
        }
    }
}
