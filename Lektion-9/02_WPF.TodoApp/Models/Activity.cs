using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF.TodoApp.Models
{
    internal class Activity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
