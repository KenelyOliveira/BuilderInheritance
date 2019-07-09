namespace BuilderInheritance
{
    using System.Collections.Generic;
    public abstract class GenericBuilder<T> where T : GenericBuilder<T>
    {
        protected SalesInvoice salesInvoice = new SalesInvoice() { Disclaimers = new List<SalesInvoiceDisclaimer>() };

        public SalesInvoice Build()
        {
            return salesInvoice;
        }
    }
}
