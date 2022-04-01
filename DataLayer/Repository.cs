using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repository<T> : IRepository<T> where T:class
    {
      
        private readonly DbSet<T> _dbSet;
        Context _db;
        public Repository()
        {
            _db = new Context();
            _dbSet = _db.Set<T>();
        }
        public T Bul(int id)
        {
            return _dbSet.Find(id);
        }
        public void Ekle(T t)
        {
            _dbSet.Add(t);
            _db.SaveChanges();
        }

        public void Guncelle(T t)
        {
            var updateEntity = _db.Entry(t);
            updateEntity.State = EntityState.Modified;
            _db.SaveChanges();
        }

        public List<T> Listele()
        {
            return _dbSet.ToList();
        }
        public void Sil(int id)
        {
          var obj=  _dbSet.Find(id);
          _dbSet.Remove(obj);
           _db.Configuration.ValidateOnSaveEnabled = false;
            _db.SaveChanges();
        }
    }
}
