using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalkToMePharmaDashBoard.Api
{
    public class UserMessage
    {
        public string BarcodeID { get; set; }
        public string Barcode { get; set; }
        public string DrugName { get; set; }
        public string MessageCount { get; set; }
        public string IsComplete { get; set; }
        public string LastDate { get; set; }
    }
}
