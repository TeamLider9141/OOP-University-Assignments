using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarslari.Classes
{
    public class Noutbuk
    {
        public List<firmasi> Firmalar { get; set; }
       
        public Noutbuk()
        {
            Firmalar = new List<firmasi>();
        }
        public void SetNoutbuk(firmasi firma)
        {
            Firmalar.Add(firma);
        }
        
        public int GetCountNoutbuk()
        {
            return Firmalar.Count;
        }

        public void SetObjects(List<firmasi> firmalar)
        {
            Firmalar = firmalar;
        }

        public firmasi SearchById(int id)
        {
            return Firmalar.FirstOrDefault(x => x.Id == id);
        }

        public firmasi SearchByName(string name)
        {
            return Firmalar.FirstOrDefault(x => x.Name == name);
        }

        public List<firmasi> SearchInterval(int first, int lates)
        {
            List<firmasi> list = new List<firmasi>();
            foreach (var item in Firmalar)
            {
                if (item.Id <= first && item.Id <= lates)
                    list.Add(item);
            }

            return list;
        }

        public void SortById()
        {
            Firmalar = Firmalar.OrderBy(x => x.Id).ToList();
        }

        public firmasi Update(firmasi firma, int id)
        {
            var entity = SearchById(id);
            entity.Name = firma.Name;
            entity.Autor = firma.Autor;

            return entity;
        }


    }
}