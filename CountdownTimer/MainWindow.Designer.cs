namespace CountdownTimer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.valign_group = new System.Windows.Forms.GroupBox();
            this.vcustom_px = new System.Windows.Forms.NumericUpDown();
            this.vcustom = new System.Windows.Forms.RadioButton();
            this.bottom = new System.Windows.Forms.RadioButton();
            this.middle = new System.Windows.Forms.RadioButton();
            this.top = new System.Windows.Forms.RadioButton();
            this.halign_group = new System.Windows.Forms.GroupBox();
            this.hcustom_px = new System.Windows.Forms.NumericUpDown();
            this.hcustom = new System.Windows.Forms.RadioButton();
            this.right = new System.Windows.Forms.RadioButton();
            this.centre = new System.Windows.Forms.RadioButton();
            this.left = new System.Windows.Forms.RadioButton();
            this.screensGroup = new System.Windows.Forms.GroupBox();
            this.textGroup = new System.Windows.Forms.GroupBox();
            this.post_text = new System.Windows.Forms.TextBox();
            this.pre_text = new System.Windows.Forms.TextBox();
            this.post_text_opt = new System.Windows.Forms.CheckBox();
            this.pre_text_opt = new System.Windows.Forms.CheckBox();
            this.text_countUntil = new System.Windows.Forms.DateTimePicker();
            this.text_countFrom = new System.Windows.Forms.NumericUpDown();
            this.radio_countUntil = new System.Windows.Forms.RadioButton();
            this.radio_countFrom = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.font_group = new System.Windows.Forms.GroupBox();
            this.bgTransparent = new System.Windows.Forms.CheckBox();
            this.bgColour = new System.Windows.Forms.Button();
            this.borderColour = new System.Windows.Forms.Button();
            this.borderWidth = new System.Windows.Forms.NumericUpDown();
            this.label_borderwidth = new System.Windows.Forms.Label();
            this.font_button = new System.Windows.Forms.Button();
            this.fontColour = new System.Windows.Forms.Button();
            this.font_preview = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.end_group = new System.Windows.Forms.GroupBox();
            this.onEnd_flash_seconds = new System.Windows.Forms.NumericUpDown();
            this.onEnd_flash = new System.Windows.Forms.CheckBox();
            this.onEnd_quit = new System.Windows.Forms.CheckBox();
            this.colourDialog1 = new System.Windows.Forms.ColorDialog();
            this.quitButton = new System.Windows.Forms.Button();
            this.valign_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vcustom_px)).BeginInit();
            this.halign_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hcustom_px)).BeginInit();
            this.textGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_countFrom)).BeginInit();
            this.font_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).BeginInit();
            this.end_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onEnd_flash_seconds)).BeginInit();
            this.SuspendLayout();
            // 
            // valign_group
            // 
            this.valign_group.Controls.Add(this.vcustom_px);
            this.valign_group.Controls.Add(this.vcustom);
            this.valign_group.Controls.Add(this.bottom);
            this.valign_group.Controls.Add(this.middle);
            this.valign_group.Controls.Add(this.top);
            this.valign_group.Location = new System.Drawing.Point(13, 13);
            this.valign_group.Name = "valign_group";
            this.valign_group.Size = new System.Drawing.Size(144, 125);
            this.valign_group.TabIndex = 0;
            this.valign_group.TabStop = false;
            this.valign_group.Text = "Vertical Layout";
            // 
            // vcustom_px
            // 
            this.vcustom_px.Location = new System.Drawing.Point(73, 91);
            this.vcustom_px.Name = "vcustom_px";
            this.vcustom_px.Size = new System.Drawing.Size(56, 20);
            this.vcustom_px.TabIndex = 5;
            // 
            // vcustom
            // 
            this.vcustom.AutoSize = true;
            this.vcustom.Location = new System.Drawing.Point(7, 92);
            this.vcustom.Name = "vcustom";
            this.vcustom.Size = new System.Drawing.Size(60, 17);
            this.vcustom.TabIndex = 3;
            this.vcustom.TabStop = true;
            this.vcustom.Text = "Custom";
            this.vcustom.UseVisualStyleBackColor = true;
            this.vcustom.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // bottom
            // 
            this.bottom.AutoSize = true;
            this.bottom.Location = new System.Drawing.Point(7, 68);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(58, 17);
            this.bottom.TabIndex = 2;
            this.bottom.TabStop = true;
            this.bottom.Text = "Bottom";
            this.bottom.UseVisualStyleBackColor = true;
            this.bottom.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // middle
            // 
            this.middle.AutoSize = true;
            this.middle.Location = new System.Drawing.Point(7, 44);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(56, 17);
            this.middle.TabIndex = 1;
            this.middle.TabStop = true;
            this.middle.Text = "Middle";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.Location = new System.Drawing.Point(7, 20);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(44, 17);
            this.top.TabIndex = 0;
            this.top.TabStop = true;
            this.top.Text = "Top";
            this.top.UseVisualStyleBackColor = true;
            this.top.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // halign_group
            // 
            this.halign_group.Controls.Add(this.hcustom_px);
            this.halign_group.Controls.Add(this.hcustom);
            this.halign_group.Controls.Add(this.right);
            this.halign_group.Controls.Add(this.centre);
            this.halign_group.Controls.Add(this.left);
            this.halign_group.Location = new System.Drawing.Point(163, 13);
            this.halign_group.Name = "halign_group";
            this.halign_group.Size = new System.Drawing.Size(144, 125);
            this.halign_group.TabIndex = 1;
            this.halign_group.TabStop = false;
            this.halign_group.Text = "Horizontal Layout";
            // 
            // hcustom_px
            // 
            this.hcustom_px.Location = new System.Drawing.Point(74, 91);
            this.hcustom_px.Name = "hcustom_px";
            this.hcustom_px.Size = new System.Drawing.Size(56, 20);
            this.hcustom_px.TabIndex = 4;
            // 
            // hcustom
            // 
            this.hcustom.AutoSize = true;
            this.hcustom.Location = new System.Drawing.Point(7, 92);
            this.hcustom.Name = "hcustom";
            this.hcustom.Size = new System.Drawing.Size(60, 17);
            this.hcustom.TabIndex = 3;
            this.hcustom.TabStop = true;
            this.hcustom.Text = "Custom";
            this.hcustom.UseVisualStyleBackColor = true;
            this.hcustom.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // right
            // 
            this.right.AutoSize = true;
            this.right.Location = new System.Drawing.Point(7, 68);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(50, 17);
            this.right.TabIndex = 2;
            this.right.TabStop = true;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // centre
            // 
            this.centre.AutoSize = true;
            this.centre.Location = new System.Drawing.Point(7, 44);
            this.centre.Name = "centre";
            this.centre.Size = new System.Drawing.Size(56, 17);
            this.centre.TabIndex = 1;
            this.centre.TabStop = true;
            this.centre.Text = "Centre";
            this.centre.UseVisualStyleBackColor = true;
            this.centre.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(7, 20);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(43, 17);
            this.left.TabIndex = 0;
            this.left.TabStop = true;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // screensGroup
            // 
            this.screensGroup.Location = new System.Drawing.Point(313, 12);
            this.screensGroup.Name = "screensGroup";
            this.screensGroup.Size = new System.Drawing.Size(189, 126);
            this.screensGroup.TabIndex = 2;
            this.screensGroup.TabStop = false;
            this.screensGroup.Text = "Screen";
            // 
            // textGroup
            // 
            this.textGroup.Controls.Add(this.post_text);
            this.textGroup.Controls.Add(this.pre_text);
            this.textGroup.Controls.Add(this.post_text_opt);
            this.textGroup.Controls.Add(this.pre_text_opt);
            this.textGroup.Controls.Add(this.text_countUntil);
            this.textGroup.Controls.Add(this.text_countFrom);
            this.textGroup.Controls.Add(this.radio_countUntil);
            this.textGroup.Controls.Add(this.radio_countFrom);
            this.textGroup.Location = new System.Drawing.Point(13, 145);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(213, 122);
            this.textGroup.TabIndex = 3;
            this.textGroup.TabStop = false;
            this.textGroup.Text = "Timer Text";
            // 
            // post_text
            // 
            this.post_text.Location = new System.Drawing.Point(85, 87);
            this.post_text.Multiline = true;
            this.post_text.Name = "post_text";
            this.post_text.Size = new System.Drawing.Size(113, 20);
            this.post_text.TabIndex = 7;
            // 
            // pre_text
            // 
            this.pre_text.Location = new System.Drawing.Point(93, 18);
            this.pre_text.Multiline = true;
            this.pre_text.Name = "pre_text";
            this.pre_text.Size = new System.Drawing.Size(105, 20);
            this.pre_text.TabIndex = 6;
            // 
            // post_text_opt
            // 
            this.post_text_opt.AutoSize = true;
            this.post_text_opt.Location = new System.Drawing.Point(7, 87);
            this.post_text_opt.Name = "post_text_opt";
            this.post_text_opt.Size = new System.Drawing.Size(71, 17);
            this.post_text_opt.TabIndex = 5;
            this.post_text_opt.Text = "Text after";
            this.post_text_opt.UseVisualStyleBackColor = true;
            this.post_text_opt.CheckStateChanged += new System.EventHandler(this.ValidateForm);
            // 
            // pre_text_opt
            // 
            this.pre_text_opt.AutoSize = true;
            this.pre_text_opt.Location = new System.Drawing.Point(7, 20);
            this.pre_text_opt.Name = "pre_text_opt";
            this.pre_text_opt.Size = new System.Drawing.Size(80, 17);
            this.pre_text_opt.TabIndex = 4;
            this.pre_text_opt.Text = "Text before";
            this.pre_text_opt.UseVisualStyleBackColor = true;
            this.pre_text_opt.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // text_countUntil
            // 
            this.text_countUntil.CustomFormat = "hh:mm tt";
            this.text_countUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.text_countUntil.Location = new System.Drawing.Point(87, 63);
            this.text_countUntil.Name = "text_countUntil";
            this.text_countUntil.ShowUpDown = true;
            this.text_countUntil.Size = new System.Drawing.Size(111, 20);
            this.text_countUntil.TabIndex = 3;
            // 
            // text_countFrom
            // 
            this.text_countFrom.Location = new System.Drawing.Point(109, 40);
            this.text_countFrom.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.text_countFrom.Name = "text_countFrom";
            this.text_countFrom.Size = new System.Drawing.Size(40, 20);
            this.text_countFrom.TabIndex = 2;
            // 
            // radio_countUntil
            // 
            this.radio_countUntil.AutoSize = true;
            this.radio_countUntil.Location = new System.Drawing.Point(6, 63);
            this.radio_countUntil.Name = "radio_countUntil";
            this.radio_countUntil.Size = new System.Drawing.Size(75, 17);
            this.radio_countUntil.TabIndex = 1;
            this.radio_countUntil.TabStop = true;
            this.radio_countUntil.Text = "Count until";
            this.radio_countUntil.UseVisualStyleBackColor = true;
            this.radio_countUntil.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // radio_countFrom
            // 
            this.radio_countFrom.AutoSize = true;
            this.radio_countFrom.Location = new System.Drawing.Point(6, 40);
            this.radio_countFrom.Name = "radio_countFrom";
            this.radio_countFrom.Size = new System.Drawing.Size(189, 17);
            this.radio_countFrom.TabIndex = 0;
            this.radio_countFrom.TabStop = true;
            this.radio_countFrom.Text = "Count down from                minutes";
            this.radio_countFrom.UseVisualStyleBackColor = true;
            this.radio_countFrom.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(361, 286);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(145, 48);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // font_group
            // 
            this.font_group.Controls.Add(this.bgTransparent);
            this.font_group.Controls.Add(this.bgColour);
            this.font_group.Controls.Add(this.borderColour);
            this.font_group.Controls.Add(this.borderWidth);
            this.font_group.Controls.Add(this.label_borderwidth);
            this.font_group.Controls.Add(this.font_button);
            this.font_group.Controls.Add(this.fontColour);
            this.font_group.Controls.Add(this.font_preview);
            this.font_group.Location = new System.Drawing.Point(232, 144);
            this.font_group.Name = "font_group";
            this.font_group.Size = new System.Drawing.Size(270, 134);
            this.font_group.TabIndex = 5;
            this.font_group.TabStop = false;
            this.font_group.Text = "Text Font";
            // 
            // bgTransparent
            // 
            this.bgTransparent.AutoSize = true;
            this.bgTransparent.Location = new System.Drawing.Point(78, 102);
            this.bgTransparent.Name = "bgTransparent";
            this.bgTransparent.Size = new System.Drawing.Size(101, 17);
            this.bgTransparent.TabIndex = 8;
            this.bgTransparent.Text = "No Background";
            this.bgTransparent.UseVisualStyleBackColor = true;
            this.bgTransparent.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // bgColour
            // 
            this.bgColour.Location = new System.Drawing.Point(185, 98);
            this.bgColour.Name = "bgColour";
            this.bgColour.Size = new System.Drawing.Size(79, 23);
            this.bgColour.TabIndex = 10;
            this.bgColour.Text = "Background";
            this.bgColour.UseVisualStyleBackColor = true;
            this.bgColour.Click += new System.EventHandler(this.bgColour_Click);
            // 
            // borderColour
            // 
            this.borderColour.Location = new System.Drawing.Point(185, 11);
            this.borderColour.Name = "borderColour";
            this.borderColour.Size = new System.Drawing.Size(79, 23);
            this.borderColour.TabIndex = 9;
            this.borderColour.Text = "Border Colour";
            this.borderColour.UseVisualStyleBackColor = true;
            this.borderColour.Click += new System.EventHandler(this.borderColour_Click);
            // 
            // borderWidth
            // 
            this.borderWidth.Location = new System.Drawing.Point(81, 11);
            this.borderWidth.Name = "borderWidth";
            this.borderWidth.Size = new System.Drawing.Size(97, 20);
            this.borderWidth.TabIndex = 8;
            // 
            // label_borderwidth
            // 
            this.label_borderwidth.AutoSize = true;
            this.label_borderwidth.Location = new System.Drawing.Point(6, 16);
            this.label_borderwidth.Name = "label_borderwidth";
            this.label_borderwidth.Size = new System.Drawing.Size(69, 13);
            this.label_borderwidth.TabIndex = 3;
            this.label_borderwidth.Text = "Border Width";
            // 
            // font_button
            // 
            this.font_button.Location = new System.Drawing.Point(185, 69);
            this.font_button.Name = "font_button";
            this.font_button.Size = new System.Drawing.Size(79, 23);
            this.font_button.TabIndex = 1;
            this.font_button.Text = "Change font";
            this.font_button.UseVisualStyleBackColor = true;
            this.font_button.Click += new System.EventHandler(this.font_button_Click);
            // 
            // fontColour
            // 
            this.fontColour.Location = new System.Drawing.Point(185, 40);
            this.fontColour.Name = "fontColour";
            this.fontColour.Size = new System.Drawing.Size(79, 23);
            this.fontColour.TabIndex = 2;
            this.fontColour.Text = "Font colour";
            this.fontColour.UseVisualStyleBackColor = true;
            this.fontColour.Click += new System.EventHandler(this.foreColour_Click);
            // 
            // font_preview
            // 
            this.font_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font_preview.Location = new System.Drawing.Point(6, 37);
            this.font_preview.Name = "font_preview";
            this.font_preview.ReadOnly = true;
            this.font_preview.Size = new System.Drawing.Size(172, 47);
            this.font_preview.TabIndex = 0;
            this.font_preview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(280, 309);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // end_group
            // 
            this.end_group.Controls.Add(this.onEnd_flash_seconds);
            this.end_group.Controls.Add(this.onEnd_flash);
            this.end_group.Controls.Add(this.onEnd_quit);
            this.end_group.Location = new System.Drawing.Point(13, 274);
            this.end_group.Name = "end_group";
            this.end_group.Size = new System.Drawing.Size(200, 65);
            this.end_group.TabIndex = 7;
            this.end_group.TabStop = false;
            this.end_group.Text = "Finally";
            // 
            // onEnd_flash_seconds
            // 
            this.onEnd_flash_seconds.Location = new System.Drawing.Point(90, 18);
            this.onEnd_flash_seconds.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.onEnd_flash_seconds.Name = "onEnd_flash_seconds";
            this.onEnd_flash_seconds.Size = new System.Drawing.Size(39, 20);
            this.onEnd_flash_seconds.TabIndex = 2;
            // 
            // onEnd_flash
            // 
            this.onEnd_flash.AutoSize = true;
            this.onEnd_flash.Location = new System.Drawing.Point(6, 19);
            this.onEnd_flash.Name = "onEnd_flash";
            this.onEnd_flash.Size = new System.Drawing.Size(174, 17);
            this.onEnd_flash.TabIndex = 0;
            this.onEnd_flash.Text = "Flash text for                seconds";
            this.onEnd_flash.UseVisualStyleBackColor = true;
            this.onEnd_flash.CheckedChanged += new System.EventHandler(this.ValidateForm);
            // 
            // onEnd_quit
            // 
            this.onEnd_quit.AutoSize = true;
            this.onEnd_quit.Location = new System.Drawing.Point(6, 42);
            this.onEnd_quit.Name = "onEnd_quit";
            this.onEnd_quit.Size = new System.Drawing.Size(99, 17);
            this.onEnd_quit.TabIndex = 1;
            this.onEnd_quit.Text = "Quit application";
            this.onEnd_quit.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(219, 309);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(55, 23);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "Exit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 346);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.end_group);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.font_group);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textGroup);
            this.Controls.Add(this.screensGroup);
            this.Controls.Add(this.halign_group);
            this.Controls.Add(this.valign_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Tag = "";
            this.Text = "Countdown Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.valign_group.ResumeLayout(false);
            this.valign_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vcustom_px)).EndInit();
            this.halign_group.ResumeLayout(false);
            this.halign_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hcustom_px)).EndInit();
            this.textGroup.ResumeLayout(false);
            this.textGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_countFrom)).EndInit();
            this.font_group.ResumeLayout(false);
            this.font_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).EndInit();
            this.end_group.ResumeLayout(false);
            this.end_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onEnd_flash_seconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox valign_group;
        private System.Windows.Forms.NumericUpDown vcustom_px;
        private System.Windows.Forms.RadioButton vcustom;
        private System.Windows.Forms.RadioButton bottom;
        private System.Windows.Forms.RadioButton middle;
        private System.Windows.Forms.RadioButton top;
        private System.Windows.Forms.GroupBox halign_group;
        private System.Windows.Forms.NumericUpDown hcustom_px;
        private System.Windows.Forms.RadioButton hcustom;
        private System.Windows.Forms.RadioButton right;
        private System.Windows.Forms.RadioButton centre;
        private System.Windows.Forms.RadioButton left;
        private System.Windows.Forms.GroupBox screensGroup;
        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DateTimePicker text_countUntil;
        private System.Windows.Forms.NumericUpDown text_countFrom;
        private System.Windows.Forms.RadioButton radio_countUntil;
        private System.Windows.Forms.RadioButton radio_countFrom;
        private System.Windows.Forms.GroupBox font_group;
        private System.Windows.Forms.TextBox post_text;
        private System.Windows.Forms.TextBox pre_text;
        private System.Windows.Forms.CheckBox post_text_opt;
        private System.Windows.Forms.CheckBox pre_text_opt;
        private System.Windows.Forms.TextBox font_preview;
        private System.Windows.Forms.Button font_button;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox end_group;
        private System.Windows.Forms.CheckBox onEnd_flash;
        private System.Windows.Forms.CheckBox onEnd_quit;
        private System.Windows.Forms.Button fontColour;
        private System.Windows.Forms.ColorDialog colourDialog1;
        private System.Windows.Forms.NumericUpDown borderWidth;
        private System.Windows.Forms.Label label_borderwidth;
        private System.Windows.Forms.Button borderColour;
        private System.Windows.Forms.Button bgColour;
        private System.Windows.Forms.CheckBox bgTransparent;
        private System.Windows.Forms.NumericUpDown onEnd_flash_seconds;
        private System.Windows.Forms.Button quitButton;
    }
}

