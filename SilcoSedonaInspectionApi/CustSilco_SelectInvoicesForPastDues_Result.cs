//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilcoSedonaInspectionApi
{
    using System;
    
    public partial class CustSilco_SelectInvoicesForPastDues_Result
    {
        public Nullable<int> invoicenumber { get; set; }
        public string InvoiceDate { get; set; }
        public int Customer_Id { get; set; }
        public int Customer_Site_Id { get; set; }
        public string invdesc { get; set; }
        public string partdesc { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> LineItemExtPrice { get; set; }
        public Nullable<decimal> TotalInv { get; set; }
        public Nullable<System.DateTime> Invoice_Date { get; set; }
        public string memo { get; set; }
        public string ServCompany { get; set; }
        public string Techname { get; set; }
    }
}
