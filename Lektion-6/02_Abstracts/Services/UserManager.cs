using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstracts.Services
{
    internal class UserManager : GenericService
    {
        public override void Connect()
        {
            Console.WriteLine("UserManager connecting to Microsoft Sql Server");
        }
    }
}
