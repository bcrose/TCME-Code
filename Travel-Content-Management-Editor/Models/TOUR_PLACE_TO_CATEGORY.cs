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
    
    public partial class TOUR_PLACE_TO_CATEGORY
    {
        public decimal PLACE_TO_CATEGORY_ID { get; set; }
        public System.Guid PLACE_TO_CATEGORY_GUID { get; set; }
        public System.Guid PLACE_GUID { get; set; }
        public System.Guid CATEGORY_GUID { get; set; }
        public System.Guid ENTERED_BY { get; set; }
        public System.DateTime ENTERED_DATE_TIME { get; set; }
        public Nullable<System.Guid> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE_TIME { get; set; }
        public Nullable<System.Guid> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE_TIME { get; set; }
    }
}