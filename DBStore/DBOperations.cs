using DataStore;
using System;

namespace DBStore
{
    public class DBOperations : IOperations
    {
        public bool Write(string data)
        {
            Console.WriteLine("DBOperations:Write");
            return true;
        }

        public string Read()
        {
            Console.WriteLine("DBOperations:Read");
            return string.Empty;
        }

        public bool Delete()
        {
            Console.WriteLine("DBOperations:Delete");
            return true;
        }
    }
}
