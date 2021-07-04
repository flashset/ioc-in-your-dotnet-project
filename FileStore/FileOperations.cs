using DataStore;
using System;

namespace FileStore
{
    public class FileOperations : IOperations
    { 
        public bool Write(string data)
        {
            Console.WriteLine("FileOperations:Write");
            return true;
        } 
        public string Read()
        {
            Console.WriteLine("FileOperations:Read");
            return string.Empty;
        }
        public bool Delete()
        {
            Console.WriteLine("FileOperations:Delete");
            return true;
        }
    }
}
