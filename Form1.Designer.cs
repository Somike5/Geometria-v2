
namespace Geometriav2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.haromszog_RB = new System.Windows.Forms.RadioButton();
            this.teglalap_RB = new System.Windows.Forms.RadioButton();
            this.kor_RB = new System.Windows.Forms.RadioButton();
            this.gomb_RB = new System.Windows.Forms.RadioButton();
            this.teglatest_RB = new System.Windows.Forms.RadioButton();
            this.henger_RB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hengerPanel = new System.Windows.Forms.Panel();
            this.teglatestPanel = new System.Windows.Forms.Panel();
            this.gombPanel = new System.Windows.Forms.Panel();
            this.haromszogPanel = new System.Windows.Forms.Panel();
            this.negyszogPanel = new System.Windows.Forms.Panel();
            this.korPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.MaximumSize = new System.Drawing.Size(630, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válassz, hogy az alábbi geometriai alakzat közül, mely területét, kerületét szere" +
    "tnéd kiszámítani?";
            // 
            // haromszog_RB
            // 
            this.haromszog_RB.AutoSize = true;
            this.haromszog_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haromszog_RB.Location = new System.Drawing.Point(15, 19);
            this.haromszog_RB.Name = "haromszog_RB";
            this.haromszog_RB.Size = new System.Drawing.Size(114, 23);
            this.haromszog_RB.TabIndex = 1;
            this.haromszog_RB.Text = "Háromszög";
            this.haromszog_RB.UseVisualStyleBackColor = true;
            this.haromszog_RB.CheckedChanged += new System.EventHandler(this.haromszog_RB_CheckedChanged);
            // 
            // teglalap_RB
            // 
            this.teglalap_RB.AutoSize = true;
            this.teglalap_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teglalap_RB.Location = new System.Drawing.Point(363, 19);
            this.teglalap_RB.Name = "teglalap_RB";
            this.teglalap_RB.Size = new System.Drawing.Size(169, 23);
            this.teglalap_RB.TabIndex = 2;
            this.teglalap_RB.Text = "Téglalap / négyzet";
            this.teglalap_RB.UseVisualStyleBackColor = true;
            this.teglalap_RB.CheckedChanged += new System.EventHandler(this.teglalap_RB_CheckedChanged);
            // 
            // kor_RB
            // 
            this.kor_RB.AutoSize = true;
            this.kor_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kor_RB.Location = new System.Drawing.Point(15, 131);
            this.kor_RB.Name = "kor_RB";
            this.kor_RB.Size = new System.Drawing.Size(53, 23);
            this.kor_RB.TabIndex = 3;
            this.kor_RB.Text = "Kör";
            this.kor_RB.UseVisualStyleBackColor = true;
            this.kor_RB.CheckedChanged += new System.EventHandler(this.kor_RB_CheckedChanged);
            // 
            // gomb_RB
            // 
            this.gomb_RB.AutoSize = true;
            this.gomb_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomb_RB.Location = new System.Drawing.Point(363, 131);
            this.gomb_RB.Name = "gomb_RB";
            this.gomb_RB.Size = new System.Drawing.Size(73, 23);
            this.gomb_RB.TabIndex = 4;
            this.gomb_RB.Text = "Gömb";
            this.gomb_RB.UseVisualStyleBackColor = true;
            this.gomb_RB.CheckedChanged += new System.EventHandler(this.gomb_RB_CheckedChanged);
            // 
            // teglatest_RB
            // 
            this.teglatest_RB.AutoSize = true;
            this.teglatest_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teglatest_RB.Location = new System.Drawing.Point(15, 232);
            this.teglatest_RB.Name = "teglatest_RB";
            this.teglatest_RB.Size = new System.Drawing.Size(97, 23);
            this.teglatest_RB.TabIndex = 5;
            this.teglatest_RB.Text = "Téglatest";
            this.teglatest_RB.UseVisualStyleBackColor = true;
            this.teglatest_RB.CheckedChanged += new System.EventHandler(this.teglatest_RB_CheckedChanged);
            // 
            // henger_RB
            // 
            this.henger_RB.AutoSize = true;
            this.henger_RB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.henger_RB.Location = new System.Drawing.Point(353, 232);
            this.henger_RB.Name = "henger_RB";
            this.henger_RB.Size = new System.Drawing.Size(83, 23);
            this.henger_RB.TabIndex = 6;
            this.henger_RB.Text = "Henger";
            this.henger_RB.UseVisualStyleBackColor = true;
            this.henger_RB.CheckedChanged += new System.EventHandler(this.henger_RB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haromszog_RB);
            this.groupBox1.Controls.Add(this.hengerPanel);
            this.groupBox1.Controls.Add(this.teglatestPanel);
            this.groupBox1.Controls.Add(this.gombPanel);
            this.groupBox1.Controls.Add(this.henger_RB);
            this.groupBox1.Controls.Add(this.haromszogPanel);
            this.groupBox1.Controls.Add(this.negyszogPanel);
            this.groupBox1.Controls.Add(this.kor_RB);
            this.groupBox1.Controls.Add(this.gomb_RB);
            this.groupBox1.Controls.Add(this.korPanel);
            this.groupBox1.Controls.Add(this.teglatest_RB);
            this.groupBox1.Controls.Add(this.teglalap_RB);
            this.groupBox1.Location = new System.Drawing.Point(10, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 345);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Választható alakzatok";
            // 
            // hengerPanel
            // 
            this.hengerPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_henger;
            this.hengerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hengerPanel.Location = new System.Drawing.Point(422, 261);
            this.hengerPanel.Name = "hengerPanel";
            this.hengerPanel.Size = new System.Drawing.Size(85, 73);
            this.hengerPanel.TabIndex = 12;
            this.hengerPanel.Click += new System.EventHandler(this.hengerPanel_Click);
            // 
            // teglatestPanel
            // 
            this.teglatestPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_teglatest;
            this.teglatestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teglatestPanel.Location = new System.Drawing.Point(51, 261);
            this.teglatestPanel.Name = "teglatestPanel";
            this.teglatestPanel.Size = new System.Drawing.Size(108, 73);
            this.teglatestPanel.TabIndex = 13;
            this.teglatestPanel.Click += new System.EventHandler(this.teglatestPanel_Click);
            // 
            // gombPanel
            // 
            this.gombPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_gomb_v3;
            this.gombPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gombPanel.Location = new System.Drawing.Point(424, 155);
            this.gombPanel.Name = "gombPanel";
            this.gombPanel.Size = new System.Drawing.Size(83, 71);
            this.gombPanel.TabIndex = 11;
            this.gombPanel.Click += new System.EventHandler(this.gombPanel_Click);
            // 
            // haromszogPanel
            // 
            this.haromszogPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_haromszog;
            this.haromszogPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.haromszogPanel.Location = new System.Drawing.Point(51, 48);
            this.haromszogPanel.Name = "haromszogPanel";
            this.haromszogPanel.Size = new System.Drawing.Size(108, 65);
            this.haromszogPanel.TabIndex = 9;
            this.haromszogPanel.Click += new System.EventHandler(this.haromszogPanel_Click);
            // 
            // negyszogPanel
            // 
            this.negyszogPanel.BackColor = System.Drawing.Color.Transparent;
            this.negyszogPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_teglalap;
            this.negyszogPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.negyszogPanel.Location = new System.Drawing.Point(395, 48);
            this.negyszogPanel.Name = "negyszogPanel";
            this.negyszogPanel.Size = new System.Drawing.Size(112, 64);
            this.negyszogPanel.TabIndex = 8;
            this.negyszogPanel.Click += new System.EventHandler(this.negyszogPanel_Click);
            // 
            // korPanel
            // 
            this.korPanel.BackgroundImage = global::Geometriav2.Properties.Resources.geom_kor;
            this.korPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.korPanel.Location = new System.Drawing.Point(85, 155);
            this.korPanel.Name = "korPanel";
            this.korPanel.Size = new System.Drawing.Size(74, 71);
            this.korPanel.TabIndex = 10;
            this.korPanel.Click += new System.EventHandler(this.korPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(57, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gometriai alakzatok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton haromszog_RB;
        private System.Windows.Forms.RadioButton teglalap_RB;
        private System.Windows.Forms.RadioButton kor_RB;
        private System.Windows.Forms.RadioButton gomb_RB;
        private System.Windows.Forms.RadioButton teglatest_RB;
        private System.Windows.Forms.RadioButton henger_RB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel negyszogPanel;
        private System.Windows.Forms.Panel haromszogPanel;
        private System.Windows.Forms.Panel korPanel;
        private System.Windows.Forms.Panel gombPanel;
        private System.Windows.Forms.Panel hengerPanel;
        private System.Windows.Forms.Panel teglatestPanel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

