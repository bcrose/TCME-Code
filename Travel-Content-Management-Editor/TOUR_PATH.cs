//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel_Content_Management_Editor
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOUR_PATH
    {
        public decimal PATH_ID { get; set; }
        public System.Guid PATH_GUID { get; set; }
        public Nullable<System.Guid> TOUR_GUID { get; set; }
        public string PATH_NAME { get; set; }
        public string PATH_DESC { get; set; }
        public Nullable<double> TOTAL_DISTANCE { get; set; }
        public Nullable<double> MIN_LATITUDE { get; set; }
        public Nullable<double> MAX_LATITUDE { get; set; }
        public Nullable<double> MIN_LONGITUDE { get; set; }
        public Nullable<double> MAX_LONGITUDE { get; set; }
        public string GEOJSON_URL { get; set; }
        public decimal ORDER_BY { get; set; }
        public Nullable<System.Guid> ENTERED_BY { get; set; }
        public System.DateTime ENTERED_DATE_TIME { get; set; }
        public Nullable<System.Guid> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE_TIME { get; set; }
        public Nullable<System.Guid> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE_TIME { get; set; }
    }
}
