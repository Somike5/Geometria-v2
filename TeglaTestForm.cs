using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class TeglaTestForm : Form {
        private GroupBox groupBox1;
        private RadioButton kocka_RB;
        private RadioButton teglaTest_RB;
        private NumericUpDown aOldalUpDown;
        private NumericUpDown cOldalUpDown;
        private NumericUpDown bOldalUpDown;
        private Label cOldalLabel;
        private Label bOldalLabel;
        private Label label1;
        private Button computeButton;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label testAtloResultLabel;
        private Label felszinResultLabel;
        private Label terfogatResultLabel;
        private Form1 mainForm;

        public TeglaTestForm(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }

        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.cOldalUpDown = new System.Windows.Forms.NumericUpDown();
            this.bOldalUpDown = new System.Windows.Forms.NumericUpDown();
            this.cOldalLabel = new System.Windows.Forms.Label();
            this.bOldalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aOldalUpDown = new System.Windows.Forms.NumericUpDown();
            this.kocka_RB = new System.Windows.Forms.RadioButton();
            this.teglaTest_RB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.testAtloResultLabel = new System.Windows.Forms.Label();
            this.felszinResultLabel = new System.Windows.Forms.Label();
            this.terfogatResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOldalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOldalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldalUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.cOldalUpDown);
            this.groupBox1.Controls.Add(this.bOldalUpDown);
            this.groupBox1.Controls.Add(this.cOldalLabel);
            this.groupBox1.Controls.Add(this.bOldalLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aOldalUpDown);
            this.groupBox1.Controls.Add(this.kocka_RB);
            this.groupBox1.Controls.Add(this.teglaTest_RB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Téglatest / Kocka adatai";
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(32, 180);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(161, 47);
            this.computeButton.TabIndex = 4;
            this.computeButton.Text = "Számítás";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // cOldalUpDown
            // 
            this.cOldalUpDown.DecimalPlaces = 1;
            this.cOldalUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cOldalUpDown.Location = new System.Drawing.Point(113, 137);
            this.cOldalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cOldalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cOldalUpDown.Name = "cOldalUpDown";
            this.cOldalUpDown.Size = new System.Drawing.Size(120, 29);
            this.cOldalUpDown.TabIndex = 8;
            this.cOldalUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cOldalUpDown.ThousandsSeparator = true;
            this.cOldalUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bOldalUpDown
            // 
            this.bOldalUpDown.DecimalPlaces = 1;
            this.bOldalUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bOldalUpDown.Location = new System.Drawing.Point(113, 96);
            this.bOldalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bOldalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bOldalUpDown.Name = "bOldalUpDown";
            this.bOldalUpDown.Size = new System.Drawing.Size(120, 29);
            this.bOldalUpDown.TabIndex = 7;
            this.bOldalUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bOldalUpDown.ThousandsSeparator = true;
            this.bOldalUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cOldalLabel
            // 
            this.cOldalLabel.AutoSize = true;
            this.cOldalLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOldalLabel.Location = new System.Drawing.Point(14, 141);
            this.cOldalLabel.Name = "cOldalLabel";
            this.cOldalLabel.Size = new System.Drawing.Size(60, 19);
            this.cOldalLabel.TabIndex = 6;
            this.cOldalLabel.Text = "C oldal:";
            // 
            // bOldalLabel
            // 
            this.bOldalLabel.AutoSize = true;
            this.bOldalLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOldalLabel.Location = new System.Drawing.Point(15, 100);
            this.bOldalLabel.Name = "bOldalLabel";
            this.bOldalLabel.Size = new System.Drawing.Size(59, 19);
            this.bOldalLabel.TabIndex = 5;
            this.bOldalLabel.Text = "B oldal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "A oldal:";
            // 
            // aOldalUpDown
            // 
            this.aOldalUpDown.DecimalPlaces = 1;
            this.aOldalUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aOldalUpDown.Location = new System.Drawing.Point(113, 53);
            this.aOldalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aOldalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aOldalUpDown.Name = "aOldalUpDown";
            this.aOldalUpDown.Size = new System.Drawing.Size(120, 29);
            this.aOldalUpDown.TabIndex = 3;
            this.aOldalUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aOldalUpDown.ThousandsSeparator = true;
            this.aOldalUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kocka_RB
            // 
            this.kocka_RB.AutoSize = true;
            this.kocka_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kocka_RB.Location = new System.Drawing.Point(165, 19);
            this.kocka_RB.Name = "kocka_RB";
            this.kocka_RB.Size = new System.Drawing.Size(68, 23);
            this.kocka_RB.TabIndex = 2;
            this.kocka_RB.TabStop = true;
            this.kocka_RB.Text = "Kocka";
            this.kocka_RB.UseVisualStyleBackColor = true;
            this.kocka_RB.CheckedChanged += new System.EventHandler(this.kocka_RB_CheckedChanged);
            // 
            // teglaTest_RB
            // 
            this.teglaTest_RB.AutoSize = true;
            this.teglaTest_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teglaTest_RB.Location = new System.Drawing.Point(18, 19);
            this.teglaTest_RB.Name = "teglaTest_RB";
            this.teglaTest_RB.Size = new System.Drawing.Size(89, 23);
            this.teglaTest_RB.TabIndex = 1;
            this.teglaTest_RB.TabStop = true;
            this.teglaTest_RB.Text = "Téglatest";
            this.teglaTest_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.testAtloResultLabel);
            this.groupBox2.Controls.Add(this.felszinResultLabel);
            this.groupBox2.Controls.Add(this.terfogatResultLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(272, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eredmény";
            // 
            // testAtloResultLabel
            // 
            this.testAtloResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testAtloResultLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testAtloResultLabel.Location = new System.Drawing.Point(29, 185);
            this.testAtloResultLabel.Name = "testAtloResultLabel";
            this.testAtloResultLabel.Size = new System.Drawing.Size(150, 34);
            this.testAtloResultLabel.TabIndex = 15;
            this.testAtloResultLabel.Text = "0";
            this.testAtloResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // felszinResultLabel
            // 
            this.felszinResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.felszinResultLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felszinResultLabel.Location = new System.Drawing.Point(24, 112);
            this.felszinResultLabel.Name = "felszinResultLabel";
            this.felszinResultLabel.Size = new System.Drawing.Size(155, 34);
            this.felszinResultLabel.TabIndex = 14;
            this.felszinResultLabel.Text = "0";
            this.felszinResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terfogatResultLabel
            // 
            this.terfogatResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.terfogatResultLabel.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terfogatResultLabel.Location = new System.Drawing.Point(29, 42);
            this.terfogatResultLabel.Name = "terfogatResultLabel";
            this.terfogatResultLabel.Size = new System.Drawing.Size(150, 34);
            this.terfogatResultLabel.TabIndex = 13;
            this.terfogatResultLabel.Text = "0";
            this.terfogatResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Testátló:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Felszín:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Térfogat:";
            // 
            // TeglaTestForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "TeglaTestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Téglatest / Kocka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOldalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOldalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldalUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void computeButton_Click(object sender, System.EventArgs e) {
            double aSide = (double)aOldalUpDown.Value;
            double bSide = (double)bOldalUpDown.Value;
            double cSide = (double)cOldalUpDown.Value;

            if (kocka_RB.Checked) {
                bSide = aSide;
                cSide = aSide;
            }

            felszinResultLabel.Text = getFelszin(aSide,bSide,cSide);
            terfogatResultLabel.Text = getTerfogat(aSide,bSide,cSide);
            testAtloResultLabel.Text = getTestatlo(aSide,bSide,cSide);
        }

        private string getTestatlo(double aSide, double bSide, double cSide) {
            double ta = Math.Sqrt(Math.Pow(aSide,2)+ Math.Pow(bSide, 2)+ Math.Pow(cSide, 2));
            return Math.Round(ta, 3).ToString();
        }

        private string getTerfogat(double aSide, double bSide, double cSide) {
            double tf = aSide*bSide*cSide;
            return Math.Round(tf, 3).ToString();
        }

        private string getFelszin(double aSide, double bSide, double cSide) {
            double fsz = (aSide*bSide + aSide*cSide + bSide*cSide)*2;
            return Math.Round(fsz, 3).ToString();
        }

        private void kocka_RB_CheckedChanged(object sender, System.EventArgs e) {
            if (kocka_RB.Checked) {
                bOldalUpDown.Enabled = false;
                bOldalLabel.Enabled = false;
                cOldalUpDown.Enabled = false;
                cOldalLabel.Enabled = false;
            } else {
                bOldalUpDown.Enabled = true;
                bOldalLabel.Enabled = true;
                cOldalUpDown.Enabled = true;
                cOldalLabel.Enabled = true;
            }
        }
    }
}