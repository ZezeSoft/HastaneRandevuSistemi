using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Personeller")]
    public class Personel : HastaneBaseClass, IOzellik
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
        [NotMapped]
        public decimal BirimFiyat
        {
            get { return Maas / 30; }
        }
        [NotMapped]
        public int CalisilanGunSayisi
        {
            get { return 30 - AylikGelinmeyenGunSayisi; }
        }

        public decimal MaasHesapla()
        {
            return CalisilanGunSayisi * BirimFiyat;
        }

        public int GorevID { get; set; }
        [ForeignKey("GorevID")]
        public virtual Gorevler Gorev { get; set; }

    }
}
