using HelloDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloDotNet.Controllers
{
    public class TodoController : Controller
    {
        private static List<Todo> _todos = new List<Todo>();
        private static int _nextId = 1;

        // GET: Todo
        public ActionResult Index()
        {
            return View(_todos);
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                todo.Id = _nextId++;
                _todos.Add(todo);
                return RedirectToAction("Index");
            }

            return View(todo);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // POST: Todo/Edit/5
        [HttpPost]
        public ActionResult Edit(Todo todo)
        {
            if (ModelState.IsValid)
            {
                var existingTodo = _todos.FirstOrDefault(t => t.Id == todo.Id);
                if (existingTodo != null)
                {
                    existingTodo.Title = todo.Title;
                    existingTodo.Completed = todo.Completed;
                }
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        // GET: Todo/Delete/5
        public ActionResult Delete(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return HttpNotFound();
            }
            return View(todo);
        }

        // POST: Todo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                _todos.Remove(todo);
            }
            return RedirectToAction("Index");
        }
    }
}
