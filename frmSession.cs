using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChartDirector;
using System.Collections;

namespace CCDetector
{
    public partial class frmSession : Form
    {
        
        public CCDetector.CDetector detector;

        public ChartControl chartLayers;


        public frmSession()
        {
            InitializeComponent();

        }
        public ChartControl chartSortedData;
        public ChartControl chartESimilarity;
        private void init()
        {
            
            chartLayers = new ChartControl();
            tabPage1.Controls.Add(chartLayers);
            chartLayers.Interval = 1000;
            chartLayers.add("Session",new ChartDataLayer.UpdateFunction(mainTimetUpdate),true);
            chartLayers.Start();
            chartSortedData = new ChartControl();
            chartESimilarity = new ChartControl();
            chartSortedData.optionPanel = false;
            chartESimilarity.optionPanel = false;
            chartESimilarity.add("Relative Diference", true);
            chartSortedData.add("Sorted inter-arival times", true);
            splitEsimilarithGraphs.Panel1.Controls.Add(chartSortedData);
            splitEsimilarithGraphs.Panel2.Controls.Add(chartESimilarity);
        }

        void mainTimetUpdate(ChartDataLayer item)
        {
            CCDetector.CDetector.session ses = detector.getSession(sourceIp,sourcePort,destinationIp,destinationPort);
            int start = chartLayers.Items[0].Count;
            int stop = ses.Packets.Count;
            item.update(ses.getTimes(start,stop - start ));
            UpdateM1();
            UpdateM2();
        }



       

        private void UpdateM1()
        {
            double distanceSame =15;
            double errorSpace = 0.2;
            double[] calcData;
            if (radioM1FromGraphData.Checked == true)
            {
                calcData = chartLayers.Items[0].subDataGetTable();
            }
            else
            {
                CDetector.session ses = detector.getSession(sourceIp, sourcePort, destinationIp, destinationPort);
                calcData = ses.getLastNTimes(ses.Packets.Count);
            }
            if (calcData.Length == 0)
            {
                txtNomOfPackets.Text = "";
                txtAvarageDelay.Text = "";
                txtNumOfPacketsNearAvarage.Text = "";
                txtDivition_NP_NAP.Text = "";
                lblCCDM1Out.Text = "";
                return;
            }
            txtNomOfPackets.Text = calcData.Count().ToString();
            double Avarage = calcData.Average();
            txtAvarageDelay.Text = Avarage.ToString();
            int AvaragePacks = 0;

            foreach (double d in calcData)
            {
                if (Math.Abs(d - Avarage) <= distanceSame)
                {
                    AvaragePacks++;
                }
            }
            txtNumOfPacketsNearAvarage.Text = AvaragePacks.ToString();
            double nvp = AvaragePacks / (double)calcData.Count();
            txtDivition_NP_NAP.Text = nvp.ToString();
            if (Math.Abs(nvp - 0) <= errorSpace)
            {
                lblCCDM1Out.Text = "Covert Channel Detected";
            }
            else if (Math.Abs(nvp - 1) <= errorSpace)
            {
                lblCCDM1Out.Text = "Normal Trafic";
            }
            else
            {
                lblCCDM1Out.Text = "Random Trafic";
            }
        }
        private void UpdateM2()
        {
            double[] calcData;
            if (radioM1FromGraphData.Checked == true)
            {
                calcData = chartLayers.Items[0].subDataGetTable();
            }
            else
            {
                CDetector.session ses = detector.getSession(sourceIp, sourcePort, destinationIp, destinationPort);
                calcData = ses.getLastNTimes(ses.Packets.Count);
            }
            if (calcData.Length == 0)
            {
                txtRegularity.Text = "";

            }

            int blockSize = (int)Math.Ceiling((double)calcData.Count() / (double)txtWindowsCount.Value);
            txtWindowSize.Value = blockSize;
            double[] S = new double[(int)txtWindowsCount.Value];
            for (int i = 0; i < S.Count(); i++)
            {
                double[] tmp = Util.subTable(calcData, i * blockSize, (i + 1) * blockSize);
                
                double Si = new ArrayMath(tmp).stdDev();
                S[i] = Si;
            }
            double[] X = new double[S.Count() * S.Count() - S.Count()];
            int cnt = 0;
            for (int i = 0; i < S.Count(); i++)
            {
                for (int j = 0; j < S.Count(); j++)
                {
                    if (i != j)
                    {

                        double tmp = Math.Abs(S[i] - S[j]);// / S[i];
                        if (double.IsNaN(tmp))
                        {
                              tmp = double.MaxValue;
                        }
                        X[cnt++] = tmp;
                    }
                }
            }
            txtRegularity.Text = new ArrayMath(X).stdDev().ToString();

        }




        public String sourceIp;
        public String sourcePort;
        public String destinationIp;
        public String destinationPort;
        private void frmSession_Load(object sender, EventArgs e)
        {
            groupBox1.Text = sourceIp + ":" + sourcePort + "-->" + destinationIp + ":" + destinationPort;
            init();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Clear Property
            //chartSortedData.Clear();
            double []currData = chartLayers.Items[0].subDataGetTable();
            Array.Sort(currData);
            double past=-1;
            double eSim=0;
            int cnt = 0;
            int len = 0;
            foreach (double curr in currData)
            {
                chartSortedData.Items[0].update(curr);
                if (past > 0)
                {
                    double calc = (past - curr) / past;
                    chartESimilarity.Items[0].update(calc);
                    if (calc < eSim)
                    {
                        cnt++;
                    }
                    len++;
                }
                past = curr;
            }
            //TODO: textbox fill (cnt/len*100)

            
        }
       

        
    }
}
