using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotView
{
    class MicroCPU
    {
        #region members
        private int acc;
        private int res;

        #endregion

        #region constructor & destructor
        public MicroCPU()
        {
            // init with zero
            acc = 0;
            res = acc;
        }

        public MicroCPU(int initial)
        {
            // init with given value
            acc = initial;
            res = acc;
        }
        #endregion

        #region properties
        public int Result
        {
            get {
                return res;
            }
        }
        #endregion

        #region methods
        public int add(int input)
        {
            acc += input;
            res = acc;
            return res;
        }
        
        public int sub(int input)
        {
            acc -= input;
            res = acc;
            return res;
        }

        public int div(int input)
        {
            acc /= input;
            res = acc;
            return res;
        }

        public int mul(int input)
        {
            acc *= input;
            res = acc;
            return res;
        }

        public void clr()
        {
            acc = 0;
            res = acc;
        }
        #endregion

    }
}