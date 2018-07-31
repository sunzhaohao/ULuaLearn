using System.Collections;
using System.Collections.Generic;
using UnityEngine  ;

    public class Program
    {
        public int count = 5;
        public static double Add(double a, double b)
        {
            return  a + b;
        }
        public double Double(double num)
        {
            return num * 2;
        }

        public static Program getInstance()
        {
            return new Program();
        }

        public int getCount()
        {
            return count;
        }
    }



