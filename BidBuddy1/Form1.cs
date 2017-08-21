using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BidBuddy1
{

    public partial class Form1 : Form
    {
        Presto p;
        public Form1()
        {
            InitializeComponent();
            p = new Presto();
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            webBrowser1.Dock = DockStyle.Fill;

            webBrowser1.ScriptErrorsSuppressed = true;
            wb1.ScriptErrorsSuppressed = true;
            wb2.ScriptErrorsSuppressed = true;
            wb3.ScriptErrorsSuppressed = true;
            wb4.ScriptErrorsSuppressed = true;
            wb5.ScriptErrorsSuppressed = true;
            wb6.ScriptErrorsSuppressed = true;
            wb7.ScriptErrorsSuppressed = true;
            wb8.ScriptErrorsSuppressed = true;
            wb9.ScriptErrorsSuppressed = true;
            wb10.ScriptErrorsSuppressed = true;
            wb11.ScriptErrorsSuppressed = true;
            wb12.ScriptErrorsSuppressed = true;
            wb13.ScriptErrorsSuppressed = true;
            wb14.ScriptErrorsSuppressed = true;
            wb15.ScriptErrorsSuppressed = true;
            wb16.ScriptErrorsSuppressed = true;
            wb17.ScriptErrorsSuppressed = true;
            wb18.ScriptErrorsSuppressed = true;
            wb19.ScriptErrorsSuppressed = true;
            wb20.ScriptErrorsSuppressed = true;

            wb1.DocumentCompleted += wb_DocumentCompleted;
            wb2.DocumentCompleted += wb_DocumentCompleted;
            wb3.DocumentCompleted += wb_DocumentCompleted;
            wb4.DocumentCompleted += wb_DocumentCompleted;
            wb5.DocumentCompleted += wb_DocumentCompleted;
            wb6.DocumentCompleted += wb_DocumentCompleted;
            wb7.DocumentCompleted += wb_DocumentCompleted;
            wb8.DocumentCompleted += wb_DocumentCompleted;
            wb9.DocumentCompleted += wb_DocumentCompleted;
            wb10.DocumentCompleted += wb_DocumentCompleted;
            wb11.DocumentCompleted += wb_DocumentCompleted;
            wb12.DocumentCompleted += wb_DocumentCompleted;
            wb13.DocumentCompleted += wb_DocumentCompleted;
            wb14.DocumentCompleted += wb_DocumentCompleted;
            wb15.DocumentCompleted += wb_DocumentCompleted;
            wb16.DocumentCompleted += wb_DocumentCompleted;
            wb17.DocumentCompleted += wb_DocumentCompleted;
            wb18.DocumentCompleted += wb_DocumentCompleted;
            wb19.DocumentCompleted += wb_DocumentCompleted;
            wb20.DocumentCompleted += wb_DocumentCompleted;

           
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).DocumentCompleted -= wb_DocumentCompleted;
            this.Text =
            ((WebBrowser)sender).Url.ToString();
            ((WebBrowser)sender).Visible = true;
            //<img id="imgExpertImage" src="//expertsimages.kassrv.com/experts-pictures/small/pic1017576.jpg" alt="Bilal Ahsan" style="border-width:0px;">
            if (((WebBrowser)sender).DocumentText.IndexOf("pic1017576.jpg") > 100)
            {
                //Already Bidded
                ((WebBrowser)sender).Navigate("http://expertsimages.kassrv.com/experts-pictures/small/pic1017576.jpg");
                return;
            } 
            System.Diagnostics.Process.Start(((WebBrowser)sender).Url.ToString());
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Dock = DockStyle.None;

            p.parse(webBrowser1.DocumentText);

            while (p.parseComplete == false) {
                Application.DoEvents();
            }

            wb1.Navigate(p.MakeLink(p.QIDs[1]));
            wb2.Navigate(p.MakeLink(p.QIDs[2]));
            wb3.Navigate(p.MakeLink(p.QIDs[3]));
            wb4.Navigate(p.MakeLink(p.QIDs[4]));
            wb5.Navigate(p.MakeLink(p.QIDs[5]));
            wb6.Navigate(p.MakeLink(p.QIDs[6]));
            wb7.Navigate(p.MakeLink(p.QIDs[7]));
            wb8.Navigate(p.MakeLink(p.QIDs[8]));
            wb9.Navigate(p.MakeLink(p.QIDs[9]));
            wb10.Navigate(p.MakeLink(p.QIDs[10]));
            wb11.Navigate(p.MakeLink(p.QIDs[11]));
            wb12.Navigate(p.MakeLink(p.QIDs[12]));
            wb13.Navigate(p.MakeLink(p.QIDs[13]));
            wb14.Navigate(p.MakeLink(p.QIDs[14]));
            wb15.Navigate(p.MakeLink(p.QIDs[15]));
            wb16.Navigate(p.MakeLink(p.QIDs[16]));
            wb17.Navigate(p.MakeLink(p.QIDs[17]));
            wb18.Navigate(p.MakeLink(p.QIDs[18]));
            wb19.Navigate(p.MakeLink(p.QIDs[19]));
            wb20.Navigate(p.MakeLink(p.QIDs[20]));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            p.Prepare();
            webBrowser1.Navigate(p.entry);
           

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
