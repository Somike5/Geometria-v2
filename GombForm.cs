using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class GombForm : Form {
        private GroupBox groupBox1;
        private Button computeButton;
        private NumericUpDown gombAdatUpDown;
        private RadioButton atmero_RB;
        private RadioButton sugar_RB;
        private GroupBox groupBox3;
        private Label feluletResultLabel;
        private Label terfogatResultLabel;
        private Label label7;
        private Label label6;
        private Form1 mainForm;

        public GombForm(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }

        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.gombAdatUpDown = new System.Windows.Forms.NumericUpDown();
            this.atmero_RB = new System.Windows.Forms.RadioButton();
            this.sugar_RB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feluletResultLabel = new System.Windows.Forms.Label();
            this.terfogatResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gombAdatUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.gombAdatUpDown);
            this.groupBox1.Controls.Add(this.atmero_RB);
            this.groupBox1.Controls.Add(this.sugar_RB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Gömb paraméterei";
            // 
            // computeButton
            // 
            this.computeButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(308, 87);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(161, 47);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Számítás";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // gombAdatUpDown
            // 
            this.gombAdatUpDown.DecimalPlaces = 1;
            this.gombAdatUpDown.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gombAdatUpDown.Location = new System.Drawing.Point(421, 41);
            this.gombAdatUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gombAdatUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gombAdatUpDown.Name = "gombAdatUpDown";
            this.gombAdatUpDown.Size = new System.Drawing.Size(120, 29);
            this.gombAdatUpDown.TabIndex = 2;
            this.gombAdatUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gombAdatUpDown.ThousandsSeparator = true;
            this.gombAdatUpDown.Value = new decimal(new int[] {
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
            this.atmero_RB.Size = new System.Drawing.Size(232, 23);
            this.atmero_RB.TabIndex = 1;
            this.atmero_RB.TabStop = true;
            this.atmero_RB.Text = "A Gömb átmérőjét adom meg";
            this.atmero_RB.UseVisualStyleBackColor = true;
            // 
            // sugar_RB
            // 
            this.sugar_RB.AutoSize = true;
            this.sugar_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sugar_RB.Location = new System.Drawing.Point(24, 30);
            this.sugar_RB.Name = "sugar_RB";
            this.sugar_RB.Size = new System.Drawing.Size(219, 23);
            this.sugar_RB.TabIndex = 0;
            this.sugar_RB.TabStop = true;
            this.sugar_RB.Text = "A Gömb sugarát adom meg";
            this.sugar_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.feluletResultLabel);
            this.groupBox3.Controls.Add(this.terfogatResultLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eredmény";
            // 
            // feluletResultLabel
            // 
            this.feluletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.feluletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feluletResultLabel.Location = new System.Drawing.Point(373, 21);
            this.feluletResultLabel.Name = "feluletResultLabel";
            this.feluletResultLabel.Size = new System.Drawing.Size(183, 34);
            this.feluletResultLabel.TabIndex = 3;
            this.feluletResultLabel.Text = "0";
            this.feluletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terfogatResultLabel
            // 
            this.terfogatResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.terfogatResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terfogatResultLabel.Location = new System.Drawing.Point(94, 20);
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
            this.label7.Location = new System.Drawing.Point(286, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Felület:";
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
            // GombForm
            // 
            this.ClientSize = new System.Drawing.Size(586, 240);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "GombForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gömb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gombAdatUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void computeButton_Click(object sender, System.EventArgs e) {
            double adat = (double)gombAdatUpDown.Value;
            double sugar = 0.0;
            if (atmero_RB.Checked) {
                sugar = adat / 2;
            } else {
                sugar = adat;
            }
            terfogatResultLabel.Text = getTerfogat(sugar);
            feluletResultLabel.Text = getFelszin(sugar);
        }

        private string getFelszin(double sugar) {
            double fsz = 4 * Math.PI * Math.Pow(sugar, 2);
            return Math.Round(fsz, 2).ToString();
        }

        private string getTerfogat(double sugar) {
            double tf = (4 * Math.PI * Math.Pow(sugar, 3)) / 3;
            return Math.Round(tf, 2).ToString();
        }
    }
}