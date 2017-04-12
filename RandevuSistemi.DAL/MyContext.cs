using RandevuSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("HastaneRandevuCon")
        {

        }
        public virtual DbSet<Hasta> Hasta { get; set; }
        public virtual DbSet<Doktor> Doktor { get; set; }
        public virtual DbSet<Hemsire> Hemsire { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Randevu> Randevu { get; set; }
        public virtual DbSet<Gorevler> Gorev { get; set; }
        public virtual DbSet<Birimler> Birim { get; set; }
        public virtual DbSet<Cinsiyetler> Cinsiyet { get; set; }
        public virtual DbSet<KanGruplari> KanGrup { get; set; }
        public virtual DbSet<Unvanlar> Unvan { get; set; }

    }
}
