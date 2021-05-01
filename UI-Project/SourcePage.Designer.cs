
namespace UI_Project
{
    partial class SourcePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourcePage));
            this.srcpanel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.OpenButton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.srcpanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // srcpanel1
            // 
            this.srcpanel1.Controls.Add(this.richTextBox1);
            this.srcpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcpanel1.Location = new System.Drawing.Point(0, 0);
            this.srcpanel1.Name = "srcpanel1";
            this.srcpanel1.Size = new System.Drawing.Size(1304, 846);
            this.srcpanel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1304, 846);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1111, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 846);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton1);
            this.groupBox1.Controls.Add(this.OpenButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // saveButton1
            // 
            this.saveButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton1.Image = ((System.Drawing.Image)(resources.GetObject("saveButton1.Image")));
            this.saveButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton1.Location = new System.Drawing.Point(3, 132);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(187, 93);
            this.saveButton1.TabIndex = 1;
            this.saveButton1.Text = "Save as";
            this.saveButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // OpenButton1
            // 
            this.OpenButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenButton1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenButton1.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton1.Image")));
            this.OpenButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenButton1.Location = new System.Drawing.Point(3, 35);
            this.OpenButton1.Name = "OpenButton1";
            this.OpenButton1.Size = new System.Drawing.Size(187, 97);
            this.OpenButton1.TabIndex = 0;
            this.OpenButton1.Text = "Open file";
            this.OpenButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenButton1.UseVisualStyleBackColor = true;
            this.OpenButton1.Click += new System.EventHandler(this.OpenButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "drw";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.drw)|*.drw";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "drw";
            this.saveFileDialog1.Filter = "(*.drw)|*.drw";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // SourcePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.srcpanel1);
            this.Name = "SourcePage";
            this.Size = new System.Drawing.Size(1304, 846);
            this.srcpanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel srcpanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.Button OpenButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
