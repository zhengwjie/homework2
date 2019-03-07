using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {    
            if(args.Length>0)
            {
                HelloWorld01 hw = new HelloWorld01();
                hw.helloWorld(args);
                HelloWorld02.helloWorld(args);
            }
        }
    }
}
