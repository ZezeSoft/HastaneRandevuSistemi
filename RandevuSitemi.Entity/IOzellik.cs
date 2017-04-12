using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    public interface IOzellik
    {
        [NotMapped]
        int AylikGelinmeyenGunSayisi { get; set; }
        [NotMapped]
        decimal Maas { get; set; }

        [NotMapped]
        decimal BirimFiyat { get; }

         [NotMapped]
        int CalisilanGunSayisi { get; }

        //[NotMapped]
        decimal MaasHesapla();
    }
}
