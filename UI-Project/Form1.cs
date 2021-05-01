using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public UI_Project.SourcePage SourcePage { get { return sourcePage1; } }
        public UI_Project.DesignPage DesignPage { get { return designPage1; } }
        public Form1()
        {
            InitializeComponent();
            designPage1.shapes = new List<Shape>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            tabControl.Show();
            designPage1.Hide();
            sourcePage1.Show();
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //drawingBoard.Paint += new PaintEventHandler(drawingBoard_Paint);

        }


        private void source_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(tabPage1))
            {
                 designPage1.Hide();
                UIProject.Form1.Instance.DesignPage.updateSource();

                sourcePage1.Show();
            }
            else if (tabControl.SelectedTab.Equals(tabPage2))
            {
                sourcePage1.Hide();
                UIProject.Form1.Instance.SourcePage.validateDrws();
                UIProject.Form1.Instance.DesignPage.shapes = UIProject.Form1.Instance.SourcePage.newShapes;
                designPage1.Show();
            }

        }

        private void menuToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sourcePage1_Load(object sender, EventArgs e)
        {

        }
    }


}
