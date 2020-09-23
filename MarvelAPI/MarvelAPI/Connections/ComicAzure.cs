using MarvelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelAPI.Connections
{
    public class ComicAzure
    {
        static string connectionString = @"Server=DESKTOP-S6JN4IA\SQLEXPRESS;Database=Marvel;Trusted_Connection=True;";
        public static List<Comic> listComic;
    }
}
