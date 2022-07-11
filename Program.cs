using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");
            Console.ReadLine();
        }
    }
    public interface IEmployeeService
    {
        void add(Employee employee);
        void delete(int Id);
       
    }
    public class Employee : IEmployeeService
    {
        public void add(Employee employee)
        {
            
        }

        void IEmployeeService.delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
