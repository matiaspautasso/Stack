using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsStack peopleRows = new ClsStack();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (peopleRows.FIRST != null)
            {
                lblCode.Text = peopleRows.FIRST.Code.ToString();
              
                lblName.Text = peopleRows.FIRST.Name.ToString();
                lblProcess.Text = peopleRows.FIRST.Proccess.ToString();
                peopleRows.Delete();
                peopleRows.Navigate(DgvStack);
                peopleRows.Navigate(LstStack);
                peopleRows.Navigate();


            }
            else
            {
                lblCode.Text = "";
                lblCode.Text = "";
                lblProcess.Text = "";

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ClsNode OBJ = new ClsNode();
            OBJ.Code = int.Parse(txtCode.Text);
            OBJ.Name = txtName.Text;
            OBJ.Proccess = txtProcess.Text;

            peopleRows.Insert(OBJ);
            peopleRows.Navigate(DgvStack);
            peopleRows.Navigate(LstStack);
            peopleRows.Navigate();
            txtCode.Text = "";
            txtName.Text = "";
            txtProcess.Text = "";
        }
    }
}
