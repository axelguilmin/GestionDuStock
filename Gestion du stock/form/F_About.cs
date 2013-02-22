using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Gestion_du_stock
{
    public partial class F_About : Form
    {
        public F_About()
        {
            InitializeComponent();
        }

        private void F_About_Load(object sender, EventArgs e)
        {
            this.label4.Text = "Version " + Assembly.GetEntryAssembly().GetName().Version.ToString() + "(" + Assembly.GetEntryAssembly().GetName().ProcessorArchitecture.ToString() + ")";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ouvrir le navigateur
            System.Diagnostics.Process.Start("http://www.axelguilmin.fr");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://thenounproject.com/noun/firetruck/#icon-No269");
        }

        private void F_About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.ReturnToAccueil();
        }

    }
}
