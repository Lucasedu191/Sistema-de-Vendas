using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    public class DataContextFactory
    {
        private static sistemaDataContext dataContext;
        sistemaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;
            }
        }

    }
}
