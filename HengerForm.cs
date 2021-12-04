using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class HengerForm : Form {
        private GroupBox groupBox1;
        private Button computeButton;
        private NumericUpDown hengerAdatUpDown;
        private RadioButton atmero_RB;
        private RadioButton sugar_RB;
        private NumericUpDown magassag_UpDown;
        private GroupBox groupBox3;
        private Label feluletResultLabel;
        private Label terfogatResultLabel;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label palast_ResultLabel;
        private Label label1;
        private Form1 mainForm;

        public HengerForm(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }

        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.magassag_UpDown = new System.Windows.Forms.NumericUpDown();
            this.computeButton = new System.Windows.Forms.Button();
            this.hengerAdatUpDown = new System.Windows.Forms.NumericUpDown();
            this.atmero_RB = new System.Windows.Forms.RadioButton();
            this.sugar_RB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.palast_ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feluletResultLabel = new System.Windows.Forms.Label();
            this.terfogatResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magassag_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hengerAdatUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.magassag_UpDown);
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.hengerAdatUpDown);
            this.groupBox1.Controls.Add(this.atmero_RB);
            this.groupBox1.Controls.Add(this.sugar_RB);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Henger paraméterei";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Magasság:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "sugár / átmérő:";
            // 
            // magassag_UpDown
            // 
            this.magassag_UpDown.DecimalPlaces = 1;
            this.magassag_UpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.magassag_UpDown.Location = new System.Drawing.Point(178, 139);
            this.magassag_UpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.magassag_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.magassag_UpDown.Name = "magassag_UpDown";
            this.magassag_UpDown.Size = new System.Drawing.Size(125, 29);
            this.magassag_UpDown.TabIndex = 4;
            this.magassag_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.magassag_UpDown.ThousandsSeparator = true;
            this.magassag_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(75, 192);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(161, 47);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Számítás";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // hengerAdatUpDown
            // 
            this.hengerAdatUpDown.DecimalPlaces = 1;
            this.hengerAdatUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hengerAdatUpDown.Location = new System.Drawing.Point(178, 88);
            this.hengerAdatUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hengerAdatUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hengerAdatUpDown.Name = "hengerAdatUpDown";
            this.hengerAdatUpDown.Size = new System.Drawing.Size(125, 29);
            this.hengerAdatUpDown.TabIndex = 2;
            this.hengerAdatUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hengerAdatUpDown.ThousandsSeparator = true;
            this.hengerAdatUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // atmero_RB
            // 
            this.atmero_RB.AutoSize = true;
            this.atmero_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmero_RB.Location = new System.Drawing.Point(24, 59);
            this.atmero_RB.Name = "atmero_RB";
            this.atmero_RB.Size = new System.Drawing.Size(225, 23);
            this.atmero_RB.TabIndex = 1;
            this.atmero_RB.TabStop = true;
            this.atmero_RB.Text = "Az alap átmérőjét adom meg";
            this.atmero_RB.UseVisualStyleBackColor = true;
            // 
            // sugar_RB
            // 
            this.sugar_RB.AutoSize = true;
            this.sugar_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugar_RB.Location = new System.Drawing.Point(24, 30);
            this.sugar_RB.Name = "sugar_RB";
            this.sugar_RB.Size = new System.Drawing.Size(212, 23);
            this.sugar_RB.TabIndex = 0;
            this.sugar_RB.TabStop = true;
            this.sugar_RB.Text = "Az alap sugarát adom meg";
            this.sugar_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.palast_ResultLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.feluletResultLabel);
            this.groupBox3.Controls.Add(this.terfogatResultLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(317, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 253);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eredmény";
            // 
            // palast_ResultLabel
            // 
            this.palast_ResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.palast_ResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palast_ResultLabel.Location = new System.Drawing.Point(50, 177);
            this.palast_ResultLabel.Name = "palast_ResultLabel";
            this.palast_ResultLabel.Size = new System.Drawing.Size(183, 34);
            this.palast_ResultLabel.TabIndex = 6;
            this.palast_ResultLabel.Text = "0";
            this.palast_ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palást:";
            // 
            // feluletResultLabel
            // 
            this.feluletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feluletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feluletResultLabel.Location = new System.Drawing.Point(50, 108);
            this.feluletResultLabel.Name = "feluletResultLabel";
            this.feluletResultLabel.Size = new System.Drawing.Size(183, 34);
            this.feluletResultLabel.TabIndex = 3;
            this.feluletResultLabel.Text = "0";
            this.feluletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terfogatResultLabel
            // 
            this.terfogatResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.terfogatResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terfogatResultLabel.Location = new System.Drawing.Point(47, 52);
            this.terfogatResultLabel.Name = "terfogatResultLabel";
            this.terfogatResultLabel.Size = new System.Drawing.Size(186, 34);
            this.terfogatResultLabel.TabIndex = 2;
            this.terfogatResultLabel.Text = "0";
            this.terfogatResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Felszín";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Térfogat:";
            // 
            // HengerForm
            // 
            this.ClientSize = new System.Drawing.Size(574, 275);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "HengerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Henger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magassag_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hengerAdatUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void computeButton_Click(object sender, System.EventArgs e) {
            double rd = (double)hengerAdatUpDown.Value;
            if (atmero_RB.Checked) {
                rd = rd * 0.5;
            }
            double mag = (double)magassag_UpDown.Value;

            //double alapKerulet = getAlapKerulet(rd);
            //double alapTerulet = getAlapTerulet(rd);
            terfogatResultLabel.Text = getTerfogat(rd, mag);
            double palastFelszin = getPalastFelszin(rd, mag);
            feluletResultLabel.Text = getFelszin(rd, mag, palastFelszin);
            palast_ResultLabel.Text = Math.Round(palastFelszin, 2).ToString();

        }

        private string getFelszin(double rd, double mag, double palastFelszin) {
            return Math.Round(getAlapTerulet(rd) * 2 + palastFelszin, 2).ToString();
        }

        private string getTerfogat(double rd, double mag) {
            return Math.Round((getAlapTerulet(rd) * mag), 2).ToString();
        }

        private double getPalastFelszin(double rd, double mag) {
            return (getAlapKerulet(rd)) * mag;
        }

        private double getAlapTerulet(double sugar) {
            double t = Math.Pow(sugar, 2) * Math.PI;
            return t;
        }

        private double getAlapKerulet(double sugar) {
            return sugar * 2 * Math.PI;
        }
    }
}