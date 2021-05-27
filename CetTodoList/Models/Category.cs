using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CetTodoList.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }
        public virtual List<TodoItem> TodoItems { get; set; }

    }
}
