using BufeBeadandoProject.Soups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Interfaces.Entrees
{
    internal interface IEntreeFactory
    {
        IEntree CreateSoup();
    }
}
