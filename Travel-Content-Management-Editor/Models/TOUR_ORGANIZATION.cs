//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel_Content_Management_Editor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOUR_ORGANIZATION
    {
        public decimal ORGANIZATION_ID { get; set; }
        public System.Guid ORGANIZATION_GUID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_DESC { get; set; }
        public Nullable<bool> FILTER_BY_LOCATION { get; set; }
        public string LOCATION { get; set; }
        public Nullable<double> LATITUDE { get; set; }
        public Nullable<double> LONGITUDE { get; set; }
        public string URL { get; set; }
        public string JOIN_CODE { get; set; }
        public Nullable<bool> ORGANIZATION_IS_PUBLIC { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string CONTACT_PHONE { get; set; }
        public System.Guid ENTERED_BY { get; set; }
        public System.DateTime ENTERED_DATE_TIME { get; set; }
        public Nullable<System.Guid> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE_TIME { get; set; }
        public Nullable<System.Guid> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE_TIME { get; set; }
    }
}