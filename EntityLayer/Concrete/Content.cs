using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        public bool ContentStatus { get; set; }  //aktif pasıf olacak sekılde yapıyoruz, silme olmayacak

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //int yanındakı soru işareti Nullable kullanımıdır, sqlde o alan boş null değer alabilir anlamında
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
