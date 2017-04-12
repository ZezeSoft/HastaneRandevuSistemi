using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Hemsireler")]
    public class Hemsire :  HastaneBaseClass,IOzellik
    {
        public decimal Maas
        {
            get;
            set;
        }

       [NotMapped]
        public int AylikGelinmeyenGunSayisi
        {
            get;
            set;
        }

        public decimal BirimFiyat
        {
            get { return Maas / 30; }
        }

        public int CalisilanGunSayisi
        {
            get { return 30 - AylikGelinmeyenGunSayisi; }
        }

        public decimal MaasHesapla()
        {
            return CalisilanGunSayisi * BirimFiyat;
        }

        public int? DoktorID { get; set; }
        [ForeignKey("DoktorID")]
        public virtual Doktor HemsireninDoktoru { get; set; }

        public int BirimID { get; set; }
        [ForeignKey("BirimID")]
        public virtual Birimler Birim { get; set; }

    }
}
