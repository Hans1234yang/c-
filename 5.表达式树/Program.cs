using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _5.表达式树
{
    class Program
    {
        static void Main(string[] args)
        {
            //表达式树是保存 委托的容器
            Expression<Func<int, int, int>> exp = (x, y) => x + y;

            Func<int, int, int> func = exp.Compile();
            int result = func(2,3);

            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
