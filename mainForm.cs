using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CCDetector
{
    public partial class frmMain : Form
    {
        
        public CDetector detector;
        Timer sesionsUpdater;

        public frmMain()
        {
            InitializeComponent();
            lstSessions.addColumn("Analyze", CCSListView.ColumnFormat.String);
            lstSessions.addColumn("Source Ip", CCSListView.ColumnFormat.String);
            lstSessions.addColumn("Source Port", CCSListView.ColumnFormat.Number);
            lstSessions.addColumn("Destination Ip", CCSListView.ColumnFormat.String);
            lstSessions.addColumn("Destination Port", CCSListView.ColumnFormat.Number);
            lstSessions.addColumn("Packet Count", CCSListView.ColumnFormat.Number);
            lstSessions.Columns[0].Width = 50;
            lstSessions.Columns[1].Width = 100;
            lstSessions.Columns[2].Width = 100;
            lstSessions.Columns[3].Width = 100;
            lstSessions.Columns[4].Width = 100;
            lstSessions.Columns[5].Width = 100;
            lstSessions.MultiSelect = false;
            lstSessions.CheckBoxes = true;
            lstSessions.FullRowSelect = true;
            lstSessions.AllowColumnReorder = true;
            detector = new CDetector();
            sesionsUpdater = new Timer();
            sesionsUpdater.Interval = 100;

            //lstDevices.
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            foreach (String str in detector.devices)
            {
                lstDevices.Items.Add(str);
            }

            sesionsUpdater.Tick += new EventHandler(sesionsUpdate);
            sesionsUpdater.Start();

        }
        void sesionUpdate(String[] item)
        {
            
            for(int i=0;i<lstSessions.Items.Count;i++)
            {
               // MessageBox.Show(lstSessions.);

                if (lstSessions.Items[i].SubItems[1].Text == item[1] &&
                    lstSessions.Items[i].SubItems[2].Text == item[2] &&
                    lstSessions.Items[i].SubItems[3].Text == item[3] &&
                    lstSessions.Items[i].SubItems[4].Text == item[4] )
                {
                 
                    lstSessions.Items[i].SubItems[5].Text = item[5];

                    return;
                }
            }

            lstSessions.addSorted(new ListViewItem(item));
        }
        void sesionsUpdate(object sender, EventArgs e)
        {
            
            String [,] ses = detector.sesions;
            String [] item = new String[6]; 
            for (int i=0;i<ses.GetLength(0);i++)
            {
                item[0] = "";
                item[1] = ses[i,0];
                item[2] = ses[i,1];
                item[3] = ses[i,2];
                item[4] = ses[i,3];
                item[5] = ses[i,4];

                sesionUpdate(item);
                
            }

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (lstDevices.Enabled == true)
            {
                bool status = detector.captureStart((String)lstDevices.SelectedItem);
                if (status == true)
                {
                    lstDevices.Enabled = false;
                    btnCapture.Text = "Stop";
                }
                else
                {
                    internalError();
                }
            }
            else
            {
                bool status = detector.captureStop((String)lstDevices.SelectedItem);
                if (status == true)
                {
                    lstDevices.Enabled = true;
                    btnCapture.Text = "Capture";
                }
                else
                {
                    internalError();
                }
            }
        }

        private static void internalError()
        {
            MessageBox.Show("An internal error was occure, The program will restart");
            Application.Restart();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void lstSessions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                lstSessions.Items[e.Index].SubItems[0].Text = lstSessions.CheckedIndices.Count.ToString();
                TabPage tbp = new TabPage();
                frmSession frm = new frmSession();
                tbp.Controls.Add(frm.pnl);
                tbp.Text = "session " + lstSessions.CheckedIndices.Count.ToString();
                frm.sourceIp = lstSessions.Items[e.Index].SubItems[1].Text;
                frm.sourcePort = lstSessions.Items[e.Index].SubItems[2].Text;
                frm.destinationIp = lstSessions.Items[e.Index].SubItems[3].Text;
                frm.destinationPort = lstSessions.Items[e.Index].SubItems[4].Text;
                frm.detector = detector;
                frm.Show();
                frm.Hide();
                tabControl1.Controls.Add(tbp);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                String key = lstSessions.Items[e.Index].SubItems[0].Text;
                lstSessions.Items[e.Index].SubItems[0].Text = "";
                foreach (TabPage tbp in tabControl1.Controls)
                {
                    if (tbp.Text == "session " + key) 
                    {
                        tabControl1.Controls.Remove(tbp);
                        tbp.Dispose();
                        break;
                    }
                }
            }
        }
    }
}
