using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.OneOne
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
