using BufeBeadandoProject.Desserts;
using BufeBeadandoProject.Interfaces.Desserts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Factorys.Dessert_factorys
{
    internal class HoneyCakeFactory : IDessertFactory
    {
        public IDessert CreateDessert()
        {
            return new HoneyCake();
        }
    }
}
