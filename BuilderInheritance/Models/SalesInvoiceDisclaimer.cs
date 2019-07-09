namespace BuilderInheritance
{
    using System;

    public struct SalesInvoiceDisclaimer
    {
        public string Disclaimer { get; set; }

        public override string ToString()
        {
            return $"{nameof(Disclaimer)}: {Disclaimer}";
        }
    }
}
