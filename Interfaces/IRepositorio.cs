using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }

/*public interface IRepositorio2<L>
    {
        List<T> Lista2();
        L RetornaPorId2(int id);
        void Insere2(L entidade);
        void Exclui2(int id);
        void Atualiza2(int id, L entidade);
        int ProximoId2();

    }*/
 
}
