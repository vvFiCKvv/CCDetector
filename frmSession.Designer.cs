namespace CCDetector
{
    partial class frmSession
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
            this.pnl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCCDM1Out = new System.Windows.Forms.Label();
            this.txtDivition_NP_NAP = new System.Windows.Forms.TextBox();
            this.txtNumOfPacketsNearAvarage = new System.Windows.Forms.TextBox();
            this.txtAvarageDelay = new System.Windows.Forms.TextBox();
            this.txtNomOfPackets = new System.Windows.Forms.TextBox();
            this.radioM1FromCapturedData = new System.Windows.Forms.RadioButton();
            this.radioM1FromGraphData = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioM2FromCapturedData = new System.Windows.Forms.RadioButton();
            this.radioM2FromGraphData = new System.Windows.Forms.RadioButton();
            this.txtRegularity = new System.Windows.Forms.TextBox();
            this.txtWindowsCount = new System.Windows.Forms.NumericUpDown();
            this.txtWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitESimilarity = new System.Windows.Forms.SplitContainer();
            this.splitEsimilarithGraphs = new System.Windows.Forms.SplitContainer();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWindowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWindowSize)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.splitESimilarity.Panel1.SuspendLayout();
            this.splitESimilarity.Panel2.SuspendLayout();
            this.splitESimilarity.SuspendLayout();
            this.splitEsimilarithGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.groupBox1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(736, 407);
            this.pnl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCCDM1Out);
            this.tabPage2.Controls.Add(this.txtDivition_NP_NAP);
            this.tabPage2.Controls.Add(this.txtNumOfPacketsNearAvarage);
            this.tabPage2.Controls.Add(this.txtAvarageDelay);
            this.tabPage2.Controls.Add(this.txtNomOfPackets);
            this.tabPage2.Controls.Add(this.radioM1FromCapturedData);
            this.tabPage2.Controls.Add(this.radioM1FromGraphData);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistical Detection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCCDM1Out
            // 
            this.lblCCDM1Out.AutoSize = true;
            this.lblCCDM1Out.ForeColor = System.Drawing.Color.Red;
            this.lblCCDM1Out.Location = new System.Drawing.Point(25, 267);
            this.lblCCDM1Out.Name = "lblCCDM1Out";
            this.lblCCDM1Out.Size = new System.Drawing.Size(0, 13);
            this.lblCCDM1Out.TabIndex = 11;
            // 
            // txtDivition_NP_NAP
            // 
            this.txtDivition_NP_NAP.Location = new System.Drawing.Point(111, 188);
            this.txtDivition_NP_NAP.Name = "txtDivition_NP_NAP";
            this.txtDivition_NP_NAP.ReadOnly = true;
            this.txtDivition_NP_NAP.Size = new System.Drawing.Size(100, 20);
            this.txtDivition_NP_NAP.TabIndex = 10;
            // 
            // txtNumOfPacketsNearAvarage
            // 
            this.txtNumOfPacketsNearAvarage.Location = new System.Drawing.Point(111, 139);
            this.txtNumOfPacketsNearAvarage.Name = "txtNumOfPacketsNearAvarage";
            this.txtNumOfPacketsNearAvarage.ReadOnly = true;
            this.txtNumOfPacketsNearAvarage.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfPacketsNearAvarage.TabIndex = 9;
            // 
            // txtAvarageDelay
            // 
            this.txtAvarageDelay.Location = new System.Drawing.Point(111, 90);
            this.txtAvarageDelay.Name = "txtAvarageDelay";
            this.txtAvarageDelay.ReadOnly = true;
            this.txtAvarageDelay.Size = new System.Drawing.Size(100, 20);
            this.txtAvarageDelay.TabIndex = 8;
            // 
            // txtNomOfPackets
            // 
            this.txtNomOfPackets.Location = new System.Drawing.Point(111, 45);
            this.txtNomOfPackets.Name = "txtNomOfPackets";
            this.txtNomOfPackets.ReadOnly = true;
            this.txtNomOfPackets.Size = new System.Drawing.Size(100, 20);
            this.txtNomOfPackets.TabIndex = 7;
            // 
            // radioM1FromCapturedData
            // 
            this.radioM1FromCapturedData.AutoSize = true;
            this.radioM1FromCapturedData.Location = new System.Drawing.Point(147, 14);
            this.radioM1FromCapturedData.Name = "radioM1FromCapturedData";
            this.radioM1FromCapturedData.Size = new System.Drawing.Size(123, 17);
            this.radioM1FromCapturedData.TabIndex = 6;
            this.radioM1FromCapturedData.Text = "Total captured Data ";
            this.radioM1FromCapturedData.UseVisualStyleBackColor = true;
            // 
            // radioM1FromGraphData
            // 
            this.radioM1FromGraphData.AutoSize = true;
            this.radioM1FromGraphData.Checked = true;
            this.radioM1FromGraphData.Location = new System.Drawing.Point(28, 14);
            this.radioM1FromGraphData.Name = "radioM1FromGraphData";
            this.radioM1FromGraphData.Size = new System.Drawing.Size(101, 17);
            this.radioM1FromGraphData.TabIndex = 5;
            this.radioM1FromGraphData.TabStop = true;
            this.radioM1FromGraphData.Text = "Data from graph";
            this.radioM1FromGraphData.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(25, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 75);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number Of Packets near the Avarage /  Total Number Of Packets:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 49);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number Of Packets near the Avarage:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Avarage Delay:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Number Of Packets:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radioM2FromCapturedData);
            this.tabPage3.Controls.Add(this.radioM2FromGraphData);
            this.tabPage3.Controls.Add(this.txtRegularity);
            this.tabPage3.Controls.Add(this.txtWindowsCount);
            this.tabPage3.Controls.Add(this.txtWindowSize);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(737, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paterns in the Varience";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioM2FromCapturedData
            // 
            this.radioM2FromCapturedData.AutoSize = true;
            this.radioM2FromCapturedData.Location = new System.Drawing.Point(156, 50);
            this.radioM2FromCapturedData.Name = "radioM2FromCapturedData";
            this.radioM2FromCapturedData.Size = new System.Drawing.Size(123, 17);
            this.radioM2FromCapturedData.TabIndex = 8;
            this.radioM2FromCapturedData.Text = "Total captured Data ";
            this.radioM2FromCapturedData.UseVisualStyleBackColor = true;
            // 
            // radioM2FromGraphData
            // 
            this.radioM2FromGraphData.AutoSize = true;
            this.radioM2FromGraphData.Checked = true;
            this.radioM2FromGraphData.Location = new System.Drawing.Point(37, 50);
            this.radioM2FromGraphData.Name = "radioM2FromGraphData";
            this.radioM2FromGraphData.Size = new System.Drawing.Size(101, 17);
            this.radioM2FromGraphData.TabIndex = 7;
            this.radioM2FromGraphData.TabStop = true;
            this.radioM2FromGraphData.Text = "Data from graph";
            this.radioM2FromGraphData.UseVisualStyleBackColor = true;
            // 
            // txtRegularity
            // 
            this.txtRegularity.Location = new System.Drawing.Point(137, 147);
            this.txtRegularity.Name = "txtRegularity";
            this.txtRegularity.ReadOnly = true;
            this.txtRegularity.Size = new System.Drawing.Size(120, 20);
            this.txtRegularity.TabIndex = 2;
            // 
            // txtWindowsCount
            // 
            this.txtWindowsCount.Location = new System.Drawing.Point(137, 95);
            this.txtWindowsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtWindowsCount.Name = "txtWindowsCount";
            this.txtWindowsCount.Size = new System.Drawing.Size(120, 20);
            this.txtWindowsCount.TabIndex = 1;
            this.txtWindowsCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtWindowSize
            // 
            this.txtWindowSize.Location = new System.Drawing.Point(137, 121);
            this.txtWindowSize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtWindowSize.Name = "txtWindowSize";
            this.txtWindowSize.ReadOnly = true;
            this.txtWindowSize.Size = new System.Drawing.Size(120, 20);
            this.txtWindowSize.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Window Size :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Windows Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Regularity :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitESimilarity);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(722, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "e-similarity";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitESimilarity
            // 
            this.splitESimilarity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitESimilarity.Location = new System.Drawing.Point(3, 3);
            this.splitESimilarity.Name = "splitESimilarity";
            // 
            // splitESimilarity.Panel1
            // 
            this.splitESimilarity.Panel1.Controls.Add(this.splitEsimilarithGraphs);
            // 
            // splitESimilarity.Panel2
            // 
            this.splitESimilarity.Panel2.Controls.Add(this.label1);
            this.splitESimilarity.Panel2.Controls.Add(this.numericUpDown2);
            this.splitESimilarity.Panel2.Controls.Add(this.numericUpDown1);
            this.splitESimilarity.Panel2.Controls.Add(this.button1);
            this.splitESimilarity.Panel2.Controls.Add(this.radioButton1);
            this.splitESimilarity.Panel2.Controls.Add(this.radioButton2);
            this.splitESimilarity.Size = new System.Drawing.Size(716, 356);
            this.splitESimilarity.SplitterDistance = 446;
            this.splitESimilarity.TabIndex = 0;
            // 
            // splitEsimilarithGraphs
            // 
            this.splitEsimilarithGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEsimilarithGraphs.Location = new System.Drawing.Point(0, 0);
            this.splitEsimilarithGraphs.Name = "splitEsimilarithGraphs";
            this.splitEsimilarithGraphs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitEsimilarithGraphs.Size = new System.Drawing.Size(446, 356);
            this.splitEsimilarithGraphs.SplitterDistance = 174;
            this.splitEsimilarithGraphs.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(131, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "Total captured Data ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Data from graph";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create Graphs And Calculate e-Similarity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(15, 136);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(239, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "e-Similarirty :";
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 407);
            this.Controls.Add(this.pnl);
            this.Name = "frmSession";
            this.Text = "frmsession";
            this.Load += new System.EventHandler(this.frmSession_Load);
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtWindowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWindowSize)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitESimilarity.Panel1.ResumeLayout(false);
            this.splitESimilarity.Panel2.ResumeLayout(false);
            this.splitESimilarity.Panel2.PerformLayout();
            this.splitESimilarity.ResumeLayout(false);
            this.splitEsimilarithGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDivition_NP_NAP;
        private System.Windows.Forms.TextBox txtNumOfPacketsNearAvarage;
        private System.Windows.Forms.TextBox txtAvarageDelay;
        private System.Windows.Forms.TextBox txtNomOfPackets;
        private System.Windows.Forms.RadioButton radioM1FromCapturedData;
        private System.Windows.Forms.RadioButton radioM1FromGraphData;
        private System.Windows.Forms.Label lblCCDM1Out;
        private System.Windows.Forms.NumericUpDown txtWindowsCount;
        private System.Windows.Forms.NumericUpDown txtWindowSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioM2FromCapturedData;
        private System.Windows.Forms.RadioButton radioM2FromGraphData;
        private System.Windows.Forms.TextBox txtRegularity;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitESimilarity;
        private System.Windows.Forms.SplitContainer splitEsimilarithGraphs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}