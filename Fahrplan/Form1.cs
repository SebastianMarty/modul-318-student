using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HauptPanel.Dock = DockStyle.Fill;
            SuchfeldPanel.Dock = DockStyle.Fill;
        }

        private void OnSuchen_Click(object sender, EventArgs e)
        {
            
        }

        private void OnSuchfeld_Click(object sender, EventArgs e)
        {
            HauptPanel.Enabled = false;
            HauptPanel.Visible = false;
            SuchfeldPanel.Enabled = true;
            SuchfeldPanel.Visible = true;

            TextBox tb = sender as TextBox;
            
            if(tb.Name == "txtVonSuchfeld")
            {
                lblSuchfeldVonNach.Text = "Von:";
            }
            else if(tb.Name == "txtNachSuchfeld")
            {
                lblSuchfeldVonNach.Text = "Nach:";
            }
        }

        private void OnAbbrechen_Click(object sender, EventArgs e)
        {
            SuchfeldPanel.Enabled = false;
            SuchfeldPanel.Visible = false;
            HauptPanel.Enabled = true;
            HauptPanel.Visible = true;
        }
    }
}
