
namespace Autoclicker2
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warnLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.milliLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.mouseButtonType = new System.Windows.Forms.ComboBox();
            this.clickTypeBox = new System.Windows.Forms.ComboBox();
            this.mouseButtonLabel = new System.Windows.Forms.Label();
            this.clickTypeLabel = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.NumericUpDown();
            this.minBox = new System.Windows.Forms.NumericUpDown();
            this.secBox = new System.Windows.Forms.NumericUpDown();
            this.milliBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftSwordFarmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wTFHX0RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milliBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(4, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 37);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.warnLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.topMostCheckBox);
            this.panel1.Controls.Add(this.bindingBox);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 155);
            this.panel1.TabIndex = 1;
            // 
            // warnLabel
            // 
            this.warnLabel.AutoSize = true;
            this.warnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.warnLabel.Location = new System.Drawing.Point(48, 127);
            this.warnLabel.Name = "warnLabel";
            this.warnLabel.Size = new System.Drawing.Size(86, 20);
            this.warnLabel.TabIndex = 24;
            this.warnLabel.Text = "Invalid key!";
            this.warnLabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Keybind";
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Checked = true;
            this.topMostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostCheckBox.Location = new System.Drawing.Point(4, 86);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(68, 17);
            this.topMostCheckBox.TabIndex = 21;
            this.topMostCheckBox.Text = "TopMost";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // bindingBox
            // 
            this.bindingBox.Location = new System.Drawing.Point(117, 83);
            this.bindingBox.Name = "bindingBox";
            this.bindingBox.Size = new System.Drawing.Size(60, 20);
            this.bindingBox.TabIndex = 3;
            this.bindingBox.Text = "F6";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(4, 46);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(173, 37);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(97, 8);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(35, 13);
            this.hourLabel.TabIndex = 2;
            this.hourLabel.Text = "Hours";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(97, 36);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(44, 13);
            this.minuteLabel.TabIndex = 4;
            this.minuteLabel.Text = "Minutes";
            // 
            // milliLabel
            // 
            this.milliLabel.AutoSize = true;
            this.milliLabel.Location = new System.Drawing.Point(97, 86);
            this.milliLabel.Name = "milliLabel";
            this.milliLabel.Size = new System.Drawing.Size(64, 13);
            this.milliLabel.TabIndex = 8;
            this.milliLabel.Text = "Milliseconds";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(96, 61);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(49, 13);
            this.secondsLabel.TabIndex = 6;
            this.secondsLabel.Text = "Seconds";
            // 
            // mouseButtonType
            // 
            this.mouseButtonType.FormattingEnabled = true;
            this.mouseButtonType.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.mouseButtonType.Location = new System.Drawing.Point(36, 173);
            this.mouseButtonType.Name = "mouseButtonType";
            this.mouseButtonType.Size = new System.Drawing.Size(121, 21);
            this.mouseButtonType.TabIndex = 11;
            this.mouseButtonType.Text = "Left";
            this.mouseButtonType.SelectedIndexChanged += new System.EventHandler(this.mouseButtonType_SelectedIndexChanged);
            // 
            // clickTypeBox
            // 
            this.clickTypeBox.FormattingEnabled = true;
            this.clickTypeBox.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.clickTypeBox.Location = new System.Drawing.Point(36, 215);
            this.clickTypeBox.Name = "clickTypeBox";
            this.clickTypeBox.Size = new System.Drawing.Size(121, 21);
            this.clickTypeBox.TabIndex = 12;
            this.clickTypeBox.Text = "Single";
            // 
            // mouseButtonLabel
            // 
            this.mouseButtonLabel.AutoSize = true;
            this.mouseButtonLabel.Location = new System.Drawing.Point(55, 157);
            this.mouseButtonLabel.Name = "mouseButtonLabel";
            this.mouseButtonLabel.Size = new System.Drawing.Size(73, 13);
            this.mouseButtonLabel.TabIndex = 13;
            this.mouseButtonLabel.Text = "Mouse Button";
            // 
            // clickTypeLabel
            // 
            this.clickTypeLabel.AutoSize = true;
            this.clickTypeLabel.Location = new System.Drawing.Point(67, 199);
            this.clickTypeLabel.Name = "clickTypeLabel";
            this.clickTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.clickTypeLabel.TabIndex = 14;
            this.clickTypeLabel.Text = "Click type";
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(10, 6);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(81, 20);
            this.hourBox.TabIndex = 15;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(10, 32);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(81, 20);
            this.minBox.TabIndex = 16;
            // 
            // secBox
            // 
            this.secBox.Location = new System.Drawing.Point(11, 58);
            this.secBox.Name = "secBox";
            this.secBox.Size = new System.Drawing.Size(81, 20);
            this.secBox.TabIndex = 17;
            this.secBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // milliBox
            // 
            this.milliBox.Location = new System.Drawing.Point(11, 84);
            this.milliBox.Name = "milliBox";
            this.milliBox.Size = new System.Drawing.Size(81, 20);
            this.milliBox.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(183, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.minecraftSwordFarmerToolStripMenuItem,
            this.wTFHX0RToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // minecraftSwordFarmerToolStripMenuItem
            // 
            this.minecraftSwordFarmerToolStripMenuItem.Name = "minecraftSwordFarmerToolStripMenuItem";
            this.minecraftSwordFarmerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.minecraftSwordFarmerToolStripMenuItem.Text = "Minecraft Sword Farmer";
            this.minecraftSwordFarmerToolStripMenuItem.Click += new System.EventHandler(this.minecraftSwordFarmerToolStripMenuItem_Click);
            // 
            // wTFHX0RToolStripMenuItem
            // 
            this.wTFHX0RToolStripMenuItem.Name = "wTFHX0RToolStripMenuItem";
            this.wTFHX0RToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.wTFHX0RToolStripMenuItem.Text = "WTF H@X0R!?!?!?!?";
            this.wTFHX0RToolStripMenuItem.Click += new System.EventHandler(this.wTFHX0RToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "Info";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hourBox);
            this.panel2.Controls.Add(this.hourLabel);
            this.panel2.Controls.Add(this.minuteLabel);
            this.panel2.Controls.Add(this.secondsLabel);
            this.panel2.Controls.Add(this.milliBox);
            this.panel2.Controls.Add(this.milliLabel);
            this.panel2.Controls.Add(this.secBox);
            this.panel2.Controls.Add(this.minBox);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 114);
            this.panel2.TabIndex = 22;
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spanishToolStripMenuItem.Text = "Español";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(183, 409);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clickTypeLabel);
            this.Controls.Add(this.mouseButtonLabel);
            this.Controls.Add(this.clickTypeBox);
            this.Controls.Add(this.mouseButtonType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bob\'s Autoclicker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milliBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bindingBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label milliLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.ComboBox mouseButtonType;
        private System.Windows.Forms.ComboBox clickTypeBox;
        private System.Windows.Forms.Label mouseButtonLabel;
        private System.Windows.Forms.Label clickTypeLabel;
        private System.Windows.Forms.NumericUpDown hourBox;
        private System.Windows.Forms.NumericUpDown minBox;
        private System.Windows.Forms.NumericUpDown secBox;
        private System.Windows.Forms.NumericUpDown milliBox;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftSwordFarmerToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem wTFHX0RToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label warnLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
    }
}

