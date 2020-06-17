using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkToMePharmaDashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Api.WebApi webApi = new Api.WebApi();

            //var list = webApi.DrugList(false, "test");
           // var text = webApi.AboutText(User);
            //MessageBox.Show(text);
            //var drug = webApi.GetDrugByBarcode("8699525134028");
            // var drug = webApi.InsertDrug("86990000","test123");
            //var list = webApi.MessagesList();
            //var list = webApi.AdminList();

            //var admin = webApi.LoginUser("eczorcun","123");

            //var list = webApi.GetStats();
            //foreach (var s in list)
            //{
            //    MessageBox.Show(s.DrugName);
            //}
            //webApi.CreateLog("Test","1");


        }
    }
}
