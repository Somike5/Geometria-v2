using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class KorForm : Form {
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label terulletResultLabel;
        private Label keruletResultLabel;
        private Label label7;
        private Label label6;
        private RadioButton atmero_RB;
        private RadioButton sugar_RB;
        private NumericUpDown korAdatUpDown;
        private Button computeButton;
        private Form1 mainForm;

        public KorForm(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }

        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.korAdatUpDown = new System.Windows.Forms.NumericUpDown();
            this.atmero_RB = new System.Windows.Forms.RadioButton();
            this.sugar_RB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.terulletResultLabel = new System.Windows.Forms.Label();
            this.keruletResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korAdatUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.korAdatUpDown);
            this.groupBox1.Controls.Add(this.atmero_RB);
            this.groupBox1.Controls.Add(this.sugar_RB);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Kör paraméterei";
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(316, 89);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(161, 47);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Számítás";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // korAdatUpDown
            // 
            this.korAdatUpDown.DecimalPlaces = 1;
            this.korAdatUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korAdatUpDown.Location = new System.Drawing.Point(357, 39);
            this.korAdatUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.korAdatUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.korAdatUpDown.Name = "korAdatUpDown";
            this.korAdatUpDown.Size = new System.Drawing.Size(120, 29);
            this.korAdatUpDown.TabIndex = 2;
            this.korAdatUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.korAdatUpDown.ThousandsSeparator = true;
            this.korAdatUpDown.Value = new decimal(new int[] {
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
            this.atmero_RB.Size = new System.Drawing.Size(213, 23);
            this.atmero_RB.TabIndex = 1;
            this.atmero_RB.TabStop = true;
            this.atmero_RB.Text = "A Kör átmérőjét adom meg";
            this.atmero_RB.UseVisualStyleBackColor = true;
            // 
            // sugar_RB
            // 
            this.sugar_RB.AutoSize = true;
            this.sugar_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugar_RB.Location = new System.Drawing.Point(24, 30);
            this.sugar_RB.Name = "sugar_RB";
            this.sugar_RB.Size = new System.Drawing.Size(200, 23);
            this.sugar_RB.TabIndex = 0;
            this.sugar_RB.TabStop = true;
            this.sugar_RB.Text = "A Kör sugarát adom meg";
            this.sugar_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.terulletResultLabel);
            this.groupBox3.Controls.Add(this.keruletResultLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eredmény";
            // 
            // terulletResultLabel
            // 
            this.terulletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.terulletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terulletResultLabel.Location = new System.Drawing.Point(336, 20);
            this.terulletResultLabel.Name = "terulletResultLabel";
            this.terulletResultLabel.Size = new System.Drawing.Size(168, 34);
            this.terulletResultLabel.TabIndex = 3;
            this.terulletResultLabel.Text = "0";
            this.terulletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keruletResultLabel
            // 
            this.keruletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.keruletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keruletResultLabel.Location = new System.Drawing.Point(86, 20);
            this.keruletResultLabel.Name = "keruletResultLabel";
            this.keruletResultLabel.Size = new System.Drawing.Size(165, 34);
            this.keruletResultLabel.TabIndex = 2;
            this.keruletResultLabel.Text = "0";
            this.keruletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Terület:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kerület:";
            // 
            // KorForm
            // 
            this.ClientSize = new System.Drawing.Size(528, 243);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "KorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kör számítások";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korAdatUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void computeButton_Click(object sender, System.EventArgs e) {
            double adat = (double)korAdatUpDown.Value;
            double sugar = 0.0;
            if (atmero_RB.Checked) {
                sugar = adat / 2;
            } else {
                sugar = adat;
            }
            keruletResultLabel.Text = getKerulet(sugar);
            terulletResultLabel.Text = getTerulet(sugar);
        }

        private string getKerulet(double sugar) {
            double k = 2 * sugar * Math.PI;
            return Math.Round(k, 2).ToString();
        }

        private string getTerulet(double sugar) {
            double t = sugar * sugar * Math.PI;
            return Math.Round(t, 2).ToString();
        }
    }
}