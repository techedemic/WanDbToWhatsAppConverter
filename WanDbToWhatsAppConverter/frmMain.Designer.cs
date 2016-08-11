namespace WanDbToWhatsAppConverter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtXML = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkDown = new System.Windows.Forms.CheckBox();
            this.chkDelay = new System.Windows.Forms.CheckBox();
            this.chkUp = new System.Windows.Forms.CheckBox();
            this.chkUtil = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpValues = new System.Windows.Forms.GroupBox();
            this.chkPriority = new System.Windows.Forms.CheckBox();
            this.chkMaint = new System.Windows.Forms.CheckBox();
            this.chkNote = new System.Windows.Forms.CheckBox();
            this.chkAlarmNo = new System.Windows.Forms.CheckBox();
            this.chkAck = new System.Windows.Forms.CheckBox();
            this.chkAlarmMsg = new System.Windows.Forms.CheckBox();
            this.grpHours = new System.Windows.Forms.GroupBox();
            this.radOh = new System.Windows.Forms.RadioButton();
            this.radAhOnly = new System.Windows.Forms.RadioButton();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnClearXml = new System.Windows.Forms.Button();
            this.grpStyling = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpValues.SuspendLayout();
            this.grpHours.SuspendLayout();
            this.grpStyling.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXML
            // 
            this.txtXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXML.Location = new System.Drawing.Point(123, 12);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(747, 126);
            this.txtXML.TabIndex = 0;
            this.txtXML.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(778, 145);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 25);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(123, 239);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(747, 259);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "RAW XML";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Output";
            // 
            // chkDown
            // 
            this.chkDown.AutoSize = true;
            this.chkDown.Checked = true;
            this.chkDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDown.Location = new System.Drawing.Point(6, 19);
            this.chkDown.Name = "chkDown";
            this.chkDown.Size = new System.Drawing.Size(54, 17);
            this.chkDown.TabIndex = 20;
            this.chkDown.Text = "Down";
            this.chkDown.UseVisualStyleBackColor = true;
            // 
            // chkDelay
            // 
            this.chkDelay.AutoSize = true;
            this.chkDelay.Location = new System.Drawing.Point(6, 42);
            this.chkDelay.Name = "chkDelay";
            this.chkDelay.Size = new System.Drawing.Size(53, 17);
            this.chkDelay.TabIndex = 21;
            this.chkDelay.Text = "Delay";
            this.chkDelay.UseVisualStyleBackColor = true;
            // 
            // chkUp
            // 
            this.chkUp.AutoSize = true;
            this.chkUp.Location = new System.Drawing.Point(66, 19);
            this.chkUp.Name = "chkUp";
            this.chkUp.Size = new System.Drawing.Size(40, 17);
            this.chkUp.TabIndex = 22;
            this.chkUp.Text = "Up";
            this.chkUp.UseVisualStyleBackColor = true;
            // 
            // chkUtil
            // 
            this.chkUtil.AutoSize = true;
            this.chkUtil.Location = new System.Drawing.Point(66, 42);
            this.chkUtil.Name = "chkUtil";
            this.chkUtil.Size = new System.Drawing.Size(73, 17);
            this.chkUtil.TabIndex = 23;
            this.chkUtil.Text = "Threshold";
            this.chkUtil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUtil);
            this.groupBox1.Controls.Add(this.chkDown);
            this.groupBox1.Controls.Add(this.chkUp);
            this.groupBox1.Controls.Add(this.chkDelay);
            this.groupBox1.Location = new System.Drawing.Point(123, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 88);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns";
            // 
            // grpValues
            // 
            this.grpValues.Controls.Add(this.chkPriority);
            this.grpValues.Controls.Add(this.chkMaint);
            this.grpValues.Controls.Add(this.chkNote);
            this.grpValues.Controls.Add(this.chkAlarmNo);
            this.grpValues.Controls.Add(this.chkAck);
            this.grpValues.Controls.Add(this.chkAlarmMsg);
            this.grpValues.Location = new System.Drawing.Point(274, 145);
            this.grpValues.Name = "grpValues";
            this.grpValues.Size = new System.Drawing.Size(172, 88);
            this.grpValues.TabIndex = 25;
            this.grpValues.TabStop = false;
            this.grpValues.Text = "Values";
            // 
            // chkPriority
            // 
            this.chkPriority.AutoSize = true;
            this.chkPriority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chkPriority.Location = new System.Drawing.Point(74, 65);
            this.chkPriority.Name = "chkPriority";
            this.chkPriority.Size = new System.Drawing.Size(57, 17);
            this.chkPriority.TabIndex = 26;
            this.chkPriority.Text = "Priority";
            this.chkPriority.UseVisualStyleBackColor = true;
            // 
            // chkMaint
            // 
            this.chkMaint.AutoSize = true;
            this.chkMaint.Location = new System.Drawing.Point(74, 42);
            this.chkMaint.Name = "chkMaint";
            this.chkMaint.Size = new System.Drawing.Size(88, 17);
            this.chkMaint.TabIndex = 25;
            this.chkMaint.Text = "Maintenance";
            this.chkMaint.UseVisualStyleBackColor = true;
            // 
            // chkNote
            // 
            this.chkNote.AutoSize = true;
            this.chkNote.Location = new System.Drawing.Point(6, 65);
            this.chkNote.Name = "chkNote";
            this.chkNote.Size = new System.Drawing.Size(49, 17);
            this.chkNote.TabIndex = 24;
            this.chkNote.Text = "Note";
            this.chkNote.UseVisualStyleBackColor = true;
            // 
            // chkAlarmNo
            // 
            this.chkAlarmNo.AutoSize = true;
            this.chkAlarmNo.Location = new System.Drawing.Point(6, 19);
            this.chkAlarmNo.Name = "chkAlarmNo";
            this.chkAlarmNo.Size = new System.Drawing.Size(62, 17);
            this.chkAlarmNo.TabIndex = 20;
            this.chkAlarmNo.Text = "Alarm #";
            this.chkAlarmNo.UseVisualStyleBackColor = true;
            // 
            // chkAck
            // 
            this.chkAck.AutoSize = true;
            this.chkAck.Location = new System.Drawing.Point(74, 19);
            this.chkAck.Name = "chkAck";
            this.chkAck.Size = new System.Drawing.Size(91, 17);
            this.chkAck.TabIndex = 22;
            this.chkAck.Text = "Acknowleged";
            this.chkAck.UseVisualStyleBackColor = true;
            // 
            // chkAlarmMsg
            // 
            this.chkAlarmMsg.AutoSize = true;
            this.chkAlarmMsg.Location = new System.Drawing.Point(6, 42);
            this.chkAlarmMsg.Name = "chkAlarmMsg";
            this.chkAlarmMsg.Size = new System.Drawing.Size(69, 17);
            this.chkAlarmMsg.TabIndex = 21;
            this.chkAlarmMsg.Text = "Message";
            this.chkAlarmMsg.UseVisualStyleBackColor = true;
            // 
            // grpHours
            // 
            this.grpHours.Controls.Add(this.radOh);
            this.grpHours.Controls.Add(this.radAhOnly);
            this.grpHours.Location = new System.Drawing.Point(452, 145);
            this.grpHours.Name = "grpHours";
            this.grpHours.Size = new System.Drawing.Size(155, 88);
            this.grpHours.TabIndex = 26;
            this.grpHours.TabStop = false;
            this.grpHours.Text = "Duration";
            // 
            // radOh
            // 
            this.radOh.AutoSize = true;
            this.radOh.Location = new System.Drawing.Point(7, 43);
            this.radOh.Name = "radOh";
            this.radOh.Size = new System.Drawing.Size(138, 17);
            this.radOh.TabIndex = 1;
            this.radOh.Text = "All Hours + Office Hours";
            this.radOh.UseVisualStyleBackColor = true;
            // 
            // radAhOnly
            // 
            this.radAhOnly.AutoSize = true;
            this.radAhOnly.Checked = true;
            this.radAhOnly.Location = new System.Drawing.Point(7, 20);
            this.radAhOnly.Name = "radAhOnly";
            this.radAhOnly.Size = new System.Drawing.Size(91, 17);
            this.radAhOnly.TabIndex = 0;
            this.radAhOnly.TabStop = true;
            this.radAhOnly.Text = "All Hours Only";
            this.radAhOnly.UseVisualStyleBackColor = true;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(25, 425);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(92, 25);
            this.btnClearOutput.TabIndex = 27;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearXml
            // 
            this.btnClearXml.Location = new System.Drawing.Point(25, 113);
            this.btnClearXml.Name = "btnClearXml";
            this.btnClearXml.Size = new System.Drawing.Size(92, 25);
            this.btnClearXml.TabIndex = 28;
            this.btnClearXml.Text = "Clear XML";
            this.btnClearXml.UseVisualStyleBackColor = true;
            this.btnClearXml.Click += new System.EventHandler(this.btnClearXml_Click);
            // 
            // grpStyling
            // 
            this.grpStyling.Controls.Add(this.checkBox1);
            this.grpStyling.Location = new System.Drawing.Point(614, 145);
            this.grpStyling.Name = "grpStyling";
            this.grpStyling.Size = new System.Drawing.Size(158, 88);
            this.grpStyling.TabIndex = 29;
            this.grpStyling.TabStop = false;
            this.grpStyling.Text = "Styling";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bold P1 Sites";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 510);
            this.Controls.Add(this.grpStyling);
            this.Controls.Add(this.btnClearXml);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.grpHours);
            this.Controls.Add(this.grpValues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "WAN Dashboard - XML to WhatsApp Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpValues.ResumeLayout(false);
            this.grpValues.PerformLayout();
            this.grpHours.ResumeLayout(false);
            this.grpHours.PerformLayout();
            this.grpStyling.ResumeLayout(false);
            this.grpStyling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtXML;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDown;
        private System.Windows.Forms.CheckBox chkDelay;
        private System.Windows.Forms.CheckBox chkUp;
        private System.Windows.Forms.CheckBox chkUtil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpValues;
        private System.Windows.Forms.CheckBox chkMaint;
        private System.Windows.Forms.CheckBox chkNote;
        private System.Windows.Forms.CheckBox chkAlarmNo;
        private System.Windows.Forms.CheckBox chkAck;
        private System.Windows.Forms.CheckBox chkAlarmMsg;
        private System.Windows.Forms.GroupBox grpHours;
        private System.Windows.Forms.RadioButton radOh;
        private System.Windows.Forms.RadioButton radAhOnly;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnClearXml;
        private System.Windows.Forms.CheckBox chkPriority;
        private System.Windows.Forms.GroupBox grpStyling;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

