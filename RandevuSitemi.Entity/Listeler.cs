using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.Entity
{
    [Table("Cinsiyetler")]
    public class Cinsiyetler
    {
        [Key]
        public int ID { get; set; }

        public string Cinsiyet { get; set; }
        public virtual List<Doktor> DoktorCinsiyet { get; set; }
        public virtual List<Hemsire> HemsireCinsiyet { get; set; }
        public virtual List<Hasta> HastaCinsiyet { get; set; }
        public virtual List<Personel> PersonelCinsiyet { get; set; }
    }

    [Table("KanGruplari")]
    public class KanGruplari
    {
        [Key]
        public int ID { get; set; }

        public string KanGrubu { get; set; }

        public virtual List<Doktor> DoktorKanGrubu { get; set; }
        public virtual List<Hemsire> HemsireKanGrubu { get; set; }
        public virtual List<Hasta> HastaKanGrubu { get; set; }
        public virtual List<Personel> PersonelKanGrubu { get; set; }
    }

    [Table("Birimler")]
    public class Birimler
    {
        [Key]
        public int ID { get; set; }

        public string Birim { get; set; }

        public virtual List<Doktor> DoktorBirim { get; set; }
        public virtual List<Hemsire> HemsireBirim { get; set; }
        public virtual List<Randevu> RandevuBirim { get; set; }
    }

    [Table("Unvanlar")]
    public class Unvanlar
    {
        [Key]
        public int ID { get; set; }

        public string Unvan { get; set; }

        public virtual List<Doktor> DoktorUnvan { get; set; }
    }

    [Table("Gorevler")]
    public class Gorevler
    {
        [Key]
        public int ID { get; set; }

        public string Gorev { get; set; }

        public virtual List<Personel> PersonelGorev { get; set; }
    }
}
