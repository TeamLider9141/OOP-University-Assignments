using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarslari.Classes
{
    public class firmasi
    {


        public firmasi(int id, string name, string autor)
        {
            Id = id;
            Name = name;
            Autor = autor;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }
    }
}

