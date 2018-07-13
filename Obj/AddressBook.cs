using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj
{
    public class AddressBook
    {
        public int txtContactId { get; set; }
        public int cboCatagoryId { get; set; }

        public string txtPersonName{get;set;}
        public string txtCompanyName { get; set; }
        public string txtMobileNo1 { get; set; }
        public string txtMobileNo2 { get; set; }
        public string txtLandlineNo1 { get; set; }
        public string txtLandlineNo2 { get; set; }
        public string txtHomeAddress { get; set; }
        public string txtOfficeAddress { get; set; }
        public string City { get; set; }//
    }
}
