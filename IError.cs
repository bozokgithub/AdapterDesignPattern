namespace AdapterDesignPattern
{
    interface IError
        { 
            int ErrorNumber { get; set; }
            string Description { get; set; }
            void SendMail();
        }
    
}