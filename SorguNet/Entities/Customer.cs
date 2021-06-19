using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Entities
{
    public class Customer
    {
        [Key]
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public int KrediNot { get; set; }

    }
}
