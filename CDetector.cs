using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Tamir.IPLib;
using Tamir.IPLib.Packets;
namespace CCDetector
{
    
    public class CDetector 
    {
        public class session
        {
            public String SourceAddress;
            public int SourcePort;
            public String DestinationAddress;
            public int DestinationPort;
            public ArrayList Packets;
            public double[] getTimes(int start, int size)
            {
                double[] res;
                TimeSpan dif;
                res = new double[size];
                int i = 0;
                DateTime lastTime = new DateTime();
                for (i = start; i < start + size; i++)
                {
                    TCPPacket p = (TCPPacket)Packets[i];
                    DateTime time = p.Timeval.Date;
                    if (i == 0)
                    {
                        dif = time.Subtract(time);

                    }
                    else if (i == start)
                    {
                        lastTime = ((TCPPacket)Packets[i - 1]).Timeval.Date;
                        dif = time.Subtract(lastTime);
                    }
                    else
                    {

                        dif = time.Subtract(lastTime);
                    }
                    lastTime = time;
                    res[i - start] = dif.TotalMilliseconds;
                }
                return res;

            }
            public double[] getLastNTimes(int n)
            {
                int start = Packets.Count -1 - n;
                int end = n;
                if(start<0)
                {
                    start=0;
                }
                if(end> Packets.Count -1)
                {
                    end = Packets.Count -1;
                }


                return getTimes(start,end);
               
            }
        };
        private PcapDeviceList _devices;
        private Hashtable _sessions;
        public String[,]sesions
        {
            get
            {
                String[,] res;
                int i=0;
                res =  new String [_sessions.Count,5];
                try
                {
                    foreach (session s in _sessions.Values)
                    {
                        res[i, 0] = s.SourceAddress;
                        res[i, 1] = s.SourcePort.ToString();
                        res[i, 2] = s.DestinationAddress;
                        res[i, 3] = s.DestinationPort.ToString();
                        res[i, 4] = s.Packets.Count.ToString();
                        i++;
                    }
                }
                catch
                {
                    return new String[0, 0];
                }
                return res;
            }
        }
        public String []devices
        {
            get
            {
                int i =0;
                String []res = new String [_devices.Count];
                foreach (PcapDevice dv in _devices)
                {
                    res[i++] = (dv.PcapDescription);
                }
                return res;
            }
        }
        public CDetector()
        {
            _devices = SharpPcap.GetAllDevices();
            _sessions = new Hashtable();
        }
        public bool captureStart(String device)
        {
            foreach (PcapDevice dv in _devices)
            {
                if (dv.PcapDescription == device)
                {
                    dv.PcapOpen();
                    dv.PcapOnPacketArrival += new SharpPcap.PacketArrivalEvent(onPacketArrival);
                    dv.PcapStartCapture();
                    return true;
                }
            
            }
            return false;
        }

        private void onPacketArrival(object sender, Packet packet)
        {
            if(packet is TCPPacket)
            {
                TCPPacket p = (TCPPacket)packet;
                session tmp;
                String name;
                name = p.SourceAddress + ":" + p.SourcePort + "-" + p.DestinationAddress + ":" + p.DestinationPort;
                tmp = (session)_sessions[name];
                try
                {
                    tmp.Packets.Add(p);
                }
                catch
                {
                    tmp = new session();
                    tmp.Packets = new ArrayList();
                    tmp.Packets.Add(p);
                    tmp.SourceAddress = p.SourceAddress;
                    tmp.SourcePort = p.SourcePort;
                    tmp.DestinationAddress = p.DestinationAddress;
                    tmp.DestinationPort = p.DestinationPort;
                    _sessions[name]= tmp;
                }
            }
        }
        public bool captureStop(String device)
        {
            foreach (PcapDevice dv in _devices)
            {
                if (dv.PcapDescription == device)
                {
                    dv.PcapStopCapture();
                    return true;
                }
            }
            return false;
        }
        public session getSession(String sip, String sport, String dip, String dport)
        {
            String key;
            key = sip + ":" + sport + "-" + dip + ":" + dport;
            return (session)_sessions[key];
        }

    }
}
