using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        //[MinLength(5)]
        //[MaxLength(100)]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //bool burada Veriyi Pasift Hale getrmek için

        public ICollection<Heading> Headings { get; set; }
    }
}
