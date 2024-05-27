using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject
{
    internal class SaltDecorator : MenuDecorator
    {
        public SaltDecorator(IExtra soup) : base(soup)
        {
        }
        public override int Cost()
        {
            return 50;
        }
    }
}
