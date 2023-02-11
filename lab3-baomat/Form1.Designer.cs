
namespace lab3_baomat
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textDataSha1 = new System.Windows.Forms.TextBox();
            this.checkSha1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textDataSha2 = new System.Windows.Forms.TextBox();
            this.checkSha2 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textDataHMAC = new System.Windows.Forms.TextBox();
            this.checkHMAC = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pOpen = new System.Windows.Forms.Panel();
            this.btnopen = new System.Windows.Forms.Button();
            this.cbcheckbox = new System.Windows.Forms.ComboBox();
            this.textData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pOpen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textDataSha1);
            this.panel3.Controls.Add(this.checkSha1);
            this.panel3.Location = new System.Drawing.Point(12, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 49);
            this.panel3.TabIndex = 9;
            // 
            // textDataSha1
            // 
            this.textDataSha1.Location = new System.Drawing.Point(203, 3);
            this.textDataSha1.Name = "textDataSha1";
            this.textDataSha1.Size = new System.Drawing.Size(315, 22);
            this.textDataSha1.TabIndex = 5;
            // 
            // checkSha1
            // 
            this.checkSha1.AutoSize = true;
            this.checkSha1.Location = new System.Drawing.Point(25, 3);
            this.checkSha1.Name = "checkSha1";
            this.checkSha1.Size = new System.Drawing.Size(71, 21);
            this.checkSha1.TabIndex = 4;
            this.checkSha1.Text = "SHA-1";
            this.checkSha1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textDataSha2);
            this.panel4.Controls.Add(this.checkSha2);
            this.panel4.Location = new System.Drawing.Point(12, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 49);
            this.panel4.TabIndex = 10;
            // 
            // textDataSha2
            // 
            this.textDataSha2.Location = new System.Drawing.Point(203, 1);
            this.textDataSha2.Name = "textDataSha2";
            this.textDataSha2.Size = new System.Drawing.Size(315, 22);
            this.textDataSha2.TabIndex = 5;
            // 
            // checkSha2
            // 
            this.checkSha2.AutoSize = true;
            this.checkSha2.Location = new System.Drawing.Point(23, 3);
            this.checkSha2.Name = "checkSha2";
            this.checkSha2.Size = new System.Drawing.Size(71, 21);
            this.checkSha2.TabIndex = 4;
            this.checkSha2.Text = "SHA-2";
            this.checkSha2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textDataHMAC);
            this.panel2.Controls.Add(this.checkHMAC);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 49);
            this.panel2.TabIndex = 8;
            // 
            // textDataHMAC
            // 
            this.textDataHMAC.Location = new System.Drawing.Point(203, 3);
            this.textDataHMAC.Name = "textDataHMAC";
            this.textDataHMAC.Size = new System.Drawing.Size(315, 22);
            this.textDataHMAC.TabIndex = 5;
            // 
            // checkHMAC
            // 
            this.checkHMAC.AutoSize = true;
            this.checkHMAC.Location = new System.Drawing.Point(23, 3);
            this.checkHMAC.Name = "checkHMAC";
            this.checkHMAC.Size = new System.Drawing.Size(69, 21);
            this.checkHMAC.TabIndex = 4;
            this.checkHMAC.Text = "HMAC";
            this.checkHMAC.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pOpen);
            this.panel5.Controls.Add(this.cbcheckbox);
            this.panel5.Controls.Add(this.textData);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(541, 78);
            this.panel5.TabIndex = 7;
            // 
            // pOpen
            // 
            this.pOpen.Controls.Add(this.btnopen);
            this.pOpen.Location = new System.Drawing.Point(380, 19);
            this.pOpen.Name = "pOpen";
            this.pOpen.Size = new System.Drawing.Size(89, 38);
            this.pOpen.TabIndex = 10;
            this.pOpen.Paint += new System.Windows.Forms.PaintEventHandler(this.pOpen_Paint);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(0, 14);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(51, 24);
            this.btnopen.TabIndex = 9;
            this.btnopen.Text = "...";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Visible = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // cbcheckbox
            // 
            this.cbcheckbox.FormattingEnabled = true;
            this.cbcheckbox.Items.AddRange(new object[] {
            "Text String",
            "File text",
            "File nhị phân",
            "Hex String"});
            this.cbcheckbox.Location = new System.Drawing.Point(23, 33);
            this.cbcheckbox.Name = "cbcheckbox";
            this.cbcheckbox.Size = new System.Drawing.Size(103, 24);
            this.cbcheckbox.TabIndex = 8;
            this.cbcheckbox.SelectedIndexChanged += new System.EventHandler(this.cbcheckbox_SelectedIndexChanged);
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(203, 33);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(162, 22);
            this.textData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data format";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Location = new System.Drawing.Point(313, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 68);
            this.panel1.TabIndex = 11;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(128, 13);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(91, 43);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 13);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 43);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(370, 285);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(128, 22);
            this.txtchange.TabIndex = 12;
            this.txtchange.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 437);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pOpen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textDataSha1;
        private System.Windows.Forms.CheckBox checkSha1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textDataSha2;
        private System.Windows.Forms.CheckBox checkSha2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textDataHMAC;
        private System.Windows.Forms.CheckBox checkHMAC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.ComboBox cbcheckbox;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pOpen;
        private System.Windows.Forms.TextBox txtchange;
    }
}

