using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject
{
    internal class DessertDecorator : MenuDecorator
    {
        public DessertDecorator(IExtra soup) : base(soup)
        {
        }
        public override int Cost()
        {
            return 500;
        }
    }
}
