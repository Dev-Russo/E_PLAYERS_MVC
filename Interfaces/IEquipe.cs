using System.Collections.Generic;
using E_PlayersMVC.Models;

namespace E_PlayersMVC.Interfaces
{
    public interface IEquipe
    {
        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int IdEquipe);
    }
}