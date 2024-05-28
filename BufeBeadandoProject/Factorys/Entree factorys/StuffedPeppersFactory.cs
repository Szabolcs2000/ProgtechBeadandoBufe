using BufeBeadandoProject.Entree;
using BufeBeadandoProject.Interfaces.Entrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Factorys.Entree_factorys
{
    internal class StuffedPeppersFactory : IEntree
    {
        public IEntree CreateEntree()
        {
            return new StuffedPeppers();
        }
    }
}
