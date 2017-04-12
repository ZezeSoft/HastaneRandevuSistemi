using RandevuSistemi.DAL;
using RandevuSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.BLL
{
    public class DoktorRepo : RepositoryBaseClass<Doktor,int>
    {
        public static List<Doktor> Arama(string kelime)
        {
            dbContext = new MyContext();
            if (string.IsNullOrEmpty(kelime))
                return dbContext.Doktor.ToList();

            return dbContext.Doktor.Where(x => x.Ad.ToLower().Contains(kelime) || x.Soyad.ToLower().Contains(kelime)).ToList();
        }

      

    }

    public class HastaRepo : RepositoryBaseClass<Hasta,int>
    {
        public static List<Hasta> Arama(string kelime)
        {
            dbContext = new MyContext();
            if (string.IsNullOrEmpty(kelime))
                return dbContext.Hasta.ToList();

            return dbContext.Hasta.Where(x => x.Ad.ToLower().Contains(kelime) || x.Soyad.ToLower().Contains(kelime)).ToList();
        }
    }

    public class HemsireRepo :  RepositoryBaseClass<Hemsire,int>
    {
        public static List<Hemsire> Arama(string kelime)
        {
            dbContext = new MyContext();
            if (string.IsNullOrEmpty(kelime))
                return dbContext.Hemsire.ToList();

            return dbContext.Hemsire.Where(x => x.Ad.ToLower().Contains(kelime) || x.Soyad.ToLower().Contains(kelime)).ToList();
        }
    }

    public class PersonelRepo : RepositoryBaseClass<Personel, int>
    {
        public static List<Personel> Arama(string kelime)
        {
            dbContext = new MyContext();
            if (string.IsNullOrEmpty(kelime))
                return dbContext.Personel.ToList();

            return dbContext.Personel.Where(x => x.Ad.ToLower().Contains(kelime) || x.Soyad.ToLower().Contains(kelime)).ToList();
        }
    }

    public class RandevuRepo : RepositoryBaseClass<Randevu,Guid>
    {
       public static List<string> SaatleriGetir()
        {
            List<string> saatListesi = new List<string>();
            for (int saat = 9; saat < 15; saat++)
            {
                if (saat == 12) saat++;

                for (int dakika = 0; dakika < 6; dakika++)
                {
                    saatListesi.Add(saat+":"+ dakika +"0");
                }
            }
            return saatListesi.Take(30).ToList();
        }
    }
    public class BirimRepo : RepositoryBaseClass<Birimler, int>
    {

    }
    public class GorevRepo : RepositoryBaseClass<Gorevler, int>
    {

    }

    public class KanGrubuRepo : RepositoryBaseClass<KanGruplari, int>
    {

    }
    public class UnvanRepo : RepositoryBaseClass<Unvanlar, int>
    {

    }

    public class CinsiyetRepo : RepositoryBaseClass<Cinsiyetler, int>
    {

    }
}
