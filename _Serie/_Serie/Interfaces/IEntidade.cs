using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Serie.Interfaces
{
    public interface IEntidade<Entidade>
    {
        int GerarId();
        void Salvar(Entidade entidade);
        List<Entidade> Listar();
        void EscreverFileAdicionar(Entidade entidade);
        IEnumerable<String> LerFileAdicionar();
        IEnumerable<String> LerFileCadastrar();
        Task PegarId(int id);
        void Atualizar(int id, Entidade entidade);
        void Excluir(int id);
    }
}
