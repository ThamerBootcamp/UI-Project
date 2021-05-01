namespace UIProject
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sourcePage1 = new UI_Project.SourcePage();
            this.designPage1 = new UI_Project.DesignPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 649);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1340, 48);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.source_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Size = new System.Drawing.Size(1324, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Source";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Size = new System.Drawing.Size(1324, -4);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Design";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sourcePage1
            // 
            this.sourcePage1.AutoScroll = true;
            this.sourcePage1.AutoSize = true;
            this.sourcePage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sourcePage1.Context = "";
            this.sourcePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePage1.Location = new System.Drawing.Point(0, 0);
            this.sourcePage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sourcePage1.Name = "sourcePage1";
            this.sourcePage1.Size = new System.Drawing.Size(1340, 649);
            this.sourcePage1.TabIndex = 1;
            this.sourcePage1.Load += new System.EventHandler(this.sourcePage1_Load);
            // 
            // designPage1
            // 
            this.designPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.designPage1.BackColor = System.Drawing.Color.Ivory;
            this.designPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designPage1.Location = new System.Drawing.Point(0, 0);
            this.designPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.designPage1.Name = "designPage1";
            this.designPage1.Size = new System.Drawing.Size(1340, 649);
            this.designPage1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.sourcePage1);
            this.panel1.Controls.Add(this.designPage1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 649);
            this.panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Lucida Console", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.tabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UI_Project.SourcePage sourcePage1;
        private UI_Project.DesignPage designPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

