using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TalkToMePharmaDashBoard.Api
{
    public class Drug
    {
        public string ID { get; set; }
        public string Barcode { get; set; }
        public string DrugName { get; set; }
        public string SGK_Code { get; set; }
        public string TITCK_Code { get; set; }
        public string RRS_CreationDate { get; set; }
        public string RRS_UpdateDate { get; set; }
        public string RRS_Status { get; set; }
        public string NameAudioFilePath { get; set; }
        public string NameTextFilePath { get; set; }
        public string TitckLink { get; set; }
        public string DescriptionAudioFilePath { get; set; }
        public string DescriptionTextFilePath { get; set; }
        public string Aktive { get; set; }
        public string DateOfCreate { get; set; }

        public string NameAudioFileExists { get; set; }
        public string DescriptionAudioFileExists { get; set; }
        public string TitckLinkExists { get; set; }
    }
}
