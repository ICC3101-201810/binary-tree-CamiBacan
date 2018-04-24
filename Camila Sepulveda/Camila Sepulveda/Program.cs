using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camila_Sepulveda
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>();
            Node<int> n2 = new Node<int>();
            n1.AddData(15);
            Console.WriteLine(n1.GetT());

            Console.ReadLine();

        }
    }
}
