//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int PersonID { get; set; }
        public Nullable<int> BusinessEntityID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public string PersonType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public Nullable<int> SalesPersonID { get; set; }
    
        public virtual Territory Territory { get; set; }
    }
}
