using DBStore;
using FileStore;
using System.Configuration;
using Unity;

namespace DataStore.Resolver
{
    public  class DataResolver
    {       
        static readonly string DataStoreProvider = ConfigurationManager.AppSettings["DataStoreProvider"];

        static IUnityContainer container;
        public static void RegisterResolver()
        {
            // container instance
            container = new UnityContainer();

            switch (DataStoreProvider)
            {
                case "FileStore":
                    container.RegisterType<IOperations, FileOperations>();
                    break;
                case "DBStore": 
                    container.RegisterType<IOperations, DBOperations>();
                    break;              
            }
        }

        public static T GetInstance<T>()
        {
            return container.Resolve<T>();
        }
    }
}
