﻿/*************************************************************************
* 
*  LEIDOS CONFIDENTIAL
*  __________________
* 
*  Form1.cs
*  [2017] Leidos Inc.
*  All Rights Reserved.
* 
*  NOTICE:  All information contained herein is, and remains
*  the property of Leidos Inc. and its suppliers,  if any.  
*  The intellectual and technical concepts contained  herein are
*  proprietary to of Leidos Inc.  and its suppliers and may be covered by 
*  U.S. and Foreign Patents,  patents in process, and are protected by
*  trade secret or copyright law.  Dissemination of this information
*  or reproduction of this material  is strictly forbidden unless prior
*  written permission is obtained from Leidos Inc.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Utility.ModifyRegistry;

namespace threat_test
{
    public partial class Form1 : Form
    {
        ModifyRegistry ModReg = new ModifyRegistry();
        IAsyncResult iAsyncResult;
        UdpClient udpClientRcv;
        UdpState udpState;
        string PathName;
        Boolean bClosing = false;
        int ThreatUID = 0;
        int imageCnt = 0;
        int threatCnt = 0;
        string receiveString;
        Boolean bPlay = false;
        Boolean bPausePlaying = false;
        Boolean bListening = false;
        Boolean bParseErr = false;
        IEnumerable<String> FileNames;

        public Form1()
        {
            InitializeComponent();
            pbRunning.Visible = false;
            btnClose.Enabled = false;
            ModReg.ShowError = true;
            GetSettings();
            string version = GetVersion();
            int isp = version.IndexOf(" ");
            string pName = version.Substring(isp + 1);
            Text += " " + pName;
#if DEBUG
            Text += " Debug";
#endif
            rbRaw.Checked = true;
            btnStop.Enabled = false;
            Listen();
        }

        public string GetVersion()
        {
            // Get the version of the executing assembly (that is, this assembly).
            Assembly assem = Assembly.GetEntryAssembly();
            AssemblyName assemName = assem.GetName();
            Version ver = assemName.Version;
            return assemName.Name.ToString() + " Ver. " + ver.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            rbRaw.Checked = true;
            ThreatUID++;
            rtxtThreatCmd.Text = CreateThreat();
            rtxtThreatReply.Clear();
            Send_Click();
        }

        private void Send_Click()
        { 
            IPAddress ip;
            short ttl;
            int port;

            if (!IPAddress.TryParse(txtAddress.Text, out ip))
            {
                MessageBox.Show("Invalid ip address", "WARNING");
                GetSettings();
                return;
            }

            if (!int.TryParse(txtPortSend.Text, out port))
            {
                MessageBox.Show("Invalid send port", "WARNING");
                GetSettings();
                return;
            }

            if (!short.TryParse(txtTTL.Text, out ttl))
            {
                MessageBox.Show("Invalid TTL", "WARNING");
                GetSettings();
                return;
            }
            SaveSettings();

            Send(ip, port, ttl);
          }

        private void SaveSettings()
        {
            ModReg.Write("Address", txtAddress.Text);
            ModReg.Write("Adapter", txtAdapter.Text);
            ModReg.Write("PortSend", txtPortSend.Text);
            ModReg.Write("PortListen", txtPortListen.Text);
            ModReg.Write("PathName", PathName);
            ModReg.Write("Multicast", chkMulticast.Checked ? "Y" : "N");
            ModReg.Write("MulticastAddress", txtMulticast.Text);
            ModReg.Write("TTL", txtTTL.Text);
        }

        private void GetSettings()
        {
            txtAddress.Text = ModReg.Read("Address","224.0.0.3");
            txtAdapter.Text = ModReg.Read("Adapter", "192.168.1.1");
            txtPortSend.Text = ModReg.Read("PortSend","8001");
            txtPortListen.Text = ModReg.Read("PortListen","8002");
            txtMulticast.Text = ModReg.Read("MulticastAddress", "224.0.0.3");
            txtTTL.Text = ModReg.Read("TTL", "5");
            if (ModReg.Read("MultiCast", "Y") == "Y")
                chkMulticast.Checked = true;
            else
                chkMulticast.Checked = false;
            PathName = ModReg.Read("PathName","");

            txrPathName.Text = PathName;
            if (File.Exists(PathName))
            {
                rtxtThreatCmd.Text = CreateThreat();
                PopulateTxt();
            }
        }

        private String CreateThreat()
        {
            String xmlThreat = "";
            using (var stringWriter = new StringWriter())
            {
                int thread = 1;
                int redFact = 1;
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.NewLineOnAttributes = true;
                using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("threat_detect");

                    xmlWriter.WriteStartElement("thread");
                    xmlWriter.WriteString((thread).ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("datetime");
                    xmlWriter.WriteString(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("imagefn");
                    xmlWriter.WriteString(PathName);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("reductfact");
                    xmlWriter.WriteString(redFact.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("uid");
                    xmlWriter.WriteString(ThreatUID.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                }
                xmlThreat = stringWriter.ToString();
            }
            return xmlThreat;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            receiveString = "";
            rtxtThreatCmd.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (File.Exists(PathName))
                openFileDialog.InitialDirectory = Path.GetDirectoryName(PathName);
            else
                openFileDialog.InitialDirectory  = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "TIF Files (*.tif)|*.tif|All Files (*.*)|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PathName = openFileDialog.FileName;
                    txrPathName.Text = PathName;
                    rtxtThreatCmd.Text = CreateThreat();
                    PopulateTxt();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEPTION");
            }

        }

        private Boolean IsMulticastAddress(IPAddress ip)
        {
            //determine if ip is multicast
            if (ip == null)
                return false;
            string ips = ip.ToString();
            if (ips.Length < 3)
                return false;
            int msb = 0;
            if (!int.TryParse(ips.Substring(0,3), out msb))
                return false;
            if (msb < 224 || msb > 239)
                return false;
            return true;
        }

        private Boolean Send(IPAddress ip, int port, short ttl)
        {
            try
            {
                UdpClient udpClientSend = new UdpClient();

                if (txtAdapter.Text.Length > 0)
                {

                    //Find the adpater index
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    if (nics == null || nics.Length < 1)
                    {
                        MessageBox.Show("No network interface found", "ERROR");
                        return false;
                    }

                    //find the index of the specified NIC
                    int idx = -1;
                    foreach (NetworkInterface ni in nics)
                    {
                        if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                        {
                            foreach (UnicastIPAddressInformation uip in ni.GetIPProperties().UnicastAddresses)
                            {
                                if (uip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                                {
                                    string address = uip.Address.ToString();
                                    if (address == txtAdapter.Text)
                                    {
                                        IPv4InterfaceProperties p = ni.GetIPProperties().GetIPv4Properties();
                                        idx = p.Index;
                                    }
                                }
                            }
                        }
                    }
                    if (idx == -1)
                    {
                        MessageBox.Show("Requested network interface not found", "ERROR");
                        return false;
                    }
                    udpClientSend.Client.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastInterface, (int)IPAddress.HostToNetworkOrder(idx));
                }

                byte[] b = Encoding.ASCII.GetBytes(rtxtThreatCmd.Text);
                if (IsMulticastAddress(ip))
                {
                    udpClientSend.Ttl = ttl;
                    udpClientSend.JoinMulticastGroup(ip);
                }
                IPEndPoint remoteep = new IPEndPoint(ip, port);
                udpClientSend.Send(b, b.Length, remoteep);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EXCEPTION");
                return false;
            }
        }

        private void EnableListenSettings(bool enabled)
        {
            chkMulticast.Enabled = enabled;
            txtMulticast.Enabled = enabled;
            txtPortListen.Enabled = enabled;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Listen();
        }

        private void Listen()
        { 
            IPAddress ip;
            int port;

            EnableListenSettings(false);

            if (!int.TryParse(txtPortListen.Text, out port))
            {
                MessageBox.Show("Invalid receive port", "WARNING");
                GetSettings();
                return;
            }

            if (!IPAddress.TryParse(txtMulticast.Text, out ip))
            {
                MessageBox.Show("Invalid ip address", "WARNING");
                GetSettings();
                return;
            }

            if (chkMulticast.Checked)
            {
                if (!IsMulticastAddress(ip))
                {
                    MessageBox.Show("Invalid multicast address", "WARNING");
                    GetSettings();
                    return;
                }
            }
            else
                ip = null;

            SaveSettings();
            if (CreateReceiver(ip, port))
            {
                bListening = true;
                btnListen.Enabled = false;
                btnClose.Enabled = true;
            }
            else
            {
                MessageBox.Show("Unable to listen", "ERROR");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bClosing = true;
            udpClientRcv.Close();
            btnListen.Enabled = true;
            btnClose.Enabled = false;
            bClosing = false;
            EnableListenSettings(true);
            bListening = false;
        }

        private bool CreateReceiver(IPAddress ip, int port)
        {
            try
            {
                udpClientRcv = new UdpClient();
                IPEndPoint localEp = new IPEndPoint(IPAddress.Any, port);

                if (IsMulticastAddress(ip))
                {
                    udpClientRcv.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    udpClientRcv.ExclusiveAddressUse = false;
                }
                udpClientRcv.Client.Bind(localEp);
                if (IsMulticastAddress(ip))
                {
                    IPAddress multicastaddress = ip;
                    udpClientRcv.JoinMulticastGroup(multicastaddress);
                }
                udpState = new UdpState(udpClientRcv, localEp);
                iAsyncResult = udpClientRcv.BeginReceive(new AsyncCallback(ReceiveCallback), udpState);
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error creating receiver: ", "ERROR");
                return false;
            }
        }

        public void ReceiveCallback(IAsyncResult ar)
        {
            if (!bClosing)
            {
                //Need to pause playint until all four displays are cycled
                bPausePlaying = true;
                UdpClient u = (UdpClient)((UdpState)(ar.AsyncState)).u;
                IPEndPoint e = (IPEndPoint)((UdpState)(ar.AsyncState)).e;

                Byte[] receiveBytes = u.EndReceive(ar, ref e);
                receiveString = Encoding.ASCII.GetString(receiveBytes);

                this.Invoke(new MethodInvoker(delegate()
                {
                    txtThreatCnt.Text = (++threatCnt).ToString();
                    rtxtThreatReply.Clear();
                    if (receiveString.Length > 0)
                    {
                        if (rbRaw.Checked)
                            rtxtThreatReply.Text = receiveString;
                        else if (rbParsed.Checked)
                        {
                            Threat threat = ThreatParse(receiveString);
                            if (threat.errmess.Length > 0)
                            {
                                rtxtThreatReply.Text = "ERROR parsing XML: " + threat.errmess;
                                bParseErr = true;
                            }

                            else
                                DisplayThreat(threat);
                        }
                    }

                    if (!bParseErr && bPlay)
                    {
                        //walk through the four display
                        rbRaw.Checked = true;
                        sleep(500);
                        rbParsed.Checked = true;
                        sleep(500);
                        rbGJRaw.Checked = true;
                        sleep(500);
                        rbGJParsed.Checked = true;
                        sleep(500);
                        rtxtThreatReply.Clear();
                    }
                    bPausePlaying = false;
                }));

                udpClientRcv.BeginReceive(new AsyncCallback(ReceiveCallback), udpState);
            }
        }

        private void chkMulticast_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMulticast.Checked)
                txtMulticast.Enabled = true;
            else
                txtMulticast.Enabled = false;
        }

        private Threat ThreatParse(string strXml)
        {
            Threat threat = new Threat();
            if (String.IsNullOrEmpty(strXml))
                return null;
            try
            {
                XDocument xmlDoc = XDocument.Parse(strXml);
                var message = from item in xmlDoc.Descendants("threat_detected")
                              select new
                              {
                                  application = item.Element("application").Value,
                                  level = item.Element("level").Value,
                                  thread = item.Element("thread").Value,
                                  dtrecv = item.Element("dtrecv").Value,
                                  dtsend = item.Element("dtsend").Value,
                                  threatfn = item.Element("threatfn").Value,
                                  uid = item.Element("uid").Value,
                              };
    
                foreach (var p in message)
                {
                    threat.application = p.application;
                    threat.level = Int32.Parse(p.level);
                    threat.thread = Int32.Parse(p.thread);
                    threat.dtrecv = p.dtrecv;
                    threat.dtsend = p.dtsend;
                    threat.threatfn = p.threatfn;
                    threat.uid = Int32.Parse(p.uid);
                }
                return threat;
            }
            catch (Exception ex)
            {
                threat.errmess = ex.Message;
                return null;
            }
        }

        void DisplayThreat(Threat threat)
        {
            if (threat == null)
                return;
            rtxtThreatReply.AppendText("Application: " + threat.application);
            rtxtThreatReply.AppendText("\nLevel: " + threat.level);
            rtxtThreatReply.AppendText("\nThread: " + threat.thread);
            rtxtThreatReply.AppendText("\nRecv: " + threat.dtrecv);
            rtxtThreatReply.AppendText("\nSend: " + threat.dtrecv);
            rtxtThreatReply.AppendText("\nFile Name: " + threat.threatfn);
            rtxtThreatReply.AppendText("\nUID: " + threat.uid);
        }

        private void rbRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbRaw.Checked)
                return;
            rtxtThreatReply.Text = receiveString;
        }

        private void rbParsed_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbParsed.Checked)
                return;
            rtxtThreatReply.Clear();
            if (receiveString == null)
                return;
            Threat threat = ThreatParse(receiveString);
            if (threat == null)
                return;
      
            if (threat.errmess.Length > 0)
                rtxtThreatReply.Text = "ERROR parsing XML: " + threat.errmess;
            else
                DisplayThreat(threat);
        }

        private void rbGJRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbGJRaw.Checked)
                return;
            rtxtThreatReply.Clear();
            if (receiveString == null)
                return;
            Threat threat = ThreatParse(receiveString);
            if (threat == null)
                return;

            if (threat.errmess.Length > 0)
            {
                rtxtThreatReply.Text = "ERROR parsing XML: " + threat.errmess;
                return;
            }
            else
            {
                if (!File.Exists(threat.threatfn))
                {
                    rtxtThreatReply.Text = "ERROR - unable to open geoJSON file: " + threat.threatfn;
                    return;
                }
                else
                {
                    try
                    {
                        rtxtThreatReply.Text = File.ReadAllText(threat.threatfn);
                    }
                    catch (Exception ex)
                    {
                        rtxtThreatReply.Text = "ERROR reading geoJSON file: " + ex.Message;
                    }
                }
            }
        }

        private void rbGJParsed_CheckedChanged(object sender, EventArgs e)
        {
            String geoJSON;
            if (!rbGJParsed.Checked)
                return;
            rtxtThreatReply.Clear();
            if (receiveString == null)
                return;
            Threat threat = ThreatParse(receiveString);
            if (threat == null)
                return;

            if (threat.errmess.Length > 0)
            {
                rtxtThreatReply.Text = "ERROR parsing XML: " + threat.errmess;
                return;
            }
            else
            {
                try
                {
                    geoJSON = File.ReadAllText(threat.threatfn);
                }
                catch (Exception ex)
                {
                    rtxtThreatReply.Text = "ERROR reading geoJSON file: " + ex.Message;
                    return;
                }
                int recsFound = CountGeoJson(geoJSON);
                if (recsFound < 0)
                    rtxtThreatReply.Text = "Error parsing geoJSON";
                else if (recsFound == 0)
                    rtxtThreatReply.Text = "No polygons found in geoJSON";
                else
                {
                    rtxtThreatReply.Text = "Number of polygons in geoJSON file = " + recsFound;
                    ParseGeoJson(geoJSON, recsFound);
                }
            }
        }

        int CountGeoJson(String geojson)
        {

            //determine how many polygons are in the geojson
            int count = 0;
            try
            {
                count = Regex.Matches(geojson, "geometry").Count;
            }
            catch
            {
                count = -1;
            }
            return count;
        }

        void ParseGeoJson(String geojson, int count)
        {
            String json = geojson.Replace(" ", "");
            json = json.Replace("\n", "");
            int feat = 0;
            int coord_start = 0;

            for (int i = 0; i < count; i++)
            {
                rtxtThreatReply.AppendText("\nPolygon " + (i + 1));
                try
                {
                    coord_start = json.IndexOf("\"coordinates\":", feat);
                    int coord_end = json.IndexOf("]]]", coord_start) + 2;
                    String geometry = json.Substring(coord_start, coord_end - coord_start + 1);
                    int prop_start = json.IndexOf("\"properties\":{", feat);
                    int prop_end = json.IndexOf("}", prop_start);
                    String properties = json.Substring(prop_start, prop_end - prop_start + 1);
                    String class_id = PropParse(properties, "class_id");
                    String class_name = PropParse(properties, "class_name");
                    String score = PropParse(properties, "score");
                    feat = json.IndexOf("},{", feat + 3);
                    rtxtThreatReply.AppendText("\n\tclass_id: " + class_id);
                    rtxtThreatReply.AppendText("\n\tclass_name: " + class_name);
                    rtxtThreatReply.AppendText("\n\tscore: " + score);
                    rtxtThreatReply.AppendText("\n\tproperties: " + properties);
                    rtxtThreatReply.AppendText("\n\tgeometry: " + geometry);
                }
                catch (Exception ex)
                {
                    rtxtThreatReply.AppendText("\nERROR parsing polygon " + (i + 1) + ": " + ex.Message);
                }
            }
        }

        String PropParse(String json, String tag)
        {
            int pos_tag = json.IndexOf(tag);
            if (pos_tag < 0)
                return null;
            int pos_val_start = json.IndexOf(":", pos_tag + tag.Length) + 1;
            if (pos_val_start < 0)
                return null;
            int pos_val_end = json.IndexOf(",", pos_val_start) - 1;
            if (pos_val_end < 0)
                pos_val_end = json.IndexOf("}", pos_val_start) - 1;
            if (pos_val_end < 0)
                return null;
            String val = json.Substring(pos_val_start, pos_val_end - pos_val_start + 1);
            val = val.Replace("\"", "");
            return val;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            Next();
        }

        private void Next(String newDir = "" )
        {
            Boolean bEnd = false;
            receiveString = "";
            //Get a list of the filenames in the current directory
            String srcDir = "";
            if (newDir.Length > 0)
                srcDir = newDir;
            else
                srcDir = Path.GetDirectoryName(PathName);
            FileNames = Directory.EnumerateFiles(srcDir, "*.tif");

            //Find the current file (files are in alphabetical order)
            Boolean bPathNameFound = false;

            foreach (String pname in FileNames)
            {
                if (bParseErr)
                {
                    MessageBox.Show("Error parsing threat response - playing terminated", "ERROR");
                    EnableButtons(true);
                    pbRunning.Visible = false;
                    return;
                }

                else if (!bPathNameFound)
                {
                    //Find and then skip past the current file
                    if (pname == PathName || newDir.Length > 0)
                    {
                        bPathNameFound = true;
                        bEnd = true;
                    }
                }
                else
                {
                    bEnd = false;
                    PathName = pname;
                    PopulateTxt();
                    rtxtThreatCmd.Text = CreateThreat();
                    rtxtThreatReply.Clear();
                    txtImgCnt.Text = (++imageCnt).ToString();
                    Send_Click();

                    //We need to pause in case a threat detection is returned.
                    sleep(2000);

                    //If a threat was returned we need to sleep while it is displayed and parsed
                    while (bPausePlaying)
                        sleep(100);

                    if (!bPlay)
                    {
                        EnableButtons(true);
                        break;
                    }
                }                 
            }

            if (bPlay || bEnd)
            {
                //we are now at the end of the current directory
                String srcDirNext = GetNextDir(srcDir);
                if (srcDirNext.Length > 0)
                    Next(srcDirNext);
                else
                    MessageBox.Show("No more files to process", "INFO");

                btnStop_Click(null, EventArgs.Empty);
            }
        }

        String GetNextDir(String srcDir)
        {
            //Get just the directory name
            int pos = srcDir.LastIndexOf("\\");
            String dirName = srcDir.Substring(pos + 1);
            String dirRoot = srcDir.Substring(0, pos);
            //Need to increment the directoy name and see if it exists
            //Directory name format is YYYYMMDDHHmm
            DateTime srcDirDT = new DateTime();
            try
            {
                int year = int.Parse(dirName.Substring(0, 4));
                int month = int.Parse(dirName.Substring(4, 2));
                int day = int.Parse(dirName.Substring(6, 2));
                int hour = int.Parse(dirName.Substring(8, 2));
                int minute = int.Parse(dirName.Substring(10, 2));
                srcDirDT = new DateTime(year, month, day, hour, minute, 0);
            }
            catch
            {
                MessageBox.Show("Directory format is incorrect (YYYYMMDDHHmm): " + dirName, "ERROR");
                return "";
            }

            //Increment the directory by one minute
            srcDirDT = srcDirDT.AddMinutes(1);

            //Convert back to a string
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0:0000}", srcDirDT.Year));
            sb.Append(String.Format("{0:00}", srcDirDT.Month));
            sb.Append(String.Format("{0:00}", srcDirDT.Day));
            sb.Append(String.Format("{0:00}", srcDirDT.Hour));
            sb.Append(String.Format("{0:00}", srcDirDT.Minute));
            String srcDirNext = dirRoot + "\\" + sb.ToString();

            //Check to see if the next directory exists
            if (Directory.Exists(srcDirNext))
                return srcDirNext;
            else
                return "";
        }

        void sleep(int msecs)
        {
            for (int i = 0; i < msecs; i += 100)
            {
                Application.DoEvents();
                Thread.Sleep(100);
            }
        }

        private void PopulateTxt()
        {
            txtFileName.Text = Path.GetFileName(PathName);
            String fullDir = Path.GetDirectoryName(PathName);
            int lastSlash = fullDir.LastIndexOf("\\");
            txtDirectory.Text = fullDir.Substring(lastSlash + 1);
            int firstSlash = fullDir.LastIndexOf("\\", lastSlash - 1);
            txtSpectrum.Text = fullDir.Substring(firstSlash + 1, lastSlash - firstSlash - 1);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            bPlay = true;
            btnStop.Enabled = true;
            pbRunning.Visible = true;
            Next();
        } 

        private void EnableButtons(Boolean bEnabled)
        {

            btnClose.Enabled = bEnabled && bListening;
            btnExit.Enabled = bEnabled;
            btnListen.Enabled = bEnabled && !bListening;
            btnNext.Enabled = bEnabled;
            btnOpen.Enabled = bEnabled;
            btnPlay.Enabled = bEnabled;
            btnSend.Enabled = bEnabled;
            rbRaw.Enabled = bEnabled;
            rbParsed.Enabled = bEnabled;
            rbGJRaw.Enabled = bEnabled;
            rbGJParsed.Enabled = bEnabled;
            txtAdapter.Enabled = bEnabled;
            txtAddress.Enabled = bEnabled;
            txtPortSend.Enabled = bEnabled;
            txtTTL.Enabled = bEnabled;

            EnableListenSettings(bEnabled);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            bPlay = false;
            pbRunning.Visible = false;
            EnableButtons(true);
        }
    }
}
