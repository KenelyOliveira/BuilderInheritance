using System.Collections.Generic;

namespace BuilderInheritance
{
    public class SalesInvoiceDisclaimersBuilder<T> : SalesInvoiceBuilder<SalesInvoiceDisclaimersBuilder<T>> where T : SalesInvoiceDisclaimersBuilder<T>
    {
        public T WithDisclaimer(string disclaimer)
        {
            if (this.SalesInvoice.Disclaimers is null)
                this.SalesInvoice.Disclaimers = new List<SalesInvoiceDisclaimer>();

            this.SalesInvoice.Disclaimers.Add(new SalesInvoiceDisclaimer() { Disclaimer = disclaimer });
            return this as T;
        }
    }
}
