namespace BuilderInheritance
{
    using System;
    using System.Collections.Generic;

    public class SalesInvoice
    {
        public long OrderId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public IList<SalesInvoiceDisclaimer> Disclaimers { get; set; }
        public static Builder New => new Builder();
        public class Builder : SalesInvoiceDisclaimersBuilder<Builder> { }

        public override string ToString()
        {
            return $"{nameof(OrderId)}: {OrderId}, {nameof(InvoiceDate)}: {InvoiceDate}";
        }
    }
}
