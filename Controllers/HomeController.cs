using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo_list.Models;


namespace todo_list.Controllers
{
    public class HomeController : Controller
    {
        private readonly todoListEfContext _context; 

        public HomeController(todoListEfContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.TodoModel.ToList());
        }

        [HttpPost]
        public IActionResult Index(string NewItem)
        {
            var currentToDo = new TodoModel{
                TaskName = NewItem
            };
            _context.Add(currentToDo);
            _context.SaveChanges();

            return View(_context.TodoModel.ToList());
        }

        [HttpPost]
        public IActionResult IsComplete(int ID)
        {
            var finished = _context.TodoModel.FirstOrDefault(m => m.ID == ID);
            finished.Complete();
            _context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
