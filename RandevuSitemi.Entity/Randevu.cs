using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Randevular")]
    public class Randevu
    {
        public Randevu()
        {
            ID = Guid.NewGuid();
            //RandevuZamani = DateTime.Now;
        }
        [Key]
        public Guid ID { get; set; }

        public DateTime RandevuZamani { get; set; }
        public int SiraNumarasi { get; set; }

        public int? DoktorID { get; set; }
        [ForeignKey("DoktorID")]
        public virtual Doktor DoktorunRandevusu { get; set; }

        public int HastaID { get; set; }
        [ForeignKey("HastaID")]
        public virtual Hasta HastanınRandevusu { get; set; }

        public int BirimID { get; set; }
        [ForeignKey("BirimID")]
        public virtual Birimler Birim { get; set; }

    }
}
