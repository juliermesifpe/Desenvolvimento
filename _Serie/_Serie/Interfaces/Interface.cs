using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Interfaces
{
    public interface Interface<Entidade>
    {
        int GerarId();
        void Salvar(Entidade entidade);
        List<Entidade> Listar();
        Task PegarId(int id);
        void Atualizar(int id, Entidade entidade);
        void Excluir(int id);
    }
}
