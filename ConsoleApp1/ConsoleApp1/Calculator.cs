using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
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
        public Memory add( double a) {
            cur.add(a);
            return cur;
        }
        public Memory sub(double a)
        {
            cur.sub(a);
            return cur;
        }
        public Memory mult(double a)
        {
            cur.mult(a);
            return cur;
        }
        public Memory div(double a)
        {
            cur.div(a);
            return cur;
        }




    };

}
