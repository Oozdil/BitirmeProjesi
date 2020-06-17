using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkToMePharmaDashBoard.Api
{
    public class WebApi
    {
        string BaseUrlAddress = "https://orcun-ozdil.site/FinalYearProject/Api/";
        WebClient client = new WebClient();
        

      

        public WebApi()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
       


        public AdminUser LoginUser(string username, string password)
        {

            AdminUser adminUser = new AdminUser() { UserID = "0" };
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/LoginUser", new NameValueCollection()
                     {
                         { "postData",username+","+password }
                     });
                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                adminUser = Newtonsoft.Json.JsonConvert.DeserializeObject<AdminUser>(result);
            }
            return adminUser;
        }
        public string AboutText(AdminUser appUser)
        {
           // CreateLog("About Text",appUser);
            string aboutText = "";
            using (WebClient client = new WebClient())
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/AboutText", new NameValueCollection()
                { });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                aboutText = result;
            }
            return aboutText;
        }
        public List<Drug> DrugList(bool showPassives, string searchTerm, AdminUser appUser)
        {
            //CreateLog("DrugList", appUser);
            List<Drug> drugList = new List<Drug>();
            using ( client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress+ "Admin/DrugList", new NameValueCollection()
                     {
                         { "postData",showPassives.ToString()+","+searchTerm }
                     });
              
                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                drugList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Drug>>(result);              
            }
            return drugList;
        }        
        public Drug GetDrugByBarcode(string barcode, AdminUser appUser)
        {
           // CreateLog("GetDrugByBarcode:"+barcode, appUser);
            Drug d = new Drug();
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/GetDrugByBarcode", new NameValueCollection()
                     {
                         { "postData",barcode }
                     });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);

                //TO DO post data ifadesini kaldır
                result = result.Substring(0, result.IndexOf("PostData"));

                d = Newtonsoft.Json.JsonConvert.DeserializeObject<Drug>(result);
            }
            return d;
        }
        public Drug InsertDrug(string barcode, string name, AdminUser appUser)
        {
            //CreateLog("InsertDrug:" + barcode, appUser);
            Drug d = new Drug();
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/InsertDrug", new NameValueCollection()
                     {
                         { "postData",barcode+","+name }
                     });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                d.ID = result;
            }
            return d;
        }
        public List<UserMessage> MessagesList(AdminUser appUser)
        {
            //CreateLog("MessagesList" , appUser);
            List<UserMessage> MessagesListt = new List<UserMessage>();
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/MessagesList", new NameValueCollection()
                {
                });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                MessagesListt = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserMessage>>(result);
            }
            return MessagesListt;

        }
        public List<AdminUser> AdminList(AdminUser appUser)
        {
           // CreateLog("AdminList", appUser);
            List<AdminUser> AdminList = new List<AdminUser>();
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/AdminList", new NameValueCollection()
                {
                });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                AdminList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<AdminUser>>(result);
            }
            return AdminList;
        }
        public List<SearchStats> GetStats(AdminUser appUser)
        {
            //CreateLog("GetStats", appUser);
            List<SearchStats> statistics = new List<SearchStats>();
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/GetStats", new NameValueCollection()
                {
                });
                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                statistics = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SearchStats>>(result);
            }
            return statistics;
        }        
        public AdminUser InsertAdmin(AdminUser admin, AdminUser appUser)
        {
           // CreateLog("InsertAdmin:"+admin.FullName, appUser);
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(admin);
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/InsertAdmin", new NameValueCollection()
                     {
                         { "postData",jsonString}
                     });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                admin = Newtonsoft.Json.JsonConvert.DeserializeObject<AdminUser>(result);
            }
            return admin;
        }
        public void UpdateAdmin(AdminUser admin, AdminUser appUser)
        {
           // CreateLog("UpdateAdmin:" + admin.FullName, appUser);
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(admin);
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/UpdateAdmin", new NameValueCollection()
                     {
                         { "postData",jsonString}
                     });
                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
            }
        }
        public int UpdateRRSDrug(Drug drug, AdminUser appUser)
        {
            //CreateLog("UpdateRRSDrug:" + drug.ID.ToString(), appUser);
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(drug);
            int updateResult;
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/UpdateRRSDrug", new NameValueCollection()
                     {
                         { "postData",jsonString}
                     });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                updateResult= Convert.ToInt32(result);
            }
            return updateResult;
        }
        public void UpdateFullDrug(Drug drugToUpdate, AdminUser appUser)
        {
          //  CreateLog("UpdateFullDrug:" + drugToUpdate.ID.ToString(), appUser);

            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(drugToUpdate);
            using (client)
            {
                byte[] gelenYanit = client.UploadValues(BaseUrlAddress + "Admin/UpdateFullDrug", new NameValueCollection()
                     {
                         { "postData",jsonString}
                     });

                string result = System.Text.Encoding.UTF8.GetString(gelenYanit);
               // MessageBox.Show(result);
            }

        }

      
       
    }
}
