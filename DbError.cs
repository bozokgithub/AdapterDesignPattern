using System;

namespace AdapterDesignPattern
{
    public class DbError : IError
        {
            private int _errorNumber;
            private string _description;

            public int ErrorNumber
            {
                get { return _errorNumber; }
                set { _errorNumber = value; }
            }

            public string Description 
            {
                get { return _description; }
                set { _description = value; }
            }


            public void SendMail()
            {
                Console.WriteLine("{0} {1} -> Db error has been sent", ErrorNumber.ToString(), Description);
            }
        }
    
}