using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class LazyLoadingSingleton
    {
        private static int counter = 0;
        private static readonly Lazy<LazyLoadingSingleton> instance = 
        new Lazy<LazyLoadingSingleton>(() => 
        new LazyLoadingSingleton());
        private LazyLoadingSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static LazyLoadingSingleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
