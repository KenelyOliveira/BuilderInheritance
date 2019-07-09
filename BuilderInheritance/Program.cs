namespace BuilderInheritance
{
    using System;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            SalesInvoice.New
                .WithOrderId(111999292)
                .WithInvoiceDate(DateTime.Now)
                .WithDisclaimer("Disclaimer 1")
                .WithDisclaimer("Disclaimer 2")
                .Print();

            Console.ReadLine();
        }
    }
}