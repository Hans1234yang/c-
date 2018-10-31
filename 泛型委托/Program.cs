using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型委托
{
    class Program
    {
        //泛型委托 是连 委托的定义都去掉的 。 用func 简化委托的定义
        static void Main(string[] args)
        {
            Func<int, int, int> funAdd1 = (x, y) => { return x + y; };
            int resutl = funAdd1(2,3);

            Console.WriteLine(resutl);
            Console.ReadKey();
        }
    }
}
