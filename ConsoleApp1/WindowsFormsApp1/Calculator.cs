using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1 {
    public class Calculator
    {
        public const int LIM_idx = 10;
        public Memory cur;
        private Memory[] m;
        private int idx;

        public Calculator() {
            cur = new Memory();
            m = new Memory[LIM_idx];
            idx = 0;
        }
        public void MemoryStore() {
            m[++idx-1] = new Memory( cur );
        }
        public void MemoryClear() {
            idx = 0;
        }
        public void MemoryPlus() {
            m[idx - 1].add(cur.Val);
        }
        public void MemoryMinus() {
            m[idx - 1].sub(cur.Val);
        }
        public void add( double a) {
            cur.add(a);
        }
        public void sub(double a)
        {
            cur.sub(a);
        }
        public void mult(double a)
        {
            cur.mult(a);
        }
        public void div(double a)
        {
            cur.div(a);
        }
        public void setCur(double a)
        {
            cur.Val = a;
        }



    };

}
