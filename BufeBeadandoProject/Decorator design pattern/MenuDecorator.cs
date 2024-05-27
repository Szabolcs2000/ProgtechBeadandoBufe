using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject
{
    internal class MenuDecorator : IExtra
    {
        protected IExtra menuDecorator;

        public MenuDecorator(IExtra soup)
        {
            this.menuDecorator = soup;
        }

        public virtual int Cost()
        {
           return menuDecorator.Cost();
        }
    }
}
