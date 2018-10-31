using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式
{
    class Program
    {
        //1.定义委托类型
        public delegate int DelAdd(int x,int y);
        static void Main(string[] args)
        {
            //2. 这个委托指向 lambda表达式
            DelAdd add1 = (x, y) => { return x + y; };

            int restult = add1(1,2);
            Console.WriteLine(restult);
            Console.ReadKey();

        }
    }
}
