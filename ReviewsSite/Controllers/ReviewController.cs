using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var reviewList = reviewRepo.GetAll();
            return View(reviewList);
        }

        public ViewResult Create(int toppingId)
        {
            return View(new Review(){ToppingsId = toppingId});
        }

        [HttpPost]

        public ViewResult Create(Review model)
        {
            reviewRepo.Create(model);

            ViewBag.Result = "You have successfully written your review.";

            ModelState.Clear();

            return View(model);
        }

         public ViewResult Update(int id)
        {
            var review = reviewRepo.GetById(id);

            return View(review);
        }

        [HttpPost]
        public ViewResult Update(Review model)
        {
            reviewRepo.Update(model);

            ViewBag.Result = "You have successfully updated this review";

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetById(id);

            int index = review.ToppingsId;
            //var detailsString = "Details/" + index.ToString();
            reviewRepo.Delete(review);
            return RedirectToAction("Details", "Toppings", new { id = index });

        }
    }
}
