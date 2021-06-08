using System.Collections.Generic;

namespace Sistema.Estacionamento.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);
        void Entrada(T entidade);
        void Saida(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}