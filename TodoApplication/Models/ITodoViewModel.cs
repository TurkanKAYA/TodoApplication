using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApplication.Models
{
    public interface ITodoViewModel
    {
        IEnumerable<TodoItem> Items { get; set; }
    }
}
