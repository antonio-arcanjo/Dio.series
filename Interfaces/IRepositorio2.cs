using System.Collections.Generic;

namespace DIO.Series.Interfaces2
{
    public interface IRepositorio2<L>
    {
        List<L> Lista2();
        L RetornaPorId2(int id);
        void Insere2(L entidade);
        void Exclui2(int id);
        void Atualiza2(int id, L entidade);
        int ProximoId2();

    }


}