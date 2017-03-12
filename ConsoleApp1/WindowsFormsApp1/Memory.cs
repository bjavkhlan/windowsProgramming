using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Memory
    {
        private double val;

        public Memory()
        {
            val = 0;
        }
        public Memory(double _val)
        {
            val = _val;
        }
        public Memory(Memory a)
        {
            val = a.Val;
        }
        public double Val
        {
            get => val;
            set => val = value;
        }
        public static Memory operator +(Memory a, Memory b)
        {
            Memory ret = new Memory();
            ret.Val = b.Val + a.Val;
            return ret;
        }
        public void add(double a)
        {
            val += a;
        }
        public void sub(double a)
        {
            val -= a;
        }
        public void mult(double a)
        {
            val *= a;
        }
        public void div(double a)
        {
            val /= a;
        }
    };

}
