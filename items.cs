
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ItemsISMT

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITestingItems testingItems = new TestingItems();
            testingItems.Create();
            testingItems.Update();
            testingItems.Delete();
            Console.ReadLine();
        }
    }

    public interface ITestingItems
    {
        void Create();
        void Update();
        void Delete();
    }

    public class TestingItems : ITestingItems
    {
        public void Create()
        {
            Console.WriteLine(" Items created successfully");
        }

        public void Delete()
        {
            Console.WriteLine("Items Deleted successfully");
        }

        public void Update()
        {
            Console.WriteLine(" Items Updated successfully");

        }
    }


}
