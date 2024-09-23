using HTTProj.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTProj.Application
{
    public class Admin : IHaveId
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string password_hash { get; set; }
        public string Role { get; set; }
        public DateTime Created_At { get; set; }
    }
}
