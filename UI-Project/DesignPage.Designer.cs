
namespace UI_Project
{
    partial class DesignPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignPage));
            this.drawingBoard = new UIProject.DrawingBoard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBox1 = new System.Windows.Forms.GroupBox();
            this.colorButton1 = new System.Windows.Forms.Button();
            this.generalBox1 = new System.Windows.Forms.GroupBox();
            this.pointerButton = new System.Windows.Forms.Button();
            this.ShapesBox1 = new System.Windows.Forms.GroupBox();
            this.LineButton1 = new System.Windows.Forms.Button();
            this.rectButton1 = new System.Windows.Forms.Button();
            this.circleButton1 = new System.Windows.Forms.Button();
            this.PenBox1 = new System.Windows.Forms.GroupBox();
            this.solidButton1 = new System.Windows.Forms.Button();
            this.dashedButton1 = new System.Windows.Forms.Button();
            this.dottedButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.colorBox1.SuspendLayout();
            this.generalBox1.SuspendLayout();
            this.ShapesBox1.SuspendLayout();
            this.PenBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.AccessibleName = "drawingBoard";
            this.drawingBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingBoard.Location = new System.Drawing.Point(0, 0);
            this.drawingBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(1366, 768);
            this.drawingBoard.TabIndex = 2;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseClick);
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.colorBox1);
            this.panel1.Controls.Add(this.generalBox1);
            this.panel1.Controls.Add(this.ShapesBox1);
            this.panel1.Controls.Add(this.PenBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1185, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 768);
            this.panel1.TabIndex = 0;
            // 
            // colorBox1
            // 
            this.colorBox1.Controls.Add(this.colorButton1);
            this.colorBox1.Location = new System.Drawing.Point(8, 605);
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(167, 119);
            this.colorBox1.TabIndex = 3;
            this.colorBox1.TabStop = false;
            this.colorBox1.Text = "Color";
            // 
            // colorButton1
            // 
            this.colorButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorButton1.Image")));
            this.colorButton1.Location = new System.Drawing.Point(3, 35);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(161, 81);
            this.colorButton1.TabIndex = 0;
            this.colorButton1.UseVisualStyleBackColor = true;
            this.colorButton1.Click += new System.EventHandler(this.colorButton1_Click);
            // 
            // generalBox1
            // 
            this.generalBox1.Controls.Add(this.pointerButton);
            this.generalBox1.Location = new System.Drawing.Point(7, 47);
            this.generalBox1.Name = "generalBox1";
            this.generalBox1.Size = new System.Drawing.Size(171, 122);
            this.generalBox1.TabIndex = 2;
            this.generalBox1.TabStop = false;
            this.generalBox1.Text = "Pointer";
            // 
            // pointerButton
            // 
            this.pointerButton.BackColor = System.Drawing.SystemColors.Control;
            this.pointerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pointerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointerButton.Image = ((System.Drawing.Image)(resources.GetObject("pointerButton.Image")));
            this.pointerButton.Location = new System.Drawing.Point(3, 35);
            this.pointerButton.Name = "pointerButton";
            this.pointerButton.Size = new System.Drawing.Size(165, 84);
            this.pointerButton.TabIndex = 0;
            this.pointerButton.UseVisualStyleBackColor = true;
            this.pointerButton.Click += new System.EventHandler(this.pointerButton_Click);
            // 
            // ShapesBox1
            // 
            this.ShapesBox1.Controls.Add(this.LineButton1);
            this.ShapesBox1.Controls.Add(this.rectButton1);
            this.ShapesBox1.Controls.Add(this.circleButton1);
            this.ShapesBox1.Location = new System.Drawing.Point(7, 407);
            this.ShapesBox1.Name = "ShapesBox1";
            this.ShapesBox1.Size = new System.Drawing.Size(164, 192);
            this.ShapesBox1.TabIndex = 2;
            this.ShapesBox1.TabStop = false;
            this.ShapesBox1.Text = "Shape";
            // 
            // LineButton1
            // 
            this.LineButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.LineButton1.Image = ((System.Drawing.Image)(resources.GetObject("LineButton1.Image")));
            this.LineButton1.Location = new System.Drawing.Point(108, 35);
            this.LineButton1.Name = "LineButton1";
            this.LineButton1.Size = new System.Drawing.Size(53, 154);
            this.LineButton1.TabIndex = 2;
            this.LineButton1.UseVisualStyleBackColor = true;
            this.LineButton1.Click += new System.EventHandler(this.LineButton1_Click);
            // 
            // rectButton1
            // 
            this.rectButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rectButton1.Image = ((System.Drawing.Image)(resources.GetObject("rectButton1.Image")));
            this.rectButton1.Location = new System.Drawing.Point(56, 35);
            this.rectButton1.Name = "rectButton1";
            this.rectButton1.Size = new System.Drawing.Size(52, 154);
            this.rectButton1.TabIndex = 1;
            this.rectButton1.UseVisualStyleBackColor = true;
            this.rectButton1.Click += new System.EventHandler(this.rectButton1_Click);
            // 
            // circleButton1
            // 
            this.circleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.circleButton1.Image = ((System.Drawing.Image)(resources.GetObject("circleButton1.Image")));
            this.circleButton1.Location = new System.Drawing.Point(3, 35);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(53, 154);
            this.circleButton1.TabIndex = 0;
            this.circleButton1.UseVisualStyleBackColor = true;
            this.circleButton1.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // PenBox1
            // 
            this.PenBox1.Controls.Add(this.solidButton1);
            this.PenBox1.Controls.Add(this.dashedButton1);
            this.PenBox1.Controls.Add(this.dottedButton);
            this.PenBox1.Location = new System.Drawing.Point(10, 192);
            this.PenBox1.Name = "PenBox1";
            this.PenBox1.Size = new System.Drawing.Size(161, 201);
            this.PenBox1.TabIndex = 1;
            this.PenBox1.TabStop = false;
            this.PenBox1.Text = "Pen";
            // 
            // solidButton1
            // 
            this.solidButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.solidButton1.Image = ((System.Drawing.Image)(resources.GetObject("solidButton1.Image")));
            this.solidButton1.Location = new System.Drawing.Point(106, 35);
            this.solidButton1.Name = "solidButton1";
            this.solidButton1.Size = new System.Drawing.Size(52, 163);
            this.solidButton1.TabIndex = 2;
            this.solidButton1.UseVisualStyleBackColor = true;
            this.solidButton1.Click += new System.EventHandler(this.solidButton1_Click);
            // 
            // dashedButton1
            // 
            this.dashedButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashedButton1.Image = ((System.Drawing.Image)(resources.GetObject("dashedButton1.Image")));
            this.dashedButton1.Location = new System.Drawing.Point(56, 35);
            this.dashedButton1.Name = "dashedButton1";
            this.dashedButton1.Size = new System.Drawing.Size(53, 163);
            this.dashedButton1.TabIndex = 1;
            this.dashedButton1.UseVisualStyleBackColor = true;
            this.dashedButton1.Click += new System.EventHandler(this.dashedButton1_Click);
            // 
            // dottedButton
            // 
            this.dottedButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.dottedButton.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dottedButton.Location = new System.Drawing.Point(3, 35);
            this.dottedButton.Name = "dottedButton";
            this.dottedButton.Size = new System.Drawing.Size(53, 163);
            this.dottedButton.TabIndex = 0;
            this.dottedButton.Text = ".....";
            this.dottedButton.UseVisualStyleBackColor = true;
            this.dottedButton.Click += new System.EventHandler(this.dottedButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            // 
            // DesignPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawingBoard);
            this.Name = "DesignPage";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel1.ResumeLayout(false);
            this.colorBox1.ResumeLayout(false);
            this.generalBox1.ResumeLayout(false);
            this.ShapesBox1.ResumeLayout(false);
            this.PenBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIProject.DrawingBoard drawingBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox PenBox1;
        private System.Windows.Forms.GroupBox generalBox1;
        private System.Windows.Forms.Button pointerButton;
        private System.Windows.Forms.GroupBox ShapesBox1;
        private System.Windows.Forms.Button circleButton1;
        private System.Windows.Forms.Button LineButton1;
        private System.Windows.Forms.Button rectButton1;
        private System.Windows.Forms.Button solidButton1;
        private System.Windows.Forms.Button dashedButton1;
        private System.Windows.Forms.Button dottedButton;
        private System.Windows.Forms.GroupBox colorBox1;
        private System.Windows.Forms.Button colorButton1;
        public System.Windows.Forms.ColorDialog colorDialog1;
    }
}
