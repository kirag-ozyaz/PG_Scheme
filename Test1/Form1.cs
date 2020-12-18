using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace Test1
{
    public partial class Form1 : FormLbr.FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_ClientSizeChanged(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_LocationChanged(object sender, EventArgs e)
        {
            //
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            pageReestrDocs1.SqlSettings = this.SqlSettings;
        }

        private void dtpDateDoc_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the DateTimePicker.ValueChanged event.");
        }

        private void dtpDateDoc_CloseUp(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the DateTimePicker.CloseUp event.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string machineName = "ulges-app";
            var services = ServiceController.GetServices(machineName);
            var service = services.First(s => s.ServiceName == "EIS SchemeService");
            service.Stop();

            service.Start();
            
        }

        private void toolStripButtonExportExcel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
        internal SchemeCtrl2.WCF.Proxy_Singleton proxy_Singleton_0 = SchemeCtrl2.WCF.Proxy_Singleton.GetInstance();
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string hostName = System.Net.Dns.GetHostName();
                System.Net.IPAddress ipaddress = System.Net.Dns.GetHostByName(hostName).AddressList[0];
                System.ServiceModel.NetTcpBinding netTcpBinding = new System.ServiceModel.NetTcpBinding(System.ServiceModel.SecurityMode.None);
                netTcpBinding.Security.Mode = System.ServiceModel.SecurityMode.None;
                netTcpBinding.SendTimeout = TimeSpan.FromSeconds(10.0);
                netTcpBinding.ReliableSession.Enabled = true;

            //    FormGeneralScheme2 formGeneralScheme2 = new FormGeneralScheme2(new SQLSettings(this.eisSettings.SqlSettings), new EndpointAddress(new Uri("net.tcp://192.168.1.248:22222/WCFSchemeServer").ToString()), 1);
//
            }
            catch
                {
                }
            
    
        }
    }
}
