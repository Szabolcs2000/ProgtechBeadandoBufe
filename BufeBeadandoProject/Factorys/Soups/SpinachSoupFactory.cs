using BufeBeadandoProject.Interfaces;
using BufeBeadandoProject.Soups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Factorys.Soups
{
    internal class SpinachSoupFactory : ISoupFactory
    {
        public ISoup CreateSoup()
        {
            return new SpinachSoup();
        }
    }
}
