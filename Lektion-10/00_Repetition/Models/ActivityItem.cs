using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Models
{
    public class ActivityItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
