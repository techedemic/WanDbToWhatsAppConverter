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
using System.Xml.Serialization;
using System.IO;

namespace WanDbToWhatsAppConverter
{
    public partial class frmMain : Form
    {
        bool shDown, shUp, shUtil, shDelay, shAhOnly, shAlarmNo, shAlarmNote, shAlarmMessage, shAck, shMaint, shPriority; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                getParams();
                txtOutput.Clear(); 
                XmlSerializer serializer = new XmlSerializer(typeof(root));
                StringReader reader = new StringReader(txtXML.Text.Trim());
                root resultMsg = (root)serializer.Deserialize(reader);
                foreach (var location in resultMsg.locations)
                {
                    //txtOutput.Text += location.description + minutesToLong(location.Delay[0].duration[0].ToString()) + "\n";
                    
                    if ((location.Down != null) && (shDown == true))
                    {
                        txtOutput.Text += "\n" + location.description;
                        foreach (var entrDown in location.Down)
                        {
                            txtOutput.Text += " - DOWN[AH] - " + minutesToLong(entrDown.duration.ToString());
                            if (shAhOnly == false) { txtOutput.Text += " - DOWN[OH] - " + minutesToLong(entrDown.ohDuration.ToString()); }
                            if (shPriority == true) { txtOutput.Text += " - PRIORITY[" + location.priority + "]"; }
                            if (shAlarmNo == true) { txtOutput.Text += " - # -" + entrDown.alarmId.ToString(); }
                            if (shAlarmMessage == true) { txtOutput.Text += " - [" + entrDown.alarm.ToString() + "]" ; }
                            if (shAlarmNote == true) { txtOutput.Text += " - NOTE: " + entrDown.note.ToString(); }
                            if (shAck == true) { txtOutput.Text += " - ACK[" + entrDown.isAcknowledge.ToString() + "]"; }
                            if (shMaint == true) { txtOutput.Text += " - MAINT[" + entrDown.isMaintenance.ToString() + "]"; }
                        }
                    }
                    if ((location.Delay != null) && (shDelay == true))
                    {
                        txtOutput.Text += "\n" + location.description;
                        foreach (var entrDelay in location.Delay)
                        {
                            txtOutput.Text += " - DELAY[AH] - " + minutesToLong(entrDelay.duration.ToString());
                            if (shAhOnly == false)
                            {
                                txtOutput.Text += "- DELAY[OH] - " + minutesToLong(entrDelay.ohDuration.ToString());
                            }
                            if (shPriority == true) { txtOutput.Text += " - PRIORITY[" + location.priority + "]"; }
                            if (shAlarmNo == true) { txtOutput.Text += " - # -" + entrDelay.alarmId.ToString(); }
                            if (shAlarmMessage == true) { txtOutput.Text += " - [" + entrDelay.alarm.ToString() + "]" ; }
                            if (shAlarmNote == true) { txtOutput.Text += " - NOTE: " + entrDelay.note.ToString(); }
                            if (shAck == true) { txtOutput.Text += " - ACK[" + entrDelay.isAcknowledge.ToString() + "]"; }
                            if (shMaint == true) { txtOutput.Text += " - MAINT[" + entrDelay.isMaintenance.ToString() + "]"; }
                        }
                    }
                    if ((location.Up != null) && (shUp == true))
                    {
                        txtOutput.Text += "\n" + location.description;
                        foreach (var entrUp in location.Up)
                        {
                            txtOutput.Text += "UP[AH] - " + minutesToLong(entrUp.duration.ToString());
                            if (shAhOnly == false)
                            {
                                txtOutput.Text += "UP[OH] - " + minutesToLong(entrUp.ohDuration.ToString());
                            }
                            if (shPriority == true) { txtOutput.Text += " - PRIORITY[" + location.priority + "]"; }
                            if (shAlarmNo == true) { txtOutput.Text += " - # -" + entrUp.alarmId.ToString(); }
                            if (shAlarmMessage == true) { txtOutput.Text += " - [" + entrUp.alarm.ToString() + "]" ; }
                            if (shAlarmNote == true) { txtOutput.Text += " - NOTE: " + entrUp.note.ToString(); }
                            if (shAck == true) { txtOutput.Text += " - ACK[" + entrUp.isAcknowledge.ToString() + "]"; }
                            if (shMaint == true) { txtOutput.Text += " - MAINT[" + entrUp.isMaintenance.ToString() + "]"; }
                        }
                    }
                    if ((location.Util != null) && (shUtil == true))
                    {
                        txtOutput.Text += "\n" + location.description;
                        foreach (var entrUtil in location.Util)
                        {
                            txtOutput.Text += "THRESHOLD[AH] - " + minutesToLong(entrUtil.duration.ToString());
                            if (shAhOnly == false)
                            {
                                txtOutput.Text += "THRESHOLD[OH] - " + minutesToLong(entrUtil.ohDuration.ToString());
                            }
                            if (shPriority == true) { txtOutput.Text += " - PRIORITY[ " + location.priority + "]"; }
                            if (shAlarmNo == true) { txtOutput.Text += " - # -" + entrUtil.alarmId.ToString(); }
                            if (shAlarmMessage == true) { txtOutput.Text += " - [" + entrUtil.alarm.ToString() + "]" ; }
                            if (shAlarmNote == true) { txtOutput.Text += " - NOTE: " + entrUtil.note.ToString(); }
                            if (shAck == true) { txtOutput.Text += " - ACK[" + entrUtil.isAcknowledge.ToString() + "]"; }
                            if (shMaint == true) { txtOutput.Text += " - MAINT[" + entrUtil.isMaintenance.ToString() + "]"; }
                        }
                    }               
                }
            }
            catch (Exception exc) {
                MessageBox.Show("Error : " + exc.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private string minutesToLong(string minutes)
        {
            int intMinutes = int.Parse(minutes);

            TimeSpan t = new TimeSpan(0, 0,intMinutes);
            


            string strFormat = string.Format("{0}Days, {1} Hours, {2} Minutes", t.Days.ToString(), t.Hours.ToString(), t.Minutes.ToString());
            //MessageBox.Show("Minutes : " + minutes + " Format: " + strFormat);
            return strFormat;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {            
            txtOutput.Clear();            
        }

        private void btnClearXml_Click(object sender, EventArgs e)
        {
            txtXML.Clear();   
        }

        private void getParams() 
        {
            shDown = (chkDown.Checked) ? true : false;
            shDelay = (chkDelay.Checked) ? true : false;
            shUp = (chkUp.Checked) ? true : false;
            shUtil = (chkUtil.Checked) ? true : false;
            shAlarmNo = (chkAlarmNo.Checked) ? true : false;
            shAlarmMessage = (chkAlarmMsg.Checked) ? true : false;
            shAlarmNote = (chkNote.Checked) ? true : false;
            shAck = (chkAck.Checked) ? true : false;
            shMaint = (chkMaint.Checked) ? true : false;
            shAhOnly = (radAhOnly.Checked) ? true : false;
            shPriority = (chkPriority.Checked) ? true : false;
        }
    }
}
