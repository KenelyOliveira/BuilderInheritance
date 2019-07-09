using System;

namespace BuilderInheritance
{
    public class SalesInvoiceBuilder<T> : GenericBuilder<SalesInvoiceBuilder<T>> where T : SalesInvoiceBuilder<T>
    {
        public SalesInvoice SalesInvoice = new SalesInvoice();
        public T WithOrderId(long orderId)
        {
            this.SalesInvoice.OrderId = orderId;
            return this as T;
        }

        public T WithInvoiceDate(DateTime invoiceDate)
        {
            this.SalesInvoice.InvoiceDate = invoiceDate;
            return this as T;
        }

        public T Print()
        {
            Console.WriteLine(this.SalesInvoice.ToString());
            foreach (var item in this.SalesInvoice.Disclaimers)
            {
                Console.WriteLine(item.ToString());
            }

            return this as T;
        }
    }
}
