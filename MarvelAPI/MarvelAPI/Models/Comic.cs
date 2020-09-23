using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelAPI.Models
{
    public class Comic
    {
        public int idComic { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Descrip { get; set; }
        public int Rate { get; set; }
        public DateTime FechPublic { get; set; }

    }
}
