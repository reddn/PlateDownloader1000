namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxDownloadPlates = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAllPlates = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBoxIAP = new System.Windows.Forms.CheckBox();
            this.checkBoxDP = new System.Windows.Forms.CheckBox();
            this.checkBoxSTAR = new System.Windows.Forms.CheckBox();
            this.checkBoxAPD = new System.Windows.Forms.CheckBox();
            this.checkBoxMIN = new System.Windows.Forms.CheckBox();
            this.checkBoxHOT = new System.Windows.Forms.CheckBox();
            this.checkBoxODP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxUseAirportCode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxMDTAirports = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(380, 282);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(119, 36);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Get Plates";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 48);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(414, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 60);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(320, 125);
            this.textBox3.TabIndex = 2;
            // 
            // checkBoxDownloadPlates
            // 
            this.checkBoxDownloadPlates.AutoSize = true;
            this.checkBoxDownloadPlates.Checked = true;
            this.checkBoxDownloadPlates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDownloadPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDownloadPlates.Location = new System.Drawing.Point(3, 61);
            this.checkBoxDownloadPlates.Name = "checkBoxDownloadPlates";
            this.checkBoxDownloadPlates.Size = new System.Drawing.Size(122, 19);
            this.checkBoxDownloadPlates.TabIndex = 4;
            this.checkBoxDownloadPlates.Text = "Download Plates";
            this.checkBoxDownloadPlates.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBoxDownloadPlates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Airport(s)";
            this.toolTip1.SetToolTip(this.label1, "Enter FAA Airport Codes separated by a space");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxAllPlates
            // 
            this.checkBoxAllPlates.AutoSize = true;
            this.checkBoxAllPlates.Location = new System.Drawing.Point(26, 93);
            this.checkBoxAllPlates.Name = "checkBoxAllPlates";
            this.checkBoxAllPlates.Size = new System.Drawing.Size(88, 21);
            this.checkBoxAllPlates.TabIndex = 6;
            this.checkBoxAllPlates.Text = "All Plates";
            this.checkBoxAllPlates.UseVisualStyleBackColor = true;
            this.checkBoxAllPlates.CheckedChanged += new System.EventHandler(this.checkBoxAllPlates_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created By:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 301);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 34);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "";
            this.linkLabel1.Text = "Thomas Sweeney - MDT\r\nThomas@reddn.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBoxIAP
            // 
            this.checkBoxIAP.AutoSize = true;
            this.checkBoxIAP.Checked = true;
            this.checkBoxIAP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIAP.Location = new System.Drawing.Point(3, 120);
            this.checkBoxIAP.Name = "checkBoxIAP";
            this.checkBoxIAP.Size = new System.Drawing.Size(106, 21);
            this.checkBoxIAP.TabIndex = 10;
            this.checkBoxIAP.Text = "Approaches";
            this.checkBoxIAP.UseVisualStyleBackColor = true;
            // 
            // checkBoxDP
            // 
            this.checkBoxDP.AutoSize = true;
            this.checkBoxDP.Checked = true;
            this.checkBoxDP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDP.Location = new System.Drawing.Point(3, 174);
            this.checkBoxDP.Name = "checkBoxDP";
            this.checkBoxDP.Size = new System.Drawing.Size(49, 21);
            this.checkBoxDP.TabIndex = 11;
            this.checkBoxDP.Text = "DP";
            this.checkBoxDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDP.UseVisualStyleBackColor = true;
            // 
            // checkBoxSTAR
            // 
            this.checkBoxSTAR.AutoSize = true;
            this.checkBoxSTAR.Checked = true;
            this.checkBoxSTAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSTAR.Location = new System.Drawing.Point(3, 147);
            this.checkBoxSTAR.Name = "checkBoxSTAR";
            this.checkBoxSTAR.Size = new System.Drawing.Size(67, 21);
            this.checkBoxSTAR.TabIndex = 12;
            this.checkBoxSTAR.Text = "STAR";
            this.checkBoxSTAR.UseVisualStyleBackColor = true;
            // 
            // checkBoxAPD
            // 
            this.checkBoxAPD.AutoSize = true;
            this.checkBoxAPD.Checked = true;
            this.checkBoxAPD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAPD.Location = new System.Drawing.Point(3, 201);
            this.checkBoxAPD.Name = "checkBoxAPD";
            this.checkBoxAPD.Size = new System.Drawing.Size(129, 21);
            this.checkBoxAPD.TabIndex = 13;
            this.checkBoxAPD.Text = "Airport Diagram";
            this.checkBoxAPD.UseVisualStyleBackColor = true;
            // 
            // checkBoxMIN
            // 
            this.checkBoxMIN.AutoSize = true;
            this.checkBoxMIN.Location = new System.Drawing.Point(3, 228);
            this.checkBoxMIN.Name = "checkBoxMIN";
            this.checkBoxMIN.Size = new System.Drawing.Size(111, 21);
            this.checkBoxMIN.TabIndex = 14;
            this.checkBoxMIN.Text = "Takeoff Mins";
            this.checkBoxMIN.UseVisualStyleBackColor = true;
            this.checkBoxMIN.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxHOT
            // 
            this.checkBoxHOT.AutoSize = true;
            this.checkBoxHOT.Location = new System.Drawing.Point(3, 255);
            this.checkBoxHOT.Name = "checkBoxHOT";
            this.checkBoxHOT.Size = new System.Drawing.Size(86, 21);
            this.checkBoxHOT.TabIndex = 15;
            this.checkBoxHOT.Text = "Hotspots";
            this.checkBoxHOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxHOT.UseVisualStyleBackColor = true;
            // 
            // checkBoxODP
            // 
            this.checkBoxODP.AutoSize = true;
            this.checkBoxODP.Location = new System.Drawing.Point(95, 255);
            this.checkBoxODP.Name = "checkBoxODP";
            this.checkBoxODP.Size = new System.Drawing.Size(60, 21);
            this.checkBoxODP.TabIndex = 16;
            this.checkBoxODP.Text = "ODP";
            this.checkBoxODP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.checkBoxODP, "Obstacle Departure Procedures");
            this.checkBoxODP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ver. 0.091";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBoxUseAirportCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(162, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 157);
            this.panel1.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 52);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chart Cycles Available";
            // 
            // checkBoxUseAirportCode
            // 
            this.checkBoxUseAirportCode.AutoSize = true;
            this.checkBoxUseAirportCode.Checked = true;
            this.checkBoxUseAirportCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseAirportCode.Location = new System.Drawing.Point(4, 25);
            this.checkBoxUseAirportCode.Name = "checkBoxUseAirportCode";
            this.checkBoxUseAirportCode.Size = new System.Drawing.Size(197, 21);
            this.checkBoxUseAirportCode.TabIndex = 1;
            this.checkBoxUseAirportCode.Tag = "Heeey";
            this.checkBoxUseAirportCode.Text = "Make Filenames Readable";
            this.toolTip1.SetToolTip(this.checkBoxUseAirportCode, resources.GetString("checkBoxUseAirportCode.ToolTip"));
            this.checkBoxUseAirportCode.UseVisualStyleBackColor = true;
            this.checkBoxUseAirportCode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filename Controls";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clear Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxMDTAirports
            // 
            this.checkBoxMDTAirports.AutoSize = true;
            this.checkBoxMDTAirports.Location = new System.Drawing.Point(378, 191);
            this.checkBoxMDTAirports.Name = "checkBoxMDTAirports";
            this.checkBoxMDTAirports.Size = new System.Drawing.Size(113, 21);
            this.checkBoxMDTAirports.TabIndex = 21;
            this.checkBoxMDTAirports.Text = "MDT Airports";
            this.checkBoxMDTAirports.UseVisualStyleBackColor = true;
            this.checkBoxMDTAirports.CheckedChanged += new System.EventHandler(this.checkBoxMDTAirports_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 347);
            this.Controls.Add(this.checkBoxMDTAirports);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxODP);
            this.Controls.Add(this.checkBoxHOT);
            this.Controls.Add(this.checkBoxMIN);
            this.Controls.Add(this.checkBoxAPD);
            this.Controls.Add(this.checkBoxSTAR);
            this.Controls.Add(this.checkBoxDP);
            this.Controls.Add(this.checkBoxIAP);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxAllPlates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDownloadPlates);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Plate Downloader 1000";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxDownloadPlates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAllPlates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBoxIAP;
        private System.Windows.Forms.CheckBox checkBoxDP;
        private System.Windows.Forms.CheckBox checkBoxSTAR;
        private System.Windows.Forms.CheckBox checkBoxAPD;
        private System.Windows.Forms.CheckBox checkBoxMIN;
        private System.Windows.Forms.CheckBox checkBoxHOT;
        private System.Windows.Forms.CheckBox checkBoxODP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxUseAirportCode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxMDTAirports;
    }
}

