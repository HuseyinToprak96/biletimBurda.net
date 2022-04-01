using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Interfaces
{
   public interface IServis<T> where T:class
    {
        T Bul(int id);
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(int id);
        List<T> Tumu();
    }
}
