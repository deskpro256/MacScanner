namespace MacScanner
{
    partial class MacScanner
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
            this.components = new System.ComponentModel.Container();
            this.ScanButton = new System.Windows.Forms.Button();
            this.NetworkCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.MACTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ListView = new System.Windows.Forms.TreeView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(124, 19);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 23);
            this.ScanButton.TabIndex = 0;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // NetworkCheckBox
            // 
            this.NetworkCheckBox.AutoSize = true;
            this.NetworkCheckBox.Location = new System.Drawing.Point(205, 23);
            this.NetworkCheckBox.Name = "NetworkCheckBox";
            this.NetworkCheckBox.Size = new System.Drawing.Size(145, 17);
            this.NetworkCheckBox.TabIndex = 1;
            this.NetworkCheckBox.Text = "Scan outside my network";
            this.NetworkCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.MACTextBox);
            this.groupBox.Controls.Add(this.progressBar1);
            this.groupBox.Controls.Add(this.ScanButton);
            this.groupBox.Controls.Add(this.NetworkCheckBox);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(596, 54);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "MAC";
            // 
            // MACTextBox
            // 
            this.MACTextBox.Location = new System.Drawing.Point(18, 21);
            this.MACTextBox.Name = "MACTextBox";
            this.MACTextBox.Size = new System.Drawing.Size(100, 20);
            this.MACTextBox.TabIndex = 3;
            this.MACTextBox.Text = "AF:34:FA";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(356, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // ListView
            // 
            this.ListView.Location = new System.Drawing.Point(12, 72);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(596, 241);
            this.ListView.TabIndex = 4;
            // 
            // MacScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 325);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.groupBox);
            this.Name = "MacScanner";
            this.Text = "MAC Scanner";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.CheckBox NetworkCheckBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox MACTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TreeView ListView;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

