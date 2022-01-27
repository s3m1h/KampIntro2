using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4._2_interfaces_
{
    // data access layer - dal
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class PostgresServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Postgres Added");
        }

        public void Delete()
        {
            Console.WriteLine("Postgres Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Postgres Updated ");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
