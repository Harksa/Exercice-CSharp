using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicesBase.Models
{
    class MyPair <T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public MyPair(T tFirst, U uSecond) {
            First = tFirst;
            Second = uSecond;
        }

        public override string ToString() {
            return $"Value 1 : {First.ToString()}, Value 2 : {Second.ToString()}";
        }
    }
}
