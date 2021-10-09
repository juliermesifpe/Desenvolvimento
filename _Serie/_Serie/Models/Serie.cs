using _Serie.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public string Titulo { get; set; }

        public int RetornarId()
        {
            return this.Id;
        }
        public string RetornarGenero()
        {
            return this.Genero;
        }
        public string RetornarTitulo()
        {
            return this.Titulo;
        }
    }
}
