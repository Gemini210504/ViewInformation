using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ViewInformation
{
    public partial class Form1 : Form
    {
        private ObjectView objView = null;
        private IObject obj;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Panel1.AutoSize = true ;
            Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel1.Controls.Clear();

            try
            {
          
                obj = new Rectangle(4.5, 12.8);
                objView = new SingleLineView(obj);
                Panel first = objView.Layout;
                Panel1.Controls.Add(first);

                obj = new Student("HENG Sensok", "22", 85.5);
                objView = new FieldView(obj);
                Panel second = objView.Layout;
                Panel1.Controls.Add(second);

                second.Top = first.Height + 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
