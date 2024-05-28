using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Interfaces.Desserts
{
    internal interface IDessertFactory
    {
        IDessert CreateDessert();
    }
}
