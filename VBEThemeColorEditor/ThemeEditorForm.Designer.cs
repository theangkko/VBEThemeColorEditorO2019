namespace VBEThemeColorEditor
{
    partial class ThemeEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeEditorForm));
            this.buttonModifyDLL = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRegistry = new System.Windows.Forms.Button();
            this.buttonModifyDLLauto = new System.Windows.Forms.Button();
            this.ApplyFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.selectedFont = new System.Windows.Forms.TextBox();
            this.labelfont = new System.Windows.Forms.Label();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.ApplyFontSize = new System.Windows.Forms.Button();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.buttonModifyDLLauto1 = new System.Windows.Forms.Button();
            this.linkLabel01 = new System.Windows.Forms.LinkLabel();
            this.statusStrip.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonModifyDLL
            // 
            this.buttonModifyDLL.BackColor = System.Drawing.Color.DarkGray;
            this.buttonModifyDLL.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLL.Location = new System.Drawing.Point(14, 273);
            this.buttonModifyDLL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonModifyDLL.Name = "buttonModifyDLL";
            this.buttonModifyDLL.Size = new System.Drawing.Size(164, 23);
            this.buttonModifyDLL.TabIndex = 0;
            this.buttonModifyDLL.Text = "Apply Theme to VBE.DLL ";
            this.buttonModifyDLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifyDLL.UseVisualStyleBackColor = false;
            this.buttonModifyDLL.Click += new System.EventHandler(this.buttonModifyDLL_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 446);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(321, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(91, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.UpdateColor);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label9);
            this.groupBoxColors.Controls.Add(this.button9);
            this.groupBoxColors.Controls.Add(this.label10);
            this.groupBoxColors.Controls.Add(this.button10);
            this.groupBoxColors.Controls.Add(this.button15);
            this.groupBoxColors.Controls.Add(this.button16);
            this.groupBoxColors.Controls.Add(this.button14);
            this.groupBoxColors.Controls.Add(this.button12);
            this.groupBoxColors.Controls.Add(this.button13);
            this.groupBoxColors.Controls.Add(this.label13);
            this.groupBoxColors.Controls.Add(this.label14);
            this.groupBoxColors.Controls.Add(this.label11);
            this.groupBoxColors.Controls.Add(this.button11);
            this.groupBoxColors.Controls.Add(this.label12);
            this.groupBoxColors.Controls.Add(this.label15);
            this.groupBoxColors.Controls.Add(this.label16);
            this.groupBoxColors.Controls.Add(this.label5);
            this.groupBoxColors.Controls.Add(this.button5);
            this.groupBoxColors.Controls.Add(this.label6);
            this.groupBoxColors.Controls.Add(this.button6);
            this.groupBoxColors.Controls.Add(this.label7);
            this.groupBoxColors.Controls.Add(this.button7);
            this.groupBoxColors.Controls.Add(this.label8);
            this.groupBoxColors.Controls.Add(this.button8);
            this.groupBoxColors.Controls.Add(this.label4);
            this.groupBoxColors.Controls.Add(this.button3);
            this.groupBoxColors.Controls.Add(this.label3);
            this.groupBoxColors.Controls.Add(this.button4);
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Controls.Add(this.button2);
            this.groupBoxColors.Controls.Add(this.label1);
            this.groupBoxColors.Controls.Add(this.button1);
            this.groupBoxColors.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxColors.Location = new System.Drawing.Point(14, 26);
            this.groupBoxColors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxColors.Size = new System.Drawing.Size(293, 242);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Theme colors";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "Color 09";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button9.Location = new System.Drawing.Point(218, 19);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 21);
            this.button9.TabIndex = 33;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "Color 10";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button10.Location = new System.Drawing.Point(218, 45);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 21);
            this.button10.TabIndex = 31;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.UpdateColor);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Red;
            this.button15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button15.Location = new System.Drawing.Point(218, 181);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 21);
            this.button15.TabIndex = 21;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.UpdateColor);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Red;
            this.button16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button16.Location = new System.Drawing.Point(218, 208);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 21);
            this.button16.TabIndex = 19;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.UpdateColor);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Red;
            this.button14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button14.Location = new System.Drawing.Point(218, 154);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 21);
            this.button14.TabIndex = 23;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.UpdateColor);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button12.Location = new System.Drawing.Point(218, 100);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 21);
            this.button12.TabIndex = 27;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.UpdateColor);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Red;
            this.button13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button13.Location = new System.Drawing.Point(218, 127);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 21);
            this.button13.TabIndex = 25;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "Color 13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "Color 14";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 12);
            this.label11.TabIndex = 30;
            this.label11.Text = "Color 11";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button11.Location = new System.Drawing.Point(218, 72);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 21);
            this.button11.TabIndex = 29;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "Color 12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(158, 185);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 22;
            this.label15.Text = "Color 15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 212);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 12);
            this.label16.TabIndex = 20;
            this.label16.Text = "Color 16";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Color 05";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(91, 125);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 21);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Color 06";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(91, 154);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 21);
            this.button6.TabIndex = 15;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Color 07";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(91, 181);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 21);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "Color 08";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Location = new System.Drawing.Point(91, 208);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 21);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color 04";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(91, 72);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 21);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color 03";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(91, 99);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 21);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Color 02";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(91, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 21);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.UpdateColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color 01";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Theme";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // AddRegistry
            // 
            this.AddRegistry.BackColor = System.Drawing.Color.Azure;
            this.AddRegistry.FlatAppearance.BorderSize = 0;
            this.AddRegistry.Location = new System.Drawing.Point(14, 302);
            this.AddRegistry.Name = "AddRegistry";
            this.AddRegistry.Size = new System.Drawing.Size(109, 23);
            this.AddRegistry.TabIndex = 42;
            this.AddRegistry.Text = "Add to Registry";
            this.AddRegistry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRegistry.UseVisualStyleBackColor = false;
            this.AddRegistry.Click += new System.EventHandler(this.AddRegistry_Click);
            // 
            // buttonModifyDLLauto
            // 
            this.buttonModifyDLLauto.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonModifyDLLauto.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLLauto.Location = new System.Drawing.Point(198, 302);
            this.buttonModifyDLLauto.Name = "buttonModifyDLLauto";
            this.buttonModifyDLLauto.Size = new System.Drawing.Size(109, 23);
            this.buttonModifyDLLauto.TabIndex = 43;
            this.buttonModifyDLLauto.Text = "Apply AUTO";
            this.buttonModifyDLLauto.UseVisualStyleBackColor = false;
            this.buttonModifyDLLauto.Click += new System.EventHandler(this.buttonModifyDLLauto_Click);
            // 
            // ApplyFont
            // 
            this.ApplyFont.BackColor = System.Drawing.Color.Azure;
            this.ApplyFont.FlatAppearance.BorderSize = 0;
            this.ApplyFont.Location = new System.Drawing.Point(198, 356);
            this.ApplyFont.Name = "ApplyFont";
            this.ApplyFont.Size = new System.Drawing.Size(109, 23);
            this.ApplyFont.TabIndex = 45;
            this.ApplyFont.Text = "Apply Font";
            this.ApplyFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFont.UseVisualStyleBackColor = false;
            this.ApplyFont.Click += new System.EventHandler(this.ApplyFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.Color.White;
            this.fontDialog1.Font = new System.Drawing.Font("D2Coding", 50F);
            this.fontDialog1.MaxSize = 200;
            this.fontDialog1.MinSize = 50;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // selectedFont
            // 
            this.selectedFont.Location = new System.Drawing.Point(105, 356);
            this.selectedFont.Name = "selectedFont";
            this.selectedFont.Size = new System.Drawing.Size(87, 21);
            this.selectedFont.TabIndex = 47;
            this.selectedFont.Text = "D2Coding";
            this.selectedFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelfont
            // 
            this.labelfont.AutoSize = true;
            this.labelfont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelfont.Location = new System.Drawing.Point(13, 361);
            this.labelfont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfont.Name = "labelfont";
            this.labelfont.Size = new System.Drawing.Size(38, 12);
            this.labelfont.TabIndex = 35;
            this.labelfont.Text = "FONT";
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFontSize.Location = new System.Drawing.Point(12, 393);
            this.labelFontSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(69, 12);
            this.labelFontSize.TabIndex = 48;
            this.labelFontSize.Text = "FONT SIZE";
            // 
            // ApplyFontSize
            // 
            this.ApplyFontSize.BackColor = System.Drawing.Color.Azure;
            this.ApplyFontSize.FlatAppearance.BorderSize = 0;
            this.ApplyFontSize.Location = new System.Drawing.Point(198, 388);
            this.ApplyFontSize.Name = "ApplyFontSize";
            this.ApplyFontSize.Size = new System.Drawing.Size(109, 23);
            this.ApplyFontSize.TabIndex = 49;
            this.ApplyFontSize.Text = "Apply Font Size";
            this.ApplyFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyFontSize.UseVisualStyleBackColor = false;
            this.ApplyFontSize.Click += new System.EventHandler(this.ApplyFontSize_Click);
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Location = new System.Drawing.Point(105, 390);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(87, 21);
            this.textBoxFontSize.TabIndex = 50;
            this.textBoxFontSize.Text = "12";
            this.textBoxFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFontSize.TextChanged += new System.EventHandler(this.textBoxFontSize_TextChanged);
            // 
            // buttonModifyDLLauto1
            // 
            this.buttonModifyDLLauto1.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonModifyDLLauto1.FlatAppearance.BorderSize = 0;
            this.buttonModifyDLLauto1.Location = new System.Drawing.Point(198, 274);
            this.buttonModifyDLLauto1.Name = "buttonModifyDLLauto1";
            this.buttonModifyDLLauto1.Size = new System.Drawing.Size(109, 51);
            this.buttonModifyDLLauto1.TabIndex = 51;
            this.buttonModifyDLLauto1.Text = "Apply AUTO";
            this.buttonModifyDLLauto1.UseVisualStyleBackColor = false;
            this.buttonModifyDLLauto1.Click += new System.EventHandler(this.buttonModifyDLLauto1_Click);
            // 
            // linkLabel01
            // 
            this.linkLabel01.AutoSize = true;
            this.linkLabel01.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel01.Location = new System.Drawing.Point(103, 424);
            this.linkLabel01.Name = "linkLabel01";
            this.linkLabel01.Size = new System.Drawing.Size(184, 12);
            this.linkLabel01.TabIndex = 52;
            this.linkLabel01.TabStop = true;
            this.linkLabel01.Text = "Link to D2Coding Font webpage";
            this.linkLabel01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel01_LinkClicked);
            // 
            // ThemeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(321, 468);
            this.Controls.Add(this.linkLabel01);
            this.Controls.Add(this.buttonModifyDLLauto1);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.ApplyFontSize);
            this.Controls.Add(this.labelFontSize);
            this.Controls.Add(this.labelfont);
            this.Controls.Add(this.selectedFont);
            this.Controls.Add(this.ApplyFont);
            this.Controls.Add(this.AddRegistry);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonModifyDLL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ThemeEditorForm";
            this.Text = "VBE Theme Editor (O2019)";
            this.Load += new System.EventHandler(this.ThemeEditorForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyDLL;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddRegistry;
        private System.Windows.Forms.Button buttonModifyDLLauto;
        private System.Windows.Forms.Button ApplyFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox selectedFont;
        private System.Windows.Forms.Label labelfont;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Button ApplyFontSize;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.Button buttonModifyDLLauto1;
        private System.Windows.Forms.LinkLabel linkLabel01;
    }
}

