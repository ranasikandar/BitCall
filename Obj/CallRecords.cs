using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj
{
    public class CallRecords
    {
        public int CallID { get; set; }

        public DateTime CallDateTime { get; set; }
        public int? ContactID { get; set; }
        public string CallingPerson { get; set; }
        public string CompanyName { get; set; }//
        public string CallingNo { get; set; }
        public int CategoryID { get; set; }
        public string CallDetail { get; set; }
        public bool IsOutgoing { get; set; }
        public DateTime EntryDateTime { get; set; }
        public string City { get; set; }//

        public string CallStaus { get; set; }//
    }
}
