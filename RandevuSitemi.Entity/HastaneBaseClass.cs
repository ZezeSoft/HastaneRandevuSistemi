using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    public abstract class HastaneBaseClass
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Ad { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 2)]
        public string Soyad { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string TCKN { get; set; }

        public DateTime DogumTarihi { get; set; }
        public int CinsiyetID { get; set; }
        [ForeignKey("CinsiyetID")]
        public virtual Cinsiyetler Cinsiyet { get; set; }

        public int KangrupID { get; set; }
        [ForeignKey("KangrupID")]
        public virtual KanGruplari KanGrubu { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

    }
}
