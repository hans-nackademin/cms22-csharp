using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Services
{
    internal abstract class DataAccess
    {
        private List<Product> _list = new List<Product>();

        protected virtual List<Product> GetAll()
        {
            return _list;
        }


        protected abstract void Save();

        protected abstract void Read();

    }
}
