using DrwParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Project
{
    public partial class SourcePage : UserControl
    {
        bool isValid = true;
        public List<UIProject.Shape> newShapes = new List<UIProject.Shape>();
        public SourcePage()
        {
            InitializeComponent();
        }
        public string Context { 
            get
            {
                return richTextBox1.Text;
            }
            set 
            {
                richTextBox1.Text = value; 
            }
        }
        /*public void updateContext(string str)
        {
            richTextBox1.Text = str;
        }*/

        public void validateDrws()
        {

            //********************//
            newShapes.Clear();
            // run tokenizer here
            Input input = new Input(richTextBox1.Text);
            try
            {
                Tokenizer t = new Tokenizer(input, new Tokenizable[] {
                    new KeywordsTokenizer(new List<string>
                    {
                        "cir","rect","line"
                    }),
                    new NumberTokenizer(),
                    new NewLineTokenizer(true),
                    new WhiteSpaceTokenizer(true),
                    new JSymbolsTokenizer(',',"comma"),
                    new JSymbolsTokenizer('-',"hyphen"),
                });
            
                List<Token> tokens = new List<Token>();

                Token token = t.tokenize();
                while (token != null)
                {
                    tokens.Add(token);
                    Console.WriteLine(token.Value + " ---> " + token.Type);
                    token = t.tokenize();
                }
                List<DrwValue> drws = DrwParser.DrwParser.parse(ref tokens);

                if (isValid)
                {
                    foreach (var drw in drws)
                    {
                        if (drw.Shape == "cir")
                        {
                            UIProject.Shape currShape = new UIProject.Circle();
                            currShape.rect = new Rectangle(drw.Values[0], drw.Values[1], drw.Values[2], drw.Values[3]);
                            newShapes.Add(currShape);
                            //UIProject.Form1.Instance.DesignPage.shapes.Add(currShape);
                        }
                        else if (drw.Shape == "rect")
                        {
                            UIProject.Shape currShape = new UIProject.SRectangle();
                            currShape.rect = new Rectangle(drw.Values[0], drw.Values[1], drw.Values[2], drw.Values[3]);
                            newShapes.Add(currShape);

                            //UIProject.Form1.Instance.DesignPage.shapes.Add(currShape);
                        }
                        else if (drw.Shape == "line")
                        {

                            UIProject.Shape currShape = new UIProject.Line();
                            //currShape.rect = new Rectangle(drw.Values[0], drw.Values[1], drw.Values[2], drw.Values[3]);

                            currShape.Start = new Point(drw.Values[0], drw.Values[1]);
                            currShape.End = new Point(drw.Values[2], drw.Values[3]);

                            Point start = currShape.Start;
                            Point end = currShape.End;
                            Point[] fixedPoints = UI_Project.DesignPage.fixPoints(start, end);

                            start = fixedPoints[0];
                            end = fixedPoints[1];

                            int width = Math.Abs(end.X - start.X);
                            int height = Math.Abs(end.Y - start.Y);
                            Rectangle rect = new Rectangle(start.X, start.Y, width, height);
                            currShape.rect = rect;

                            newShapes.Add(currShape);

                            //UIProject.Form1.Instance.DesignPage.shapes.Add(currShape);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
                var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
                // Create dialog instance.
                var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

                // Populate relevant properties on the dialog instance.
                dialog.Text = "Source Code Error";
                dialogType.GetProperty("Details").SetValue(dialog, ex.ToString(), null);
                dialogType.GetProperty("Message").SetValue(dialog, "please make sure to use the correct format \"shape value1,value2,value3,value4\".\n more than one are seperated by hyphen \n\n for more information see details ", null);

                // Display dialog.
                var result = dialog.ShowDialog();

                //var res = MessageBox.Show(ex.ToString());
            }
 

        }

        private void OpenButton1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
 
            try
            {
                string fileName = openFileDialog1.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    string context = File.ReadAllText(fileName) ;
                    richTextBox1.Text = context;
                }
                else
                {
                    var res = MessageBox.Show("empty file!");
                }


            }
            catch
            {

               // var res = MessageBox.Show("you did not choose a file!");
            }
            
        }

        private void saveButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            try
            {
                if (!string.IsNullOrEmpty(path)) 
                    File.WriteAllText(path, richTextBox1.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

    }
}
