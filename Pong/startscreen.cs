﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pong
{
    public partial class startscreen : Form
    {
        public startscreen()
        {
            InitializeComponent();
            textBox1.Hide();
            setDatapath(null, null);

            losescreen losescreen = (losescreen)System.Windows.Forms.Application.OpenForms["losescreen"];
            if (losescreen != null)
            {
                losescreen.Close();
            }
        }

        public void closeEndScreen()
        {
            losescreen losescreen = (losescreen)System.Windows.Forms.Application.OpenForms["losescreen"];
            if (losescreen != null)
            {
                losescreen.Close();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Pong p = new Pong();
            p.Show();
            this.Hide();
        }

        //setPath and getWebsitePath
        public void setDatapath(string name, string score)
        {
            webBrowser1.Navigate("chat.sigmale.dev/desktop-application/");
            if (name != null && score != null)
            {
                webBrowser1.Navigate("chat.sigmale.dev/admincontroll/databaseInsert.php/?&newDataName=" + name + "&newDataScore=" + score);
            }
        }


        //Info anzeigen
        int tryzahl = 0;
        private void InfoBTN_Click(object sender, EventArgs e)
        {
            
            if(tryzahl % 2 == 0)
            {
                tryzahl++;
                textBox1.Show();
            }
            else
            {
                textBox1.Hide() ;
                tryzahl++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
