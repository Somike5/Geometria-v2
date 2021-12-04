using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class TeglalapForm : Form {
        private GroupBox groupBox1;
        private RadioButton negyzet_RB;
        private RadioButton teglalap_RB;
        private GroupBox groupBox2;
        private Label bSide_Lablel;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label kerulet_Label;
        private NumericUpDown aOldal_UpDown;
        private Label atlo_Label;
        private Label terulet_Label;
        private NumericUpDown bOldal_UpDown;
        private Button computeButton;
        private Form1 mainForm;

        public TeglalapForm(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }

        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.bOldal_UpDown = new System.Windows.Forms.NumericUpDown();
            this.aOldal_UpDown = new System.Windows.Forms.NumericUpDown();
            this.bSide_Lablel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.negyzet_RB = new System.Windows.Forms.RadioButton();
            this.teglalap_RB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.atlo_Label = new System.Windows.Forms.Label();
            this.terulet_Label = new System.Windows.Forms.Label();
            this.kerulet_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOldal_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldal_UpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.bOldal_UpDown);
            this.groupBox1.Controls.Add(this.aOldal_UpDown);
            this.groupBox1.Controls.Add(this.bSide_Lablel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.negyzet_RB);
            this.groupBox1.Controls.Add(this.teglalap_RB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok megadása";
            // 
            // computeButton
            // 
            this.computeButton.AutoSize = true;
            this.computeButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.Location = new System.Drawing.Point(66, 165);
            this.computeButton.Margin = new System.Windows.Forms.Padding(10);
            this.computeButton.Name = "computeButton";
            this.computeButton.Padding = new System.Windows.Forms.Padding(10);
            this.computeButton.Size = new System.Drawing.Size(156, 51);
            this.computeButton.TabIndex = 6;
            this.computeButton.Text = "Számítás";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // bOldal_UpDown
            // 
            this.bOldal_UpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOldal_UpDown.DecimalPlaces = 1;
            this.bOldal_UpDown.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOldal_UpDown.Location = new System.Drawing.Point(119, 109);
            this.bOldal_UpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bOldal_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bOldal_UpDown.Name = "bOldal_UpDown";
            this.bOldal_UpDown.Size = new System.Drawing.Size(120, 33);
            this.bOldal_UpDown.TabIndex = 5;
            this.bOldal_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bOldal_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aOldal_UpDown
            // 
            this.aOldal_UpDown.DecimalPlaces = 1;
            this.aOldal_UpDown.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOldal_UpDown.Location = new System.Drawing.Point(119, 59);
            this.aOldal_UpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aOldal_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aOldal_UpDown.Name = "aOldal_UpDown";
            this.aOldal_UpDown.Size = new System.Drawing.Size(120, 33);
            this.aOldal_UpDown.TabIndex = 4;
            this.aOldal_UpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aOldal_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bSide_Lablel
            // 
            this.bSide_Lablel.AutoSize = true;
            this.bSide_Lablel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSide_Lablel.Location = new System.Drawing.Point(6, 111);
            this.bSide_Lablel.Name = "bSide_Lablel";
            this.bSide_Lablel.Size = new System.Drawing.Size(72, 22);
            this.bSide_Lablel.TabIndex = 3;
            this.bSide_Lablel.Text = "B oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "A oldal:";
            // 
            // negyzet_RB
            // 
            this.negyzet_RB.AutoSize = true;
            this.negyzet_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negyzet_RB.Location = new System.Drawing.Point(138, 19);
            this.negyzet_RB.Name = "negyzet_RB";
            this.negyzet_RB.Size = new System.Drawing.Size(84, 23);
            this.negyzet_RB.TabIndex = 1;
            this.negyzet_RB.TabStop = true;
            this.negyzet_RB.Text = "Négyzet";
            this.negyzet_RB.UseVisualStyleBackColor = true;
            this.negyzet_RB.CheckedChanged += new System.EventHandler(this.negyzet_RB_CheckedChanged);
            // 
            // teglalap_RB
            // 
            this.teglalap_RB.AutoSize = true;
            this.teglalap_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teglalap_RB.Location = new System.Drawing.Point(19, 19);
            this.teglalap_RB.Name = "teglalap_RB";
            this.teglalap_RB.Size = new System.Drawing.Size(85, 23);
            this.teglalap_RB.TabIndex = 0;
            this.teglalap_RB.TabStop = true;
            this.teglalap_RB.Text = "Téglalap";
            this.teglalap_RB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.atlo_Label);
            this.groupBox2.Controls.Add(this.terulet_Label);
            this.groupBox2.Controls.Add(this.kerulet_Label);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eredmény";
            // 
            // atlo_Label
            // 
            this.atlo_Label.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atlo_Label.Location = new System.Drawing.Point(15, 194);
            this.atlo_Label.Name = "atlo_Label";
            this.atlo_Label.Size = new System.Drawing.Size(158, 38);
            this.atlo_Label.TabIndex = 9;
            this.atlo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // terulet_Label
            // 
            this.terulet_Label.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terulet_Label.Location = new System.Drawing.Point(21, 121);
            this.terulet_Label.Name = "terulet_Label";
            this.terulet_Label.Size = new System.Drawing.Size(152, 38);
            this.terulet_Label.TabIndex = 8;
            this.terulet_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kerulet_Label
            // 
            this.kerulet_Label.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kerulet_Label.Location = new System.Drawing.Point(15, 42);
            this.kerulet_Label.Name = "kerulet_Label";
            this.kerulet_Label.Size = new System.Drawing.Size(158, 38);
            this.kerulet_Label.TabIndex = 7;
            this.kerulet_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Átló:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Terület:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kerület:";
            // 
            // TeglalapForm
            // 
            this.ClientSize = new System.Drawing.Size(465, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "TeglalapForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Téglalap / Négyzet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOldal_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldal_UpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void negyzet_RB_CheckedChanged(object sender, System.EventArgs e) {
            if (negyzet_RB.Checked) {
                bOldal_UpDown.Enabled = false;
                bSide_Lablel.Enabled = false;
            } else {
                bOldal_UpDown.Enabled = true;
                bSide_Lablel.Enabled = true;
            }
        }

        private void computeButton_Click(object sender, System.EventArgs e) {
            double aSide = (double)aOldal_UpDown.Value;
            double bSide = 0;
            if (negyzet_RB.Checked) {
                bSide = aSide;
            } else {
                bSide = (double)bOldal_UpDown.Value;
            }

            terulet_Label.Text = getTerulet(aSide, bSide);
            kerulet_Label.Text = getKerulet(aSide, bSide);
            atlo_Label.Text = getAtlo(aSide, bSide);
        }

        private string getTerulet(double aSide, double bSide) {
            double t = aSide * bSide;
            return Math.Round(t, 2).ToString();
        }

        private string getKerulet(double aSide, double bSide) {
            double k = aSide*2 + bSide*2;
            return Math.Round(k, 2).ToString();
        }

        private string getAtlo(double aOldal, double bOldal) {
            double atlo = Math.Sqrt(Math.Pow(aOldal, 2) + Math.Pow(bOldal, 2));
            return Math.Round(atlo, 2).ToString();
        }

    }
}