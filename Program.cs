//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegateDemo
//{
//    //public delegate string MyDelegate(string nm);
//   //public delegate int MyDelegate(int a, int b);
//    //public class User
//    //{
//    //    public string GetName(string name)
//    //        {
//    //            return name.ToUpper();  
//    //        }
//    //}
//    public class Calc
//    {
//        public int Add(int a,int b)
//        {
//            return a + b;
//        }
//        public int Sub(int a, int b)
//        {
//            return a - b;
//        }
//        public int Mul(int a, int b)
//        {
//            return a * b;
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            //User u1 = new User();
//            //MyDelegate myDelegate = new MyDelegate(u1.GetName);
//            //string nm = myDelegate.Invoke("think quotient");
//            //Console.WriteLine(nm);

//            Calc calc = new Calc();
//            MyDelegate myDelegate = new MyDelegate(calc.Add);
//            MyDelegate += new MyDelegate(calc.Sub);
//            MyDelegate += new MyDelegate(calc.Mul);
//            Delegate[] list = myDelegate.GetInovcationList();

//            foreach (Delegate item in list)
//                {
//                    Console.WriteLine(item.Method);
//                    object result = item.DynamicInvoke(25, 30);
//                    //int add = myDelegate.Invoke(25, 30);
//                    Console.WriteLine(result.ToString());
//                }
//        }
//    }
//}
