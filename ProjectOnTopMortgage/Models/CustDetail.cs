//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnTopMortgage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustDetail
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> MobileNumber { get; set; }
        public string AlternativeNumber { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> PostCode { get; set; }
        public string Housenameornumber { get; set; }
        public string LookingFor { get; set; }
        public Nullable<decimal> ValueOfTheProperty { get; set; }
        public Nullable<decimal> MorttgageAmount { get; set; }
        public Nullable<int> Term { get; set; }
        public string TypeOfRate { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> MissedEMI { get; set; }
    }
}