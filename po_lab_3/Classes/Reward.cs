using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Reward
    {
        public void GiveTo<T>(T target)
        {
            Console.WriteLine($"{target}! You got a reward");
        }
    }
}
