using _Serie.Controllers;
using _Serie.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Repositorio
{
    public class SerieRepositorio : Interface<Serie>
    {
        public void Atualizar(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int GerarId()
        {
            throw new NotImplementedException();
        }

        public List<Serie> Listar()
        {
            throw new NotImplementedException();
        }

        public Task PegarId(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Serie entidade)
        {
            throw new NotImplementedException();
        }
    }
}
