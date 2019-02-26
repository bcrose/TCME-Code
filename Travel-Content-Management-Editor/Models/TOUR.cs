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
    
    public partial class TOUR
    {
        public decimal TOUR_ID { get; set; }
        public System.Guid TOUR_GUID { get; set; }
        public Nullable<System.Guid> CATEGORY_GUID { get; set; }
        public string TOUR_NAME { get; set; }
        public string TOUR_SUMMARY { get; set; }
        public string TOUR_DESC { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public string URL { get; set; }
        public string BOOK_NOW_URL { get; set; }
        public Nullable<bool> TOUR_IS_PUBLIC { get; set; }
        public string DURATION { get; set; }
        public string COST { get; set; }
        public string GROUP_SIZE { get; set; }
        public string ADDITIONAL_INFO { get; set; }
        public System.Guid ENTERED_BY { get; set; }
        public System.DateTime ENTERED_DATE_TIME { get; set; }
        public Nullable<System.Guid> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE_TIME { get; set; }
        public Nullable<System.Guid> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE_TIME { get; set; }
    }
}