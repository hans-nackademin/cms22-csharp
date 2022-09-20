using _00_Repetition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Repetition.Services
{
    internal class FileManager : DataAccess
    {

        protected override List<Product> GetAll()
        {
            return base.GetAll();
        }

        protected override void Read()
        {
            throw new NotImplementedException();
        }

        protected override void Save()
        {
            throw new NotImplementedException();
        }
    }
}
