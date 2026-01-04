using EntityLayer.WebApp.ViewModels.Category;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.WebApp.Abstract;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IValidator<CategoryAddVM> _addValidator;
        private readonly IValidator<CategoryUpDateVM> _upDateValidator;

        public CategoryController(ICategoryService categoryService, IValidator<CategoryAddVM> addValidator, IValidator<CategoryUpDateVM> upDateValidator)
        {
            _categoryService = categoryService;
            _addValidator = addValidator;
            _upDateValidator = upDateValidator;
        }

        public async Task<IActionResult> GetCategoryList()
        {
            var categoryList = await _categoryService.GetAllListAsync();
            return View(categoryList);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryAddVM request)
        {
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _categoryService.AddAsync(request);
                return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();
            
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(CategoryUpDateVM request)
        {
            var validation = await _upDateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _categoryService.UpDateAsync(request);
                return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });
            }
            validation.AddToModelState(this.ModelState);
            return View();

        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("GetCategoryList", "Category", new { Area = ("Admin") });
        }
    }
}
