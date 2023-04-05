//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace DelegateDemo
//{
//    //Accept name from the user in a constructor & print the name
//    //If name is empty or null then raise an event that “name is required”
//    //public delegate void MyDelegate();
//    //public class User1
//    //{
//    //    public event MyDelegate Namereq;
//    //    public event MyDelegate Namev;

//    //    public void accept(string name)
//    //    {
//    //        if (string.IsNullOrEmpty(name))
//    //        {
//    //            Namereq();
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine(Namev);
//    //        }
//    //    }
//    //    public class Program10
//    //    {

//    //        static void Message1()
//    //        {
//    //            Console.WriteLine("name is req");
//    //        }
//    //        static void Message2()
//    //        {
//    //            Console.WriteLine("name is valid");
//    //        }


//    public delegate void MyDelegate();
//    public class Bank
//    {
//        public event MyDelegate Balis0;
//        public event MyDelegate Lowbal;
//        public event MyDelegate validbal;

//        public int initalbal;
//        public void Acceptinibal(int initalbal)
//        {
//            if(initalbal==0)
//            {
//                Balis0();
//            }
//            if (initalbal<5000)
//            {
//                validbal();
//            }
//            if (initalbal > 5000)
//            {
//                validbal();
//            }

//        }
//        public void credit(double balance)
//        {

//        }
//        public void debit(double balance)

//        {
//            if(balance ==0)
//            {
//                NoBalance();
//            }
//            else
//            {
//                LowBalance();

//            }
//        }




//    static void Main(string[] args)
//            {

//                Bank b = new Bank();
//                b.credit(5000);
//                b.debit(200);
//                b.Balis0 += new MyDelegate(Messahe1);
//                b.lowbal += new MyDelegate(Messahe2);
//                b.validbal += new MyDelegate(Messahe3);
//                bank.Acceptinibal(5000);


















//                //User1 user = new User1();
//                //user.Namereq += new MyDelegate(Message1);
//                //user.Namev += new MyDelegate(Message2);
//                //user.accept(" ");
//            }



//        }
//    }

//}
