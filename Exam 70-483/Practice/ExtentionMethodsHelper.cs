using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class ExtentionMethodsHelper
    {
        public static int Square(this int number)
        {
            return number * number;
        }
    }
}
