namespace ReadLUISProjectExportFile
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
            this.txbJsonPath = new System.Windows.Forms.TextBox();
            this.btnSelectJson = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbJsonPath
            // 
            this.txbJsonPath.Location = new System.Drawing.Point(12, 12);
            this.txbJsonPath.Name = "txbJsonPath";
            this.txbJsonPath.Size = new System.Drawing.Size(613, 20);
            this.txbJsonPath.TabIndex = 0;
            // 
            // btnSelectJson
            // 
            this.btnSelectJson.Location = new System.Drawing.Point(631, 10);
            this.btnSelectJson.Name = "btnSelectJson";
            this.btnSelectJson.Size = new System.Drawing.Size(157, 23);
            this.btnSelectJson.TabIndex = 1;
            this.btnSelectJson.Text = "Select JSON";
            this.btnSelectJson.UseVisualStyleBackColor = true;
            this.btnSelectJson.Click += new System.EventHandler(this.btnSelectJson_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(12, 38);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbContent.Size = new System.Drawing.Size(776, 400);
            this.txbContent.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.btnSelectJson);
            this.Controls.Add(this.txbJsonPath);
            this.Name = "Form1";
            this.Text = "Read LUIS project export file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbJsonPath;
        private System.Windows.Forms.Button btnSelectJson;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txbContent;
    }
}

