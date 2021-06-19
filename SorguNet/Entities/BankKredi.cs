using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Entities
{
    public class BankKredi
    {
        public int Id { get; set; } 
        public string CustomerTC { get; set; }
        public DateTime VadeTarihi { get; set; }
        public DateTime? KapanmaTarihi { get; set; }
        //1 açık durumda , 2 kapalı
        public int Status { get; set; }
        public Customer Customer { get; set; }

    }
}
