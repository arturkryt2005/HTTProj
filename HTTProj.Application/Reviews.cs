using HTTProj.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTProj.Application
{
    public class Reviews : IHaveId
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Client_Id { get; set; }
        public int Rating { get; set; }
        public string Review_Text { get; set; }
        public DateTime Created_At { get; set; }


        public Product Product { get; set; }
    }
}
