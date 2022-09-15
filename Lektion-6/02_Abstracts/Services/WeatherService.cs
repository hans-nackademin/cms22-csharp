using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstracts.Services
{
    internal class WeatherService : GenericService
    {
        public override void Connect()
        {
            Console.WriteLine("WeatherService connecting to SMHI Web Api.");
        }
    }
}
