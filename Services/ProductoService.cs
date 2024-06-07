using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc4_progra.Models;

namespace pc4_progra.Services
{
    public class ProductoService
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 3, ProductoNombre = "The Dark Knight (2008)"  },
                new Producto { ProductoId = 5, ProductoNombre = "The Lord of the Rings: The Return of the King (2003)" },
                new Producto { ProductoId = 9, ProductoNombre = "The Matrix (1999)" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "The Shawshank Redemption (1994)" },
                new Producto { ProductoId = 2, ProductoNombre = "The Godfather (1972)" },
                new Producto { ProductoId = 3, ProductoNombre = "The Dark Knight (2008)" },
                new Producto { ProductoId = 4, ProductoNombre = "Pulp Fiction (1994)" },
                new Producto { ProductoId = 5, ProductoNombre = "The Lord of the Rings: The Return of the King (2003)" },
                new Producto { ProductoId = 6, ProductoNombre = "Forrest Gump (1994)" },
                new Producto { ProductoId = 7, ProductoNombre = "Inception (2010)" },
                new Producto { ProductoId = 8, ProductoNombre = "Fight Club (1999)" },
                new Producto { ProductoId = 9, ProductoNombre = "The Matrix (1999)" },
                new Producto { ProductoId = 10, ProductoNombre = "Interstellar (2014)" }
            };

            return result;
        }


    }
}