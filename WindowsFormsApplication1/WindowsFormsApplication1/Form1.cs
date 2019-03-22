using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private XmlDocument xmlobj;
        private string dldir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Plate Downloader 1000\";
        public Form1()
        {
            InitializeComponent();
            //XmlDocument newxml = new XmlDocument();
            xmlobj = new XmlDocument();
            xmlobj.Load(@"C:\Users\thoma\Downloads\faafiles\d-tpp_Metafile.xml");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string cycle = @"\1701\";
            // string url = "https://www.faa.gov/air_traffic/flight_info/aeronav/digital_products/dtpp/search/";
            //            Uri url = new Uri("https://www.faa.gov/air_traffic/flight_info/aeronav/digital_products/dtpp/search/");
            //Uri url = new Uri("http://stackoverflow.com/questions/6304453/javascript-append-html-to-container-element-without-innerhtml");
            //string url = "http://www.drudgereport.com/";

            string xml;
            // ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            //XmlDocument xmlobj = new XmlDocument();
            //xmlobj.Load(@"C:\Users\thoma\Downloads\faafiles\d-tpp_Metafile.xml");

            //XmlNode rootnode = xmlobj.FirstChild;
            //string airportpattern = "CXY MDT LNS MDT";
            textBox1.AppendText(xmlobj["digital_tpp"].Attributes["cycle"].Value);
            Directory.CreateDirectory(dldir);
            Directory.CreateDirectory(dldir + cycle);
            foreach(XmlNode node in xmlobj.ChildNodes)
            {
                               
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        foreach (XmlNode node3 in node2.ChildNodes)
                        {
                            //if(node3.Attributes["apt_ident"].Value == "CXY")
                                if (Regex.IsMatch(textBox2.Text, node3.Attributes["apt_ident"].Value , RegexOptions.IgnoreCase)) 
                            {
                                textBox3.AppendText("---" + node3.Attributes["apt_ident"].Value + "---\r\n");
                                foreach (XmlNode node4 in node3.ChildNodes)
                                {
                                    //textBox3.Text += node4.Name + node4.Value;
                                    textBox3.AppendText("Downloading - " + node4["chart_name"].InnerText);//+ " " + "http://aeronav.faa.gov/d-tpp/1701/" + node4["pdf_name"].InnerText + "\r\n");
                                    string filename;
                                    
                                    if (checkBoxUseAirportCode.Checked)
                                    {
                                        filename = node3.Attributes["apt_ident"].Value + " ";
                                        filename += node4["chart_name"].InnerText + ".pdf";

                                    } else
                                    {
                                        filename = node4["pdf_name"].InnerText;
                                    }
                                    if (checkBoxDownloadPlates.Checked)
                                    {
                                        WebClient wc22 = new WebClient();
                                        wc22.DownloadFile(@"http://aeronav.faa.gov/d-tpp/1701/" + node4["pdf_name"].InnerText, dldir + cycle + filename);
                                        textBox3.AppendText("-Done\r\n");
                                    } else
                                    {
                                        textBox3.AppendText("-Skipped. Download Plates not checked\r\n");
                                    }       
                                }
                            }       
                        }
                    }
                }
            }
            //textBox3.Text += Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\";
            //textBox3.Text += xmlobj.Attributes["cycle"];
            textBox3.AppendText("***Downloading Completed");

            WebClient wc = new WebClient();
            string mystring = System.IO.File.ReadAllText(@"C:\Users\thoma\Downloads\faafiles\Terminal Procedures – Basic Search.html");
            // xml = wc.DownloadString(textBox2.Text);
            //            wc.DownloadFile(textBox2.Text, @"C:\Users\thoma\Desktop\mystuff.txt");
            //textBox1.Text = xml;
            using (StringReader reader = new StringReader(mystring))
            {
                string line;
                string sPattern = @"\s*(\w{3})\s{0,1}(\d{2})\s?-\s?(\w{3})\s?(\d{2}),\s?(\d{4})\s?\[(\d{4})\].*";
                while ((line = reader.ReadLine()) != null)
                {
                    //   textBox1.Text = line;
                    //if (Regex.IsMatch(line, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)){
                    //                        string lin2 = line.Trim();
                    MatchCollection mymatch = Regex.Matches(line, sPattern);
                    if (mymatch.Count > 0) { 
                        foreach (Match match in mymatch)
                        {
                            textBox1.Text = match.Groups[1].Value + " ";   //begin date Month
                            textBox1.Text += match.Groups[2].Value + " - ";//begin date Day
                            textBox1.Text += match.Groups[3].Value + " ";   //end date Month
                            textBox1.Text += match.Groups[4].Value + " ";   //end day Day
                            textBox1.Text += match.Groups[5].Value + " [";  //end date YEAR
                            textBox1.Text += match.Groups[6].Value + "]";   //Cycle Number
                        }
                        //textBox2.Text = "Found " + mymatch.Count;
                    }
                  
                    
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(sender, e);
            }
        }
    }
}
