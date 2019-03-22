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
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private XmlDocument xmlobj;
        private string dldir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Plate Downloader 1000\";
        bool xmlloaded = false;
        StringBuilder failedDownloads = new StringBuilder();
        StringBuilder chartsDeleted = new StringBuilder();
        StringBuilder chartsAdded = new StringBuilder();
        StringBuilder chartsChanged = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            //XmlDocument newxml = new XmlDocument();
            xmlobj = new XmlDocument();
            




            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebClient wc = new WebClient();
            //string mystring = System.IO.File.ReadAllText(@"C:\Users\thoma\Downloads\faafiles\Terminal Procedures – Basic Search.html");
            string mystring = "";
            try
            {
                mystring = wc.DownloadString(@"https://www.faa.gov/air_traffic/flight_info/aeronav/digital_products/dtpp/search/");
               // mystring = wc.DownloadString(@"https://www.faa.gov/air_traffic/flight_info/aeronav/digital_products/dtpp/search/");

            }
            catch (WebException eeee)
            {
                textBox1.Text = "Something messedup on the download " + eeee.Message;
            }
            string[,] thematch = new string[2, 6];
            using (StringReader reader = new StringReader(mystring))
            {
                string line;
                UInt16 matchcounter = 0;

                //string sPattern = @"/\s*(\w{3})\s{0,1}(\d{2})\s-\s?(\w{3})\s?(\d{2}),\s?(\d{4})\s?\[(\d{4})\].*/";
                //string sPattern = @"\s*(\w{3}\s{0,1}\d{2},?\s?\d{4}?\s-\s.*\[(\d{4})\]).*";
                string sPattern = @"\s*(\w{3}\s\d{2}\,?\s?\d{0,4}\s-\s\w{3}.*\[(\d{4})\]).*";
                while ((line = reader.ReadLine()) != null)
                {
                    //   textBox1.Text = line;
                    //if (Regex.IsMatch(line, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase)){
                    //                        string lin2 = line.Trim();


                    MatchCollection mymatch = Regex.Matches(line, sPattern);
                    //Debugger.Log(1, "none", "mymatch is" + mymatch.Count + " ");
                    //Debugger.Log(1, "none", "mymatch is" + line);
                    //textBox3.Text += line + "\n\r"; // this was to write the html file in textbox3 only debugging
                    if (mymatch.Count > 0)
                    {
                        matchcounter++;
                        
                        foreach (Match match in mymatch)
                        {
                            string mytext;
                            mytext = match.Groups[1].Value;
                            //Debugger.Log(1, "none", "group 0 is " + match.Groups[0] + "group 1 is " + match.Groups[1]);
                            //mytext = match.Groups[1].Value + " ";   //begin date Month
                            //mytext += match.Groups[2].Value + " - ";//begin date Day
                            //mytext += match.Groups[3].Value + " ";   //end date Month
                            //mytext += match.Groups[4].Value + " ";   //end day Day
                            //mytext += match.Groups[5].Value;// + " [";  //end date YEAR
                            ////mytext += match.Groups[6].Value + "]";   //Cycle Number
                            //thematch[matchcounter, 0] = match.Groups[1].Value;
                            //thematch[matchcounter, 1] = match.Groups[2].Value;
                            //thematch[matchcounter, 2] = match.Groups[3].Value;
                            //thematch[matchcounter, 3] = match.Groups[4].Value;
                            //thematch[matchcounter, 4] = match.Groups[5].Value;
                            //thematch[matchcounter, 5] = match.Groups[6].Value;

                            //listBox1.Items.Add(match.Groups[6].Value + " - " + mytext);
                            listBox1.Items.Add(match.Groups[2].Value + " - " + mytext);
                        }
                        matchcounter++;

                        //for(int i = 0; i < thematch.Length ; i++)
                        //{

                        //}
                        for (int i = 0; i < matchcounter + 1; i++)
                        {

                        }
                        //textBox2.Text = "Found " + mymatch.Count;

                    }


                }
                //textBox1.Clear();
                //for (int i = 0; i < matchcounter; i++)
                //{
                //    for (int j = 0; j < 6; j++)
                //    {
                //        textBox1.Text += thematch[i, j];
                //    }

                //}
            }
            mystring = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cycle;
            try
            {
                cycle = listBox1.SelectedItem.ToString().Substring(0, 4);
            }catch(Exception theex)
            {
                textBox3.Text = "You need to select a Cycle";
                return;
            }
            
            textBox1.Clear();
            //textBox1.AppendText("You selected Cycle " + cycles + "\r\n");
            textBox3.Clear();
            //xmlobj.Load(@"C:\Users\thoma\Downloads\faafiles\d-tpp_Metafile.xml");

            try
            {
                if (!xmlloaded)
                {
                    textBox3.Text = "Downloading XML file for cycle " + cycle + " ...";
                    xmlobj.Load(@"http://aeronav.faa.gov/d-tpp/" + cycle + "/xml_data/d-tpp_Metafile.xml");
                    textBox3.AppendText("Done\r\n");
                } else
                {

                }
            } catch(Exception exc)
            {
                textBox3.AppendText(" xml FAILED");
                xmlobj = null;
                return;
            }
            
            xmlloaded = true;

            bool getIAP = checkBoxIAP.Checked;
            bool getSTAR = checkBoxSTAR.Checked;
            bool getODP = checkBoxODP.Checked;
            bool getHOT = checkBoxHOT.Checked;
            bool getDP = checkBoxDP.Checked;
            bool getMIN = checkBoxMIN.Checked;
            bool getAPD = checkBoxAPD.Checked;
            if (checkBoxAllPlates.Checked)
            {
                getIAP = true;
                getSTAR = true;
                getODP = true;
                getHOT = true;
                getDP = true;
                getMIN = true;
                getAPD = true;
            }
            //string cycle = @"\1701\";
            //textBox1.AppendText(xmlobj["digital_tpp"].Attributes["cycle"].Value);
            Directory.CreateDirectory(dldir);
            Directory.CreateDirectory(dldir + cycle);
            string airportlist;
            if (checkBoxMDTAirports.Checked)
            {
                airportlist = "MDT CXY LNS SEG THV W05 ZER RDG N94 MUI MQS N79 N71 N68 N13 9D4 8N8 74N 58N 08N W05 2PS8 37PN 5PN9 64PN 79PN 91PN 02P ";
            } else
            {
                airportlist = textBox2.Text;
            }
            
            foreach (XmlNode node in xmlobj.ChildNodes)
            {
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        foreach (XmlNode node3 in node2.ChildNodes)
                        {
                                if (Regex.IsMatch(airportlist, node3.Attributes["apt_ident"].Value , RegexOptions.IgnoreCase)) 
                            {
                                textBox3.AppendText("---" + node3.Attributes["apt_ident"].Value + "---\r\n");
                                foreach (XmlNode node4 in node3.ChildNodes)
                                {
                                    switch (node4["chart_code"].InnerText)
                                    {
                                        case "MIN":
                                            if (getMIN)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                            break;
                                        case "IAP":
                                            if (getIAP)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                                break;
                                        case "STAR":
                                            if (getSTAR)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                                break;

                                        case "DP":
                                            if (getDP)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                            break;
                                        case "APD":
                                            if (getAPD)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                                break;
                                        case "HOT":
                                            if (getHOT)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                            break;
                                        

                                        case "ODP":
                                            if (getODP)
                                            {
                                                downloadchart(node3, node4, cycle);
                                            }
                                                break;
                                        default:
                                            break;
                                    }
                                    //downloadchart(node3,node4,cycle);
                                           
                                }
                            }       
                        }
                    }
                }
            }
            //textBox3.Text += Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\";
            //textBox3.Text += xmlobj.Attributes["cycle"];
            textBox3.AppendText(failedDownloads + "\r\n***Downloading Completed");
            textBox3.AppendText("\r\n\r\nProcedures different from last published cycle:\r\nadded:\r\n" + chartsAdded + "\r\nChanged:\r\n" + chartsChanged +
                "\r\nDeleted:\r\n" + chartsDeleted);
            chartsAdded.Clear();
            chartsDeleted.Clear();
            chartsChanged.Clear();



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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            xmlloaded = false;
            xmlobj = new XmlDocument();
        }

        private void downloadchart(XmlNode node3,XmlNode node4,string cycle)
        {

            switch (node4["useraction"].InnerText) {
                case "D": //  node4["chart_name"]  node3.Attributes["apt_ident"]  
                    chartsDeleted.Append(node3.Attributes["apt_ident"].Value + " - " + node4["chart_name"].InnerText + "\r\n");
                    return;
                case "A":
                    chartsAdded.Append(node3.Attributes["apt_ident"].Value + " - " + node4["chart_name"].InnerText + "\r\n");
                    break;
                case "C":
                    chartsChanged.Append(node3.Attributes["apt_ident"].Value + " - " + node4["chart_name"].InnerText + "\r\n");
                    break;
            }
                
                
            if(node4["useraction"].InnerText == "D")
            {
                textBox3.AppendText("Chart " + node4["chart_name"].InnerText + " Deleted. Not downloading\r\n");
                return;
            } 
            textBox3.AppendText(node4["chart_name"].InnerText);//+ " " + "http://aeronav.faa.gov/d-tpp/1701/" + node4["pdf_name"].InnerText + "\r\n");

            if (checkBoxDownloadPlates.Checked)
            {
                string filename;
                if (checkBoxUseAirportCode.Checked)
                {
                    filename = node3.Attributes["apt_ident"].Value + " ";
                    filename += node4["chart_name"].InnerText + ".pdf";
                }
                else
                {
                    filename = node4["pdf_name"].InnerText;
                }
                try { 
                WebClient wc22 = new WebClient();
                String url = @"http://aeronav.faa.gov/d-tpp/" + cycle + "/" + node4["pdf_name"].InnerText;
                textBox3.AppendText("dl'in " +url + "\r\n");
                wc22.DownloadFile(url, dldir + cycle + "\\" + filename);
                } catch(Exception exc)
                {
                    textBox3.AppendText(" -" + node4["pdf_name"]  + "Failed**\r\n");
                    failedDownloads.Append(node3.Attributes["apt_ident"].Value + "-"+ node4["chart_name"].InnerText+"-"+node4["pdf_name"] + "Failed**\r\n");
                }
                textBox3.AppendText("-Done\r\n");
            }
            else
            {
                textBox3.AppendText("-Skipped. Download Plates not checked\r\n");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void checkBoxMDTAirports_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMDTAirports.Checked)
            {
                textBox2.ReadOnly = true;
            } else
            {
                textBox2.ReadOnly = false;
            }
            
        }

        private void checkBoxAllPlates_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllPlates.Checked)
            {
                checkBoxIAP.Enabled = false;
                checkBoxSTAR.Enabled = false;
                checkBoxDP.Enabled = false;
                checkBoxMIN.Enabled = false;
                checkBoxODP.Enabled = false;
                checkBoxAPD.Enabled = false;
                checkBoxHOT.Enabled = false;
            } else
            {
                checkBoxIAP.Enabled = true;
                checkBoxSTAR.Enabled = true;
                checkBoxDP.Enabled = true;
                checkBoxMIN.Enabled = true;
                checkBoxODP.Enabled = true;
                checkBoxAPD.Enabled = true;
                checkBoxHOT.Enabled = true;
            }
        }
    }
}
