using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalBlog.Models;

namespace FinalBlog.Controllers
{
    public class HomeController : Controller
    {
        private PostRepository repository = PostRepository.Current;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Add(Post item)
        {
            if (ModelState.IsValid)
            {
                repository.Add(item);
                return RedirectToAction("Index");
            }
            else return View("Index");
        }

        public IActionResult Edit(Post item)
        {
            if (ModelState.IsValid)
            {
                Update(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }

        }

        public IActionResult AuthorizationEdit(Post item)
        {
            if (ModelState.IsValid)
            {
                if(repository.VerifyUser(item) != null)
                {
                    Post post = repository.VerifyUser(item);
                    return RedirectToAction("EditPost", post);
                }
                else
                {
                    return View("ErrorAuth");
                }
            }
            else return View("Index");
        }

        public IActionResult AuthorizationDelete(Post item)
        {
            if (ModelState.IsValid)
            {
                if (repository.VerifyUser(item) != null)
                {
                    Post post = repository.VerifyUser(item);
                    return RedirectToAction("Delete", post);
                }
                else
                {
                    return View("ErrorAuth");
                }
            }
            else return View("Index");
        }

        public void Remove(Post item)
        {
            repository.Remove(item);
        }

        public ActionResult Update(Post item)
        {
            if (ModelState.IsValid && repository.Update(item))
                return RedirectToAction("Index");
            else return View("Index");
        }

        public IActionResult Index()
        {
            if (repository.IsEmpty())
            {
            }
            return View(repository.GetAll());
        }

        public IActionResult Editor()
        {
            return View();
        }

        public IActionResult EditPost(Post item)
        {
            Post post = new Post();
            int id = item.Id;

            post = repository.Get(id);
            return View(post);
        }
        public IActionResult Creator()
        {
            return View();
        }

        public IActionResult Post(int id)
        {
            Post post = new Post();
            post = repository.Get(id);
            return View(post);
        }
        public IActionResult Deleter()
        {
            return View();
        }

        public IActionResult Delete(Post post)
        {

            repository.Remove(post);
            return View("Delete");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
