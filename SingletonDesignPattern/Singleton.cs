using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            //get
            //{
            //    if (instance == null)
            //        instance = new Singleton();
            //    return instance;
            //}
            get
            {
                if (instance == null)
                {
                    lock (obj) //apply lock for thread safe
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
