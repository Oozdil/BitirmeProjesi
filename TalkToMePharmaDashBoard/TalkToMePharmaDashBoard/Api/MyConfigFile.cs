using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkToMePharmaDashBoard.Api
{
    public class MyConfigFile
    {
        public string ProjectUrl { get; set; }
        public string RRS_Url { get; set; }
        public string RRS_DrugPage_Url { get; set; }
        public string FTP_Username { get; set; }
        public string FTP_Password { get; set; }
        public string FTP_Server { get; set; }
        public string PythonExePath { get; set; }
        public string CreateSoundPyPath { get; set; }
        public MyConfigFile()
        {
            ProjectUrl = "https://orcun-ozdil.site/FinalYearProject/Files/";
            RRS_Url = "https://recetem.enabiz.gov.tr/";
            RRS_DrugPage_Url = "https://recetem.enabiz.gov.tr/EBS/Drug";


            FTP_Username = "orcunozd";
            FTP_Password = "Ozge140409";
            FTP_Server = "37.230.109.29";

            PythonExePath = "C:\\Python36\\python.exe";
            CreateSoundPyPath = "C:\\Users\\orçun\\Desktop\\SesDosyasiOlustur\\SesDosyasiOlustur\\bin\\Debug\\CreateSound.py ";
        }
    }
}
