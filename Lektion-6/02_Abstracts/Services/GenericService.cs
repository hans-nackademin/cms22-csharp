using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstracts.Services
{
    internal abstract class GenericService
    {
        public abstract void Connect();


        public virtual void Create()
        {
            Console.WriteLine("Creating new Record");
        }

        public virtual void Read()
        {
            Console.WriteLine("Getting Records");
        }

    }
}
