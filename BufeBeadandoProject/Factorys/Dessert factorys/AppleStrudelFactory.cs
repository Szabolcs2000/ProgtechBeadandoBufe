using BufeBeadandoProject.Desserts;
using BufeBeadandoProject.Interfaces.Desserts;

namespace BufeBeadandoProject.Factorys.Dessert_factorys
{
    internal class AppleStrudelFactory : IDessertFactory
    {
        public IDessert CreateDessert()
        {
            return new AppleStrudel();
        }
    }
}
