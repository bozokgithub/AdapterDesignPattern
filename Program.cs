using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fax fax = new Fax { FaxErrorCode = 4000, ErrorDescription = "No reply" };

            IError[] errors = {
                new DbError{ErrorNumber=100,Description="Not connected" },
                new DbError{ErrorNumber=101,Description="Query failed" },
                new ServiceError{ErrorNumber=300,Description="Authorization failed" },
                new FaxAdapter(fax)
            };

            foreach (IError error in errors)
                error.SendMail();

            Console.ReadKey();
        }
    }
}