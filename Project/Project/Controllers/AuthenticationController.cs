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
        private readonly IValidator<SignUpVM> _signUpValidator;
        private readonly IMapper _iMapper;

        public AuthenticationController(UserManager<AppUser> userManager, IValidator<SignUpVM> signUpValidator, IMapper iMapper)
        {
            _userManager = userManager;
            _signUpValidator = signUpValidator;
            _iMapper = iMapper;
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
                foreach (var error in userCreateResult.Errors)
                {
                    Debug.WriteLine($"Error UserManager: {error.Code} - {error.Description}");
                }

                ModelState.AddModelErrorList(userCreateResult.Errors);
                return View(request);
            }
            return RedirectToAction("LogIn", "Authentication");
        }
    }
}
