using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ThreadSafeProgram
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentdetails(),
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }
        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            LazyLoadingSingleton lazyLoadingFromEmp = LazyLoadingSingleton.GetInstance;
            lazyLoadingFromEmp.PrintDetails("Lazy loadin From Employee");
        }
        private static void PrintStudentdetails()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            LazyLoadingSingleton lazyLoadingFromStudent = LazyLoadingSingleton.GetInstance;
            lazyLoadingFromStudent.PrintDetails("Lazy loading From Student");
        }
    }
}
