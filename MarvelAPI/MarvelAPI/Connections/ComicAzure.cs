using MarvelAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MarvelAPI.Connections
{
    public class ComicAzure
    {
        static string connectionString = @"Server=DESKTOP-S6JN4IA\SQLEXPRESS;Database=Marvel;Trusted_Connection=True;";
        public static List<Comic> listComic;

        //Get all comics
        public static List<Comic> getAllComics()
        {
            var dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "select * from Comic";

                connection.Open();
                var DataAdapter = new SqlDataAdapter(command);
                DataAdapter.Fill(dt);

                listComic = new List<Comic>();
                Comic comic = new Comic();

                comic.Nombre = dt.Rows[0]["Nombre"].ToString();
                comic.idComic = int.Parse(dt.Rows[0]["idComic"].ToString());
                comic.Autor = dt.Rows[0]["Autor"].ToString();
                comic.Descrip = dt.Rows[0]["Descrip"].ToString();
                //comic.FechPublic = dt.Rows[0]["FechPublic"].ToString();
                comic.Rate = Convert.ToInt32(dt.Rows[0]["Rate"].ToString());

                listComic.Add(comic);

            }


            return listComic;
        }

    }
}
