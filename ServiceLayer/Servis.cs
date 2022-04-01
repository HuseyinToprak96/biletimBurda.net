using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Linq.Expressions;

namespace ServiceLayer
{
    public class Servis<T>:IServis<T> where T : class
    {
        private readonly IRepository<T> _repository;
      
        public Servis(IRepository<T> repository)
        {
            _repository = repository;
        }
        public T Bul(int id)
        {
            return  _repository.Bul(id);
        }
        public void Ekle(T entity)
        {
        _repository.Ekle(entity);
        }
        public void Guncelle(T entity)
        {
            _repository.Guncelle(entity);
        }

        public void Sil(int id)
        {
            _repository.Sil(id);
        }

        public List<T> Tumu()
        {
            return _repository.Listele();
                }
    }
}