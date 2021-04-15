using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{

    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> objects = new List<int>();
            objects.AddRange(new int[] { 1, 2, 3, 4 });
            Cycler cycler = new Cycler();
            cycler.chisl = objects;

           for(int i = 0; i < 10; i++)
            {
                int element = cycler.GetNext();
                Console.Write(element + ", ");
            }
            Console.ReadKey();
        }
    }

   class Cycler
    {
        public List<int> chisl;
        public int currentPosition = 0;
        int currentElement = 0;

        public int GetNext()
        {
            if (currentPosition != chisl.Count)
            {
                currentElement = chisl[currentPosition];
                currentPosition++;
                return currentElement;
            }
            else if (currentPosition == chisl.Count)
            {
                currentPosition = 0;
                currentElement = chisl[currentPosition];
                return currentElement;
            }
            return currentElement;

        }
    }
    
}
