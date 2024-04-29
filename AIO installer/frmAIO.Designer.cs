namespace AIO_installer
{
    partial class frmAIO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAIO));
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPagesteam = new TabPage();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabPage1 = new TabPage();
            cbobits = new ComboBox();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            gpbItem = new GroupBox();
            gpbAbout = new GroupBox();
            linklblSteam = new LinkLabel();
            pictureBox7 = new PictureBox();
            linklblExtremecopy = new LinkLabel();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagesteam.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gpbItem.SuspendLayout();
            gpbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(877, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(52, 24);
            filesToolStripMenuItem.Text = "Files";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagesteam);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(6, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(672, 402);
            tabControl1.TabIndex = 1;
            // 
            // tabPagesteam
            // 
            tabPagesteam.Controls.Add(groupBox1);
            tabPagesteam.Location = new Point(4, 29);
            tabPagesteam.Name = "tabPagesteam";
            tabPagesteam.Padding = new Padding(3);
            tabPagesteam.Size = new Size(664, 369);
            tabPagesteam.TabIndex = 1;
            tabPagesteam.Text = "Steam";
            tabPagesteam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(6, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(172, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(299, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(617, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbobits);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox6);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(664, 369);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Extreme Copy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbobits
            // 
            cbobits.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobits.FormattingEnabled = true;
            cbobits.Items.AddRange(new object[] { "32 Bits", "64 Bits" });
            cbobits.Location = new Point(128, 269);
            cbobits.Name = "cbobits";
            cbobits.Size = new Size(151, 28);
            cbobits.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Location = new Point(323, 238);
            button1.Name = "button1";
            button1.Size = new Size(323, 88);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(22, 238);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(79, 77);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(197, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(449, 192);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(141, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // gpbItem
            // 
            gpbItem.Controls.Add(tabControl1);
            gpbItem.Location = new Point(12, 43);
            gpbItem.Name = "gpbItem";
            gpbItem.Size = new Size(717, 441);
            gpbItem.TabIndex = 3;
            gpbItem.TabStop = false;
            // 
            // gpbAbout
            // 
            gpbAbout.Controls.Add(linklblExtremecopy);
            gpbAbout.Controls.Add(linklblSteam);
            gpbAbout.Controls.Add(pictureBox7);
            gpbAbout.Controls.Add(pictureBox1);
            gpbAbout.Location = new Point(747, 60);
            gpbAbout.Name = "gpbAbout";
            gpbAbout.Size = new Size(118, 424);
            gpbAbout.TabIndex = 4;
            gpbAbout.TabStop = false;
            // 
            // linklblSteam
            // 
            linklblSteam.AutoSize = true;
            linklblSteam.Location = new Point(6, 113);
            linklblSteam.Name = "linklblSteam";
            linklblSteam.Size = new Size(103, 20);
            linklblSteam.TabIndex = 3;
            linklblSteam.TabStop = true;
            linklblSteam.Text = "Steam Official";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(6, 136);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(101, 94);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // linklblExtremecopy
            // 
            linklblExtremecopy.AutoSize = true;
            linklblExtremecopy.Location = new Point(6, 233);
            linklblExtremecopy.Name = "linklblExtremecopy";
            linklblExtremecopy.Size = new Size(101, 20);
            linklblExtremecopy.TabIndex = 3;
            linklblExtremecopy.TabStop = true;
            linklblExtremecopy.Text = "Extreme Copy";
            // 
            // frmAIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 496);
            Controls.Add(gpbAbout);
            Controls.Add(gpbItem);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAIO";
            Text = "AIO installer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagesteam.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gpbItem.ResumeLayout(false);
            gpbAbout.ResumeLayout(false);
            gpbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPagesteam;
        private PictureBox pictureBox1;
        private GroupBox gpbItem;
        private GroupBox gpbAbout;
        private GroupBox groupBox1;
        private TabPage tabPage1;
        private PictureBox pictureBox2;
        private LinkLabel linklblSteam;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button button1;
        private ComboBox cbobits;
        private LinkLabel linklblExtremecopy;
        private PictureBox pictureBox7;
    }
}
