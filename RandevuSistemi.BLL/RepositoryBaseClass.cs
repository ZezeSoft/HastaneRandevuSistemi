using RandevuSistemi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuSistemi.BLL
{
    public abstract class RepositoryBaseClass<T,ID> where T:class
    {
        protected internal static MyContext dbContext;// sadece BLL içerisindeki kalıtım alanlar erişebilecek.aynı proje+kalıtım alanlar kullanacak

        public List<T> GetAll()
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().ToList();//set ile tüm kullanııcılarda çalışabilen generic birhale getirmiş oluyoruz.
        }
        public T GetById(ID id)
        {
            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
            dbContext = dbContext ?? new MyContext();

            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbContext = dbContext ?? new MyContext();

            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }

        public void Update()
        {
            dbContext.SaveChanges();
            dbContext = new MyContext();
        }

    }
}
