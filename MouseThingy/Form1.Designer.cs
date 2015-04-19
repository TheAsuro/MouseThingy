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
            this.bnGo.Size = new System.Drawing.Size(452, 23);
            this.bnGo.TabIndex = 9;
            this.bnGo.Text = "GO";
            this.bnGo.UseVisualStyleBackColor = true;
            this.bnGo.Click += new System.EventHandler(this.bnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 148);
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
    }
}

