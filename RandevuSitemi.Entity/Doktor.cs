using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Doktorlar")]
    public class Doktor : HastaneBaseClass , IOzellik
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
            return CalisilanGunSayisi * BirimFiyat * 1.09m;
        }

        public virtual List<Hemsire> DoktorunHemsireleri { get; set; }
        public virtual List<Randevu> DoktorunRandevulari { get; set; }

        public int BirimID { get; set; }
        [ForeignKey("BirimID")]
        public virtual Birimler Birim { get; set; }


        public int UnvanID { get; set; }
        [ForeignKey("UnvanID")]
        public virtual Unvanlar Unvan { get; set; }
     
    }
}
