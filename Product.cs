using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITestingService testingService = new TestingService();
            testingService.Create();
            testingService.Update();
            testingService.Delete();
            Console.ReadLine();
        }
    }

    public interface ITestingService
    {
        void Create();
        void Update();
        void Delete();
    }

    public class TestingService : ITestingService
    {
        public void Create()
        {
            Console.WriteLine("Product created successfully");
        }

        public void Delete()
        {
            Console.WriteLine("Product deleted successfully");
        }

        public void Update()
        {
            Console.WriteLine("Product updated successfully");

        }
    }


}