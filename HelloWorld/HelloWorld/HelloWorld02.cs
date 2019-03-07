using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //无需实例化的HelloWorld
    class HelloWorld02
    {
        public static void helloWorld(String []str)
        {
            HelloWorld01 h01 = new HelloWorld01();
            h01.helloWorld(str);
        }

    }
}
