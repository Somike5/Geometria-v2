using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometriav2 {
    public partial class Form1 : Form {

        Form haromszogForm, korForm, teglalapForm, teglaTestForm, gombForm, hengerForm;

        
        public Form1() {
            InitializeComponent();
            haromszog_RB.Checked = false;
        }

        private void haromszog_RB_CheckedChanged(object sender, EventArgs e) {
            if (haromszog_RB.Checked) {
                haromszogForm = new HaromszogWindow(this);
                //haromszog_RB.Checked = false;
                setUnCheck(sender);
            }
        }


        private void kor_RB_CheckedChanged(object sender, EventArgs e) {
            if (kor_RB.Checked) {
                korForm = new KorForm(this);
                setUnCheck(sender);
            }
        }

        private void teglalap_RB_CheckedChanged(object sender, EventArgs e) {
            if (teglalap_RB.Checked) {
                teglalapForm = new TeglalapForm(this);
                setUnCheck(sender);
            }
        }


        private void gomb_RB_CheckedChanged(object sender, EventArgs e) {
            if (gomb_RB.Checked) {
                gombForm = new GombForm(this);
                setUnCheck(sender);
            }
        }

        private void teglatest_RB_CheckedChanged(object sender, EventArgs e) {
            if (teglatest_RB.Checked) {
                teglaTestForm = new TeglaTestForm(this);
                setUnCheck(sender);
            }
        
        }

        private void henger_RB_CheckedChanged(object sender, EventArgs e) {
            if (henger_RB.Checked) {
                hengerForm = new HengerForm(this);
                setUnCheck(sender);
            }
        }


        private void haromszogPanel_Click(object sender, EventArgs e) {
            haromszog_RB.Checked = true;
        }

        private void negyszogPanel_Click(object sender, EventArgs e) {
            teglalap_RB.Checked = true;
        }

        private void korPanel_Click(object sender, EventArgs e) {
            kor_RB.Checked = true;
        }

        private void gombPanel_Click(object sender, EventArgs e) {
            gomb_RB.Checked = true;
        }

        private void hengerPanel_Click(object sender, EventArgs e) {
            henger_RB.Checked = true;
        }

        private void teglatestPanel_Click(object sender, EventArgs e) {
            teglatest_RB.Checked = true;
        }


        private void setUnCheck(object rbObject) {
            ((RadioButton)rbObject).Checked = false;
        }
    }
}
