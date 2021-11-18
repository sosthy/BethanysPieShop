using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult List (string category)
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            piesListViewModel.Pies = pieRepository.AllPies.Where(p => string.IsNullOrEmpty(category) || p.Category.CategoryName.Equals(category));
            piesListViewModel.CurrentCategory = string.IsNullOrEmpty(category) ? "All Pies" : $"Pies of category <{category}>";

            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            Pie pie = pieRepository.GetPieById(id);
            return View(pie);
        }
    }
}
