using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McardsBanco._Repositorio.Core
{
    interface IRepositorio<T>
    {
        IEnumerable<T> Listar();

        T buscarPorID(int ID);

        void Inserir(T item);

        void Alterar(T item);

        void Deletar(T item);
    }
}
