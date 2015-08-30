using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new WordList.DataLayer.WordListPersistenceLayer();
            test.Add("Hello", "World");
            test.Add("HowAre", "You");
            test.GetAll();
        }
    }
}
