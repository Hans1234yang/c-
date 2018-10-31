using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        //1.定义一个委托类型
        public delegate int DeleAdd(int x, int y);
        static void Main(string[] args)
        {
            //2.我把这个方法 赋值给委托
            DeleAdd d1 = delegate (int x, int y)  { return x + y; };

            int result = d1.Invoke(1,2);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        

    }
}
