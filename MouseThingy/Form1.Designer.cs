namespace MouseThingy
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
            this.bnUpdate = new System.Windows.Forms.Button();
            this.processList = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.ComboBox();
            this.bnGo = new System.Windows.Forms.Button();
            this.tb_hmul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Test = new System.Windows.Forms.Button();
            this.tb_haddr = new System.Windows.Forms.TextBox();
            this.tb_vaddr = new System.Windows.Forms.TextBox();
            this.tb_vmul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnUpdate
            // 
            this.bnUpdate.Location = new System.Drawing.Point(12, 12);
            this.bnUpdate.Name = "bnUpdate";
            this.bnUpdate.Size = new System.Drawing.Size(145, 23);
            this.bnUpdate.TabIndex = 0;
            this.bnUpdate.Text = "Update Processes";
            this.bnUpdate.UseVisualStyleBackColor = true;
            this.bnUpdate.Click += new System.EventHandler(this.bnUpdate_Click);
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(163, 12);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(301, 21);
            this.processList.TabIndex = 1;
            this.processList.SelectionChangeCommitted += new System.EventHandler(this.processList_SelectionChangeCommitted);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(163, 39);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(301, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write to address:";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(163, 92);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(301, 20);
            this.tbData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.Items.AddRange(new object[] {
            "Int",
            "String",
            "Float"});
            this.dataList.Location = new System.Drawing.Point(163, 65);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(301, 21);
            this.dataList.TabIndex = 8;
            // 
            // bnGo
            // 
            this.bnGo.Location = new System.Drawing.Point(12, 118);
            this.bnGo.Name = "bnGo";
            this.bnGo.Size = new System.Drawing.Size(394, 23);
            this.bnGo.TabIndex = 9;
            this.bnGo.Text = "GO";
            this.bnGo.UseVisualStyleBackColor = true;
            this.bnGo.Click += new System.EventHandler(this.bnOk_Click);
            // 
            // tb_hmul
            // 
            this.tb_hmul.Location = new System.Drawing.Point(12, 148);
            this.tb_hmul.Name = "tb_hmul";
            this.tb_hmul.Size = new System.Drawing.Size(100, 20);
            this.tb_hmul.TabIndex = 10;
            this.tb_hmul.Text = "0.001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "H Multiplier";
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(413, 118);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(51, 23);
            this.Test.TabIndex = 12;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // tb_haddr
            // 
            this.tb_haddr.Location = new System.Drawing.Point(262, 148);
            this.tb_haddr.Name = "tb_haddr";
            this.tb_haddr.Size = new System.Drawing.Size(100, 20);
            this.tb_haddr.TabIndex = 13;
            // 
            // tb_vaddr
            // 
            this.tb_vaddr.Location = new System.Drawing.Point(262, 174);
            this.tb_vaddr.Name = "tb_vaddr";
            this.tb_vaddr.Size = new System.Drawing.Size(100, 20);
            this.tb_vaddr.TabIndex = 13;
            // 
            // tb_vmul
            // 
            this.tb_vmul.Location = new System.Drawing.Point(12, 174);
            this.tb_vmul.Name = "tb_vmul";
            this.tb_vmul.Size = new System.Drawing.Size(100, 20);
            this.tb_vmul.TabIndex = 10;
            this.tb_vmul.Text = "0.001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "V Multiplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "H Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "V Address";
            // 
            // lblFov
            // 
            this.lblFov.AutoSize = true;
            this.lblFov.Enabled = false;
            this.lblFov.Location = new System.Drawing.Point(9, 213);
            this.lblFov.Name = "lblFov";
            this.lblFov.Size = new System.Drawing.Size(28, 13);
            this.lblFov.TabIndex = 14;
            this.lblFov.Text = "Fov:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 246);
            this.Controls.Add(this.lblFov);
            this.Controls.Add(this.tb_vaddr);
            this.Controls.Add(this.tb_haddr);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_vmul);
            this.Controls.Add(this.tb_hmul);
            this.Controls.Add(this.bnGo);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.bnUpdate);
            this.Name = "Form1";
            this.Text = "Test Thingy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnUpdate;
        private System.Windows.Forms.ComboBox processList;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dataList;
        private System.Windows.Forms.Button bnGo;
        private System.Windows.Forms.TextBox tb_hmul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.TextBox tb_haddr;
        private System.Windows.Forms.TextBox tb_vaddr;
        private System.Windows.Forms.TextBox tb_vmul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblFov;
    }
}

