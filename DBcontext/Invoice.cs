//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestBACKEND.DBcontext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public string PO_NUMBER { get; set; }
        public Nullable<double> PaymentNO { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public string PARTOL_TYPE { get; set; }
        public Nullable<double> O_ty { get; set; }
        public Nullable<double> AMOUNT { get; set; }
        public Nullable<double> Price_Liter { get; set; }
        public Nullable<double> shipping_Address { get; set; }
        public Nullable<double> CustomerID { get; set; }
        public string Customername { get; set; }
        public Nullable<double> TaxNumber { get; set; }
        public double InvoiceNumber { get; set; }
        public Nullable<double> Filling_Time { get; set; }
        public Nullable<double> Vat_7___inclusive_ { get; set; }
        public Nullable<double> Grand_Total { get; set; }
        public string Company_Name_ { get; set; }
        public string Address_ { get; set; }
    }
}
