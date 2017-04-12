using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Hastalar")]
    public class Hasta : HastaneBaseClass
    {
        public virtual List<Randevu> HastaninRandevulari { get; set; }
       
    }
}
