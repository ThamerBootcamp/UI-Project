using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UIProject;

namespace UI_Project
{
    public partial class DesignPage : UserControl
    {
        private bool canMove = false;
        public List<Shape> shapes;

        bool isPointerMode = false;

        private Shape currentShape = null;
        private Shape tempShape = null;

        private Shape activeShape = null;

        private float penSize = 4;
        public static Color penColor = System.Drawing.Color.Black; //System.Windows.Media.Color.FromRgb(0, 0, 0); 
        private System.Drawing.Drawing2D.DashStyle penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        //private Pen p = new Pen(Brushes.Black, 4);

        private string selectedShape = "Circle";

        public System.Drawing.Point start;
        public System.Drawing.Point end;
        private bool isTempPaint = false;

        public DesignPage()
        {
            InitializeComponent();
            //this.shapes = new List<Shape>();
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            foreach (var shape in this.shapes)
            {
                if (isPointerMode && shape.Equals(activeShape))
                {
                    shape.draw(g, true);

                }
                else
                {
                    shape.draw(g);
                }

            }
            if (isTempPaint)
                tempShape.draw(g);

            drawingBoard.Invalidate();

        }

        public void updateSource()
        {
            string context = "";
            for (var i =0;i< shapes.Count; i++)
            {
                if (shapes[i].GetType().Equals(typeof(Circle)))
                {
                    context += "cir " + shapes[i].rect.X + "," + shapes[i].rect.Y + "," + shapes[i].rect.Width + "," + shapes[i].rect.Height;
                }
                else if (shapes[i].GetType().Equals(typeof(SRectangle)))
                {
                    context += "rect " + shapes[i].rect.X + "," + shapes[i].rect.Y + "," + shapes[i].rect.Width + "," + shapes[i].rect.Height;
                }
                else if (shapes[i].GetType().Equals(typeof(Line)))
                {
                    context += "line " + shapes[i].Start.X + "," + shapes[i].Start.Y+","+ shapes[i].End.X+","+ shapes[i].End.Y;
                }
                if(!(i+1 == shapes.Count))
                    context += " - \n";
                
            }

            Form1.Instance.SourcePage.Context = context;
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!isPointerMode)
            {
                if (selectedShape == "Rectangle")
                {
                    currentShape = new SRectangle();
                }
                else if (selectedShape == "Circle")
                {
                    currentShape = new Circle();
                }
                else
                {
                    currentShape = new Line();
                }

                this.Invalidate();
            }
            else if (activeShape != null)
            {
                canMove = true;
            }
            start = e.Location;

            drawingBoard.Invalidate();

        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (!isPointerMode)
            {
                isTempPaint = false;
                end = e.Location;

                //befor fix for the lines
                currentShape.Start = start;
                currentShape.End = end;

                Point[] fixedPoints = fixPoints(start, end);

                start = fixedPoints[0];
                end = fixedPoints[1];

                int width = Math.Abs(end.X - start.X);
                int height = Math.Abs(end.Y - start.Y);
                Rectangle rect = new Rectangle(start.X, start.Y, width, height);
                currentShape.rect = rect;
               
                SolidBrush brush = new SolidBrush(penColor);
                currentShape.brush = brush;
                currentShape.pen = new Pen(currentShape.brush, penSize);
                
                //currentShape.brush = penColor as Brush;//Brushes.Black;
                currentShape.pen.DashStyle = penStyle;

                this.shapes.Add(currentShape);
                // drawingBoard.Invalidate();
                //drawingBoard.Refresh();

            }
            //else 
            canMove = false;
            drawingBoard.Invalidate();
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (activeShape != null && canMove)
            {
                if (activeShape.Top.Contains(start))
                {
                    activeShape.Start.Y -= start.Y - e.Y;

                    activeShape.rect.Y -= start.Y - e.Y;
                    activeShape.rect.Height += start.Y - e.Y;
                    start = new Point(e.X, e.Y);
                }
                else if (activeShape.Right.Contains(start))
                {
                    activeShape.End.X += e.X - start.X;
                    activeShape.rect.Width += e.X - start.X;
                    start = new Point(e.X, e.Y);
                }
                else if (activeShape.Left.Contains(start))
                {
                    activeShape.Start.X += e.X - start.X;

                    activeShape.rect.X += e.X - start.X;
                    activeShape.rect.Width -= e.X - start.X;
                    start = new Point(e.X, e.Y);
                }
                else if (activeShape.Down.Contains(start))
                {
                    activeShape.End.Y += e.Y - start.Y;

                    activeShape.rect.Height += e.Y - start.Y;
                    start = new Point(e.X, e.Y);
                }
                else
                {
                    activeShape.Start.X += e.X - start.X;
                    activeShape.Start.Y += e.Y - start.Y;
                    activeShape.End.X += e.X - start.X;
                    activeShape.End.Y += e.Y - start.Y;

                    activeShape.rect.X += e.X - start.X;
                    activeShape.rect.Y += e.Y - start.Y;
                    start = new Point(e.X, e.Y);
                }
                  drawingBoard.Invalidate();
            }
        }

        public static Point[] fixPoints(Point start, Point end)
        {
            int w = Math.Abs(end.X - start.X);
            int h = Math.Abs(end.Y - start.Y);
            Point fStart;
            Point fEnd;

            if (end.X > start.X)
            {
                if (end.Y < start.Y)
                {
                    fStart = new Point((end.X - w), end.Y);
                    fEnd = new Point((start.X + w), start.Y);
                }
                else
                {
                    fStart = start;
                    fEnd = end;
                }
            }
            else
            {
                if (end.Y > start.Y)
                {
                    fStart = new Point((start.X - w), start.Y);
                    fEnd = new Point((end.X + w), end.Y);
                }
                else
                {
                    fStart = end;
                    fEnd = start;
                }
            }

            return new Point[] { fStart, fEnd };

        }

        private void drawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (isPointerMode)
            {
                foreach (var shape in shapes)
                {
                    if (shape.IsInside(e.Location))
                    {
                        activeShape = shape;
                        break;
                        //shape.pen.Brush= Brushes.Red;
                    }
                    else
                    {
                        activeShape = null;
                    }
                }
            }
            drawingBoard.Invalidate();
        }
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPointerMode = false;

            selectedShape = "Circle";
        }

        private void pointerButton_Click(object sender, EventArgs e)
        {
             isPointerMode = true;

        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            isPointerMode = false;
            selectedShape = "Circle";
        }

        private void rectButton1_Click(object sender, EventArgs e)
        {
            isPointerMode = false;
            selectedShape = "Rectangle";
        }

        private void LineButton1_Click(object sender, EventArgs e)
        {
            isPointerMode = false;
            selectedShape = "Line";
        }

        private void dottedButton_Click(object sender, EventArgs e)
        {
             this.penStyle = System.Drawing.Drawing2D.DashStyle.Dot;

        }

        private void solidButton1_Click(object sender, EventArgs e)
        {
             this.penStyle = System.Drawing.Drawing2D.DashStyle.Solid;

        }

        private void dashedButton1_Click(object sender, EventArgs e)
        {
             this.penStyle = System.Drawing.Drawing2D.DashStyle.Dash;

        }


        private void colorButton1_Click(object sender, EventArgs e)
         {
             /*colorDialog1.ShowDialog();
             try
             {
                 if (colorDialog1.ShowDialog() == DialogResult.OK)
                 {
                     DesignPage.penColor = colorDialog1.Color;
                 }

             }
             catch (Exception ex)
             {
                 var err = MessageBox.Show("Error: cant open color dialog") ;

                 //throw ex;
             }
             */
         }
        
    }
}
