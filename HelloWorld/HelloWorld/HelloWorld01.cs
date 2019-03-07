using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorld01
    {
        public HelloWorld01()
        {
            
        }
        public void helloWorld(String []str)
        {
            int i = 0;
            for(i=0;i<str.Length-1;i++)
                Console.Write(str[i] + " ");
            Console.WriteLine(str[i]);
        }
    }
}
