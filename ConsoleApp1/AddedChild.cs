﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AddedChild
    {
       public AddedChild()
        {
            Console.WriteLine("i am in construcor");
            Console.WriteLine("parent made changes to child");
        }
        public void Hello()
        {
            Console.WriteLine("I am in hello method");
        }
    }
}
