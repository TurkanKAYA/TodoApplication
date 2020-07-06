using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApplication.Models;
using TodoApplication.Services;

namespace TodoApplication.Controllers
{
  
    public class TodoController : Controller
    {
        private readonly ITodoItemService service;

        public TodoController(ITodoItemService _service) // depencedey injection
        {
            this.service = _service;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //FakeTodoItemService service = new FakeTodoItemService();
            // IEnumerable<TodoItem> items = service.GetIncompleteItemsAsync().Result;
            var items = await service.GetIncompleteItemsAsync();
            TodoViewModel vn = new TodoViewModel();
            vn.Items = items;



            ViewBag.Title = "Yapılacaklar Listesini Yönet";
            return View(vn);
        }
    }
}
