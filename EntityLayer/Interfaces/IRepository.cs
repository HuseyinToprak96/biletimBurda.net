using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Interfaces
{
   public interface IRepository<T> where T:class
    {
        void Ekle(T t);
        void Sil(int id);
        void Guncelle(T t);
        List<T> Listele();
        T Bul(int id);
    }
}
