using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111
{
    public class Class1
    {
        public int UserInt;

        public int SetUserInt (int uInt)
        {
            UserInt = uInt;
            return UserInt;
        }

        public int methodOne()
        {
            int methodOneResult = UserInt + 1;
            return methodOneResult;
        }

        public int methodTwo()
        {
            int methodTwoResult = UserInt - 1;
            return methodTwoResult;
        }

        public int methodThree()
        {
            int methodTheeResult = UserInt * 2;
            return methodTheeResult;
        }



    }
}
