using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    
    class Program
    {
        //1.定义一个委托类型 
        public delegate int DelAdd(int x, int y);
        static void Main(string[] args)
        {
            //3.实例化一个委托
            DelAdd d1 = new DelAdd(Add);
            int result = d1(1,2);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        //2.定义一个方法
        public static int Add(int x,int y)
        {
            return x + y;
        }
    }
}
