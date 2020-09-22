
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApp.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Task { get; set; }
        public DateTime TaskDate { get; set; }

        public User User { get; set; }
    }
}
