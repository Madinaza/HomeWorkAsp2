using homeworkASP.Models;
using homeworkASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkASP.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList()
            };
            return View(model);


        }


        //List<Slider> sliders = new List<Slider>
        //{
        //    new Slider
        //    {
        //        Id=1,
        //        Image="slide-1.jpg",
        //        Title="Loremm",
        //        KeyWord="Impus Dolor",
        //        Desc="Ut velit est quam dolor ad a aliquid qui aliquid." +
        //        " Sequi ea ut et est quaerat sequi nihil ut aliquam." +
        //        " Occaecati alias dolorem mollitia ut." +
        //        " Similique ea voluptatem. Esse doloremque accusamus " +
        //        "repellendus deleniti vel. Minus et tempore modi architecto.",
        //        RedirecUrl="https://www.youtube.com",
        //          Order=2,

        //    },
        //     new Slider
        //    {
        //        Id=2,
        //        Image="slide-2.jpg",
        //        Title="Welcomee",
        //        KeyWord="Impus sjsjsjsjr",
        //        Desc="2sjjjjjjjsjsjsUt velit est quam dolor ad a aliquid qui aliquid." +
        //        " Sequi ea ut et est quaerat sequi nihil ut aliquam." +
        //        " Occaecati alias dolorem mollitia ut." +
        //        " Similique ea voluptatem. Esse doloremque accusamus " +
        //        "repellendus deleniti vel. Minus et tempore modi architecto.",
        //        RedirecUrl="https://www.google.com",
        //        Order=1,


        //    },


        //      new Slider
        //    {
        //        Id=3,
        //        Image="slide-3.jpg",
        //        Title="3Madina",
        //        KeyWord="Agazadaaa",
        //        Desc="mmmmmmmmmUt velit est quam dolor ad a aliquid qui aliquid." +
        //        " Sequi ea ut et est quaerat sequi nihil ut aliquam." +
        //        " Occaecati alias dolorem mollitia ut." +
        //        " Similique ea voluptatem. Esse doloremque accusamus " +
        //        "repellendus deleniti vel. Minus et tempore modi architecto.",
        //        RedirecUrl="https://www.instagram.com",
        //        Order=3,

        //    },




        //};

        //List<Feature> features = new List<Feature>
        //{
        //    new Feature
        //    {
        //        Id = 1,
        //        Icon = "<i class='bi bi-card-checklist'></i>",
        //        Title = "MEDINAAAA",
        //        Desc =" First feature"

        //    },
        //    new Feature
        //    {
        //        Id = 2,
        //        Icon = "<i class='bi bi-bar-chart'></i>",
        //        Title = "AGAZADAAAA",
        //        Desc =" Second feature"

        //    },
        //    new Feature
        //    {
        //        Id = 3,
        //        Icon = "<i class='bi bi-binoculars'></i>",
        //        Title = "MMMMMMMMMMMM",
        //        Desc =" Third feature"

        //    }
        //};

        //HomeVM model = new HomeVM
        //{
        //    Sliders = sliders.OrderBy(s => s.Order).ToList(),
        //    Features = features,
        //};

    }

}



       
    

