using System;

namespace DataStore
{
    public interface IOperations
    {
        bool Write(string data);

        string Read();

        bool Delete(); 

    }
}
