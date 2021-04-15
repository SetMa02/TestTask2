using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{

    class Cycler
    {
        private List<int> numbers;

        public Cycler(List<int> numbers)
        {
            this.numbers = numbers;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.AddRange(new int[] { 5, 3, 2, 1 });
            Cycler cycler = new Cycler(numbers);
        }
    }

    
}
