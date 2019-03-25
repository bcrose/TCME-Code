using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel_Content_Management_Editor.Models
{
    public class ViewModel
    {
        public IEnumerable<TOUR_ORGANIZATION_TO_ITEM> orgToItem { get; set; }
        public IEnumerable<TOUR> tour {get; set;}
        public IEnumerable<TOUR_PLACE> place { get; set; }
    }
}