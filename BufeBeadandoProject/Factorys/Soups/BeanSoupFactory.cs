using BufeBeadandoProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Soups
{
    internal class BeanSoupFactory : ISoupFactory
    {
        public ISoup CreateSoup()
        {
            return new BeanSoup();
        }
    }
}
