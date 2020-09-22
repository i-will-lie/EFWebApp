using EFWebApp.Models;
using System;
using System.Collections.Generic;

namespace EFWebApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}
