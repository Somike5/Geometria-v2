using System;
using System.Windows.Forms;

namespace Geometriav2 {
    internal class HaromszogWindow : Form {
        private GroupBox groupBox1;
        private NumericUpDown aOldalField;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private NumericUpDown cOldalField;
        private NumericUpDown bOldalField;
        private NumericUpDown magassagfield;
        private NumericUpDown alapField;
        private Button computeV1Button;
        private Button computeV2Button;
        private GroupBox groupBox3;
        private Label terulletResultLabel;
        private Label keruletResultLabel;
        private Label label7;
        private Label label6;
        private TrackBar trackBar1;
        private Label label9;
        private Label label8;
        public ToolTip trackToolTip;
        private System.ComponentModel.IContainer components;
        private Form1 mainForm;

        public HaromszogWindow(Form1 form1) {
            mainForm = form1;
            InitializeComponent();
            ShowDialog();
        }


        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaromszogWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.computeV1Button = new System.Windows.Forms.Button();
            this.cOldalField = new System.Windows.Forms.NumericUpDown();
            this.bOldalField = new System.Windows.Forms.NumericUpDown();
            this.aOldalField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.computeV2Button = new System.Windows.Forms.Button();
            this.magassagfield = new System.Windows.Forms.NumericUpDown();
            this.alapField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.terulletResultLabel = new System.Windows.Forms.Label();
            this.keruletResultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOldalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOldalField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldalField)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magassagfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alapField)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computeV1Button);
            this.groupBox1.Controls.Add(this.cOldalField);
            this.groupBox1.Controls.Add(this.bOldalField);
            this.groupBox1.Controls.Add(this.aOldalField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok megadása V1";
            // 
            // computeV1Button
            // 
            this.computeV1Button.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeV1Button.Location = new System.Drawing.Point(44, 144);
            this.computeV1Button.Name = "computeV1Button";
            this.computeV1Button.Size = new System.Drawing.Size(154, 38);
            this.computeV1Button.TabIndex = 6;
            this.computeV1Button.Text = "Számítás";
            this.computeV1Button.UseVisualStyleBackColor = true;
            this.computeV1Button.Click += new System.EventHandler(this.computeV1Button_Click);
            // 
            // cOldalField
            // 
            this.cOldalField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cOldalField.DecimalPlaces = 1;
            this.cOldalField.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOldalField.Location = new System.Drawing.Point(117, 97);
            this.cOldalField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cOldalField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cOldalField.Name = "cOldalField";
            this.cOldalField.Size = new System.Drawing.Size(107, 29);
            this.cOldalField.TabIndex = 5;
            this.cOldalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cOldalField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bOldalField
            // 
            this.bOldalField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bOldalField.DecimalPlaces = 1;
            this.bOldalField.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOldalField.Location = new System.Drawing.Point(117, 62);
            this.bOldalField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bOldalField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bOldalField.Name = "bOldalField";
            this.bOldalField.Size = new System.Drawing.Size(107, 29);
            this.bOldalField.TabIndex = 4;
            this.bOldalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bOldalField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // aOldalField
            // 
            this.aOldalField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aOldalField.DecimalPlaces = 1;
            this.aOldalField.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOldalField.Location = new System.Drawing.Point(117, 28);
            this.aOldalField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.aOldalField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aOldalField.Name = "aOldalField";
            this.aOldalField.Size = new System.Drawing.Size(107, 29);
            this.aOldalField.TabIndex = 3;
            this.aOldalField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aOldalField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "C oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "B oldal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "A oldal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.computeV2Button);
            this.groupBox2.Controls.Add(this.magassagfield);
            this.groupBox2.Controls.Add(this.alapField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adatok megdása V2";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(335, 103);
            this.label9.MaximumSize = new System.Drawing.Size(70, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 45);
            this.label9.TabIndex = 10;
            this.label9.Text = "50% (egyenlő oldalú)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.MaximumSize = new System.Drawing.Size(60, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 45);
            this.label8.TabIndex = 9;
            this.label8.Text = "0% (derék- szögű)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(61, 99);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(268, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 25;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_MouseHover);
            this.trackBar1.MouseHover += new System.EventHandler(this.trackBar1_MouseHover);
            // 
            // computeV2Button
            // 
            this.computeV2Button.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeV2Button.Location = new System.Drawing.Point(122, 144);
            this.computeV2Button.Name = "computeV2Button";
            this.computeV2Button.Size = new System.Drawing.Size(154, 38);
            this.computeV2Button.TabIndex = 7;
            this.computeV2Button.Text = "Számítás";
            this.computeV2Button.UseVisualStyleBackColor = true;
            this.computeV2Button.Click += new System.EventHandler(this.computeV2Button_Click);
            // 
            // magassagfield
            // 
            this.magassagfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magassagfield.DecimalPlaces = 1;
            this.magassagfield.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magassagfield.Location = new System.Drawing.Point(219, 62);
            this.magassagfield.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.magassagfield.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.magassagfield.Name = "magassagfield";
            this.magassagfield.Size = new System.Drawing.Size(150, 29);
            this.magassagfield.TabIndex = 7;
            this.magassagfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.magassagfield.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // alapField
            // 
            this.alapField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alapField.DecimalPlaces = 1;
            this.alapField.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alapField.Location = new System.Drawing.Point(219, 27);
            this.alapField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alapField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alapField.Name = "alapField";
            this.alapField.Size = new System.Drawing.Size(150, 29);
            this.alapField.TabIndex = 6;
            this.alapField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.alapField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Magasság:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Leghosszabb oldal (alap):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.terulletResultLabel);
            this.groupBox3.Controls.Add(this.keruletResultLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eredmény";
            // 
            // terulletResultLabel
            // 
            this.terulletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.terulletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terulletResultLabel.Location = new System.Drawing.Point(410, 20);
            this.terulletResultLabel.Name = "terulletResultLabel";
            this.terulletResultLabel.Size = new System.Drawing.Size(208, 34);
            this.terulletResultLabel.TabIndex = 3;
            this.terulletResultLabel.Text = "0";
            this.terulletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keruletResultLabel
            // 
            this.keruletResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.keruletResultLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keruletResultLabel.Location = new System.Drawing.Point(103, 20);
            this.keruletResultLabel.Name = "keruletResultLabel";
            this.keruletResultLabel.Size = new System.Drawing.Size(207, 34);
            this.keruletResultLabel.TabIndex = 2;
            this.keruletResultLabel.Text = "0";
            this.keruletResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Terület:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kerület:";
            // 
            // trackToolTip
            // 
            this.trackToolTip.AutoPopDelay = 5000;
            this.trackToolTip.InitialDelay = 500;
            this.trackToolTip.IsBalloon = true;
            this.trackToolTip.OwnerDraw = true;
            this.trackToolTip.ReshowDelay = 10;
            this.trackToolTip.ShowAlways = true;
            this.trackToolTip.StripAmpersands = true;
            this.trackToolTip.UseAnimation = false;
            this.trackToolTip.UseFading = false;
            // 
            // HaromszogWindow
            // 
            this.ClientSize = new System.Drawing.Size(669, 284);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HaromszogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Háromszög";
            this.Load += new System.EventHandler(this.HaromszogWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOldalField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOldalField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOldalField)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magassagfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alapField)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void computeV1Button_Click(object sender, System.EventArgs e) {
            double a = (double)aOldalField.Value;
            double b = (double)bOldalField.Value;
            double c = (double)cOldalField.Value;
            Console.WriteLine("Eredmény: " + (a+b+c));
            if ((a + b) > c) {
                if ((a + c) > b) {
                    if ((b+c)>a) {
                        // Ez valós háromszög, Lehet számolni
                        keruletResultLabel.Text = (a+b+c).ToString();
                        terulletResultLabel.Text = getTerulet(a, b, c);
                    } else {
                        //Az A oldal túl kicsi
                        showErrorMessage("Az \"A\"");
                    }
                } else {
                    // A C oldal túl kicsi
                    showErrorMessage("A \"C\"");
                }
            } else {
                // A B oldal túl kicsi
                showErrorMessage("A \"B\"");
            }
        }

        private string getTerulet(double a, double b, double c) {
            //Heron képlettelű
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            return t.ToString();
        }

        

        private void showErrorMessage(String message) {
            MessageBox.Show("Ebből nem lehet háromszöget készíteni mert:\n\n" + message + " oldal értéke túl kicsi!", "Hiba ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void computeV2Button_Click(object sender, System.EventArgs e) {
            double alap = (double)alapField.Value;
            double mag = (double)magassagfield.Value;
            int metszesPont = trackBar1.Value;
            keruletResultLabel.Text = getKerulet(alap, mag, metszesPont);
            terulletResultLabel.Text = getTerulet(alap, mag);

        }

        private string getKerulet(double alap, double mag, int point) {
            // Ha derékszögű a háromszög
            //double a = alap + mag + Math.Sqrt(alap*alap + mag*mag); // 
            
            // Másik módszer, miszerint a magasság két derékszügűre osztja a sima háromszöget:
            double alapPont = point; // A magasságvonal pozíciója az alapvonalon százalékban.
            double a1 = alap - (alap * (alapPont / 100));
            double a2 = alap - a1;
            double b1 = Math.Sqrt((a1 * a1) + (mag * mag));
            double b2 = Math.Sqrt((a2 * a2) + (mag * mag));
            double b = b1 + b2 + alap;
            
            // 50% , vagyis egyenlő oldalú a háromszög
            //double c = alap + (Math.Sqrt(((alap/2)*(alap/2)) + (mag*mag)))*2;
            //Console.WriteLine("point: "+point+"  -- A: " + a + " - B: " + b + " (a1: "+a1+"-a2:"+a2+")- C:" + c + " (alap/2: "+alap/2+")");
            return Math.Round(b,2).ToString();  //+ "\nHa egyenlő oldalú: " + c) ; 
        }

        private string getTerulet(double alap, double mag) {
            double t = 0.5 * alap * mag;
            return Math.Round(t, 2).ToString();
        }

        private void HaromszogWindow_Load(object sender, EventArgs e) {

        }

        private void trackBar1_MouseHover(object sender, EventArgs e) {
            int v = trackBar1.Value;
            trackToolTip.SetToolTip(trackBar1,v+"%");
        }
    }
}