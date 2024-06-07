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
                new Producto { ProductoId = 1, ProductoNombre = "Jurassic Park (1993)" },
                new Producto { ProductoId = 2, ProductoNombre = "The Lost World: Jurassic Park (1997)" },
                new Producto { ProductoId = 3, ProductoNombre = "Jurassic Park III (2001)" },
                new Producto { ProductoId = 4, ProductoNombre = "Jurassic World (2015)" },
                new Producto { ProductoId = 5, ProductoNombre = "Jurassic World: Fallen Kingdom (2018)" },
                new Producto { ProductoId = 6, ProductoNombre = "Jurassic World Dominion (2022)" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Jurassic Park (1993)" },
                new Producto { ProductoId = 2, ProductoNombre = "The Lost World: Jurassic Park (1997)" },
                new Producto { ProductoId = 3, ProductoNombre = "Jurassic Park III (2001)" },
                new Producto { ProductoId = 4, ProductoNombre = "Jurassic World (2015)" },
                new Producto { ProductoId = 5, ProductoNombre = "Jurassic World: Fallen Kingdom (2018)" },
                new Producto { ProductoId = 6, ProductoNombre = "Jurassic World Dominion (2022)" },
                new Producto { ProductoId = 7, ProductoNombre = "Star Wars: Episode IV - A New Hope (1977)" },
                new Producto { ProductoId = 8, ProductoNombre = "Star Wars: Episode V - The Empire Strikes Back (1980)" },
                new Producto { ProductoId = 9, ProductoNombre = "Star Wars: Episode VI - Return of the Jedi (1983)" },
                new Producto { ProductoId = 10, ProductoNombre = "The Terminator (1984)" },
                new Producto { ProductoId = 11, ProductoNombre = "Terminator 2: Judgment Day (1991)" },
                new Producto { ProductoId = 12, ProductoNombre = "Alien (1979)" },
                new Producto { ProductoId = 13, ProductoNombre = "Aliens (1986)" }
            };

            return result;
        }


    }
}