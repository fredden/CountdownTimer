using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class MainForm : Form
    {
        protected Form timerWindow;
        protected CustomLabel timerTextbox;
        protected DateTime endTime;
        protected DateTime endTime_flash;
        protected List<Screen> screens;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                // This function will bring the control window to the front.
                timerClick(null, null);
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add 'screens' to the relevant group
            var s_y = -4;
            screens = new List<Screen>();
            foreach (var s in System.Windows.Forms.Screen.AllScreens)
            {
                var radio = new RadioButton();
                radio.Text = s.DeviceName.ToString();
                s_y += 24; // Move the next control down
                radio.Location = new Point(7, s_y);
                radio.Checked = (0 == screens.Count); // select the first by default
                radio.CheckedChanged += new System.EventHandler(this.ValidateForm);
                screensGroup.Controls.Add(radio);

                var sc = new Screen();
                sc.screen_obj = s;
                sc.radio_obj = radio;
                screens.Add(sc);
            }

            // Set the "count until" time to be the next hour
            var min = System.DateTime.Now.Minute;
            var hour = System.DateTime.Now.Hour;
            do {
                min += 1;
                if (min > 59)
                {
                    hour += 1;
                    min = 0;

                    if (hour > 23)
                    {
                        hour = 0;
                    }
                }
            } while (min != 0);
            text_countUntil.Value = System.DateTime.Parse(hour + ":" + min);

            RestoreSettings();
        }

        private void SaveSettings()
        {
            if (top.Checked)    { Properties.Settings.Default.VerticalAlign = 1; }
            if (middle.Checked) { Properties.Settings.Default.VerticalAlign = 2; }
            if (bottom.Checked) { Properties.Settings.Default.VerticalAlign = 3; }
            if (vcustom.Checked) { Properties.Settings.Default.VerticalAlign = 0; }
            Properties.Settings.Default.Vertical_px = vcustom_px.Value;

            if (left.Checked) { Properties.Settings.Default.HorizontalAlign = 1; }
            if (centre.Checked) { Properties.Settings.Default.HorizontalAlign = 2; }
            if (right.Checked) { Properties.Settings.Default.HorizontalAlign = 3; }
            if (hcustom.Checked) { Properties.Settings.Default.HorizontalAlign = 0; }
            Properties.Settings.Default.Horizontal_px = hcustom_px.Value;

            Properties.Settings.Default.Screen = screens.FindIndex(s => s.isSelected());

            Properties.Settings.Default.CountUntil = radio_countUntil.Checked;
            Properties.Settings.Default.CountFrom = text_countFrom.Value;

            Properties.Settings.Default.Text_before = pre_text_opt.Checked;
            Properties.Settings.Default.Text_after = post_text_opt.Checked;
            Properties.Settings.Default.Text_before_text = pre_text.Text;
            Properties.Settings.Default.Text_after_text = post_text.Text;

            Properties.Settings.Default.end_quit = onEnd_quit.Checked;
            Properties.Settings.Default.end_flash = onEnd_flash.Checked;
            Properties.Settings.Default.end_flash_seconds = onEnd_flash_seconds.Value;

            Properties.Settings.Default.Font = fontDialog1.Font;
            Properties.Settings.Default.BorderWidth = borderWidth.Value;
            Properties.Settings.Default.FontColour = fontColour.BackColor;
            Properties.Settings.Default.BorderColour = borderColour.BackColor;
            Properties.Settings.Default.BackgroundColour = bgColour.BackColor;
            Properties.Settings.Default.BackgroundTransparent = bgTransparent.Checked;

            Properties.Settings.Default.Save();
        }

        private void RestoreSettings()
        {
            screens.ElementAt(Properties.Settings.Default.Screen).radio_obj.Checked = true;
            // Calling 'ValidateForm' here will set the maximum values for the alignment fields.
            ValidateForm(null, null);

            switch (Properties.Settings.Default.VerticalAlign)
            {
                case 1: top.Checked = true; break;
                case 2: middle.Checked = true; break;
                case 3: bottom.Checked = true; break;
                default: vcustom.Checked = true; break;
            }

            try
            {
                vcustom_px.Value = Properties.Settings.Default.Vertical_px;
            }
            catch (ArgumentOutOfRangeException)
            {
                vcustom_px.Value = vcustom_px.Minimum;
            }
            if (vcustom_px.Value == 0) { top.Checked = true; }
            if (vcustom_px.Value == vcustom_px.Maximum / 2) { middle.Checked = true; }
            if (vcustom_px.Value == vcustom_px.Maximum) { bottom.Checked = true; }

            switch (Properties.Settings.Default.HorizontalAlign)
            {
                case 1: left.Checked = true; break;
                case 2: centre.Checked = true; break;
                case 3: right.Checked = true; break;
                default: hcustom.Checked = true; break;
            }

            try
            {
                hcustom_px.Value = Properties.Settings.Default.Horizontal_px;
            }
            catch (ArgumentOutOfRangeException)
            {
                hcustom_px.Value = hcustom_px.Minimum;
            }
            if (hcustom_px.Value == 0) { left.Checked = true; }
            if (hcustom_px.Value == hcustom_px.Maximum / 2) { centre.Checked = true; }
            if (hcustom_px.Value == hcustom_px.Maximum) { right.Checked = true; }

            if (Properties.Settings.Default.CountUntil)
            {
                radio_countUntil.Checked = true;
            } else
            {
                radio_countFrom.Checked = true;
            }
            text_countFrom.Value = Properties.Settings.Default.CountFrom;

            pre_text_opt.Checked = Properties.Settings.Default.Text_before;
            post_text_opt.Checked = Properties.Settings.Default.Text_after;
            pre_text.Text = Properties.Settings.Default.Text_before_text;
            post_text.Text = Properties.Settings.Default.Text_after_text;

            onEnd_quit.Checked = Properties.Settings.Default.end_quit;
            onEnd_flash.Checked = Properties.Settings.Default.end_flash;
            onEnd_flash_seconds.Value = Properties.Settings.Default.end_flash_seconds;

            fontDialog1.Font = Properties.Settings.Default.Font;
            borderWidth.Value = Properties.Settings.Default.BorderWidth;
            borderColour.BackColor = Properties.Settings.Default.BorderColour;
            fontColour.BackColor = Properties.Settings.Default.FontColour;
            bgColour.BackColor = Properties.Settings.Default.BackgroundColour;
            bgTransparent.Checked = Properties.Settings.Default.BackgroundTransparent;

            ValidateForm(null, null);
        }

        private void ValidateForm(object sender, EventArgs e)
        {
            hcustom_px.Enabled = hcustom.Checked;
            vcustom_px.Enabled = vcustom.Checked;
            hcustom_px.Maximum = screens.Find(s => s.isSelected()).screen_obj.Bounds.Width;
            vcustom_px.Maximum = screens.Find(s => s.isSelected()).screen_obj.Bounds.Height;

            if (top.Checked) { vcustom_px.Value = 0; }
            if (middle.Checked) { vcustom_px.Value = vcustom_px.Maximum / 2; }
            if (bottom.Checked) { vcustom_px.Value = vcustom_px.Maximum; }

            if (left.Checked) { hcustom_px.Value = 0; }
            if (centre.Checked) { hcustom_px.Value = hcustom_px.Maximum / 2; }
            if (right.Checked) { hcustom_px.Value = hcustom_px.Maximum; }

            text_countFrom.Enabled = radio_countFrom.Checked;
            text_countUntil.Enabled = radio_countUntil.Checked;
            pre_text.Enabled = pre_text_opt.Checked;
            post_text.Enabled = post_text_opt.Checked;

            // font/colour previews
            var saved = font_preview.Font.Size;
            font_preview.Font = new System.Drawing.Font(fontDialog1.Font.FontFamily, saved);
            fontColour.ForeColor = (PerceivedBrightness(fontColour.BackColor) > 130 ? Color.Black : Color.White);
            borderColour.ForeColor = (PerceivedBrightness(borderColour.BackColor) > 130 ? Color.Black : Color.White);
            bgColour.ForeColor = (PerceivedBrightness(bgColour.BackColor) > 130 ? Color.Black : Color.White);
            bgColour.Enabled = !bgTransparent.Checked;

            if (timerWindow ==null || !timerWindow.Visible)
            {
                font_preview.Text = "15:00";
            }

            onEnd_flash_seconds.Enabled = onEnd_flash.Checked;
        }

        // http://stackoverflow.com/a/2241471
        private int PerceivedBrightness(Color c)
        {
            return (int)Math.Sqrt(
            c.R * c.R * .299 +
            c.G * c.G * .587 +
            c.B * c.B * .114);
        }

        private void font_button_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(this);
            ValidateForm(sender, e);
        }

        private void timerClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            bool top = TopMost;
            TopMost = true;
            BringToFront();
            TopMost = top;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            stopButton_Click(sender, e);
            SaveSettings();

            timerWindow = new Form();
            timerWindow.Click += new System.EventHandler(timerClick);
            timerWindow.AllowTransparency = true;
            timerWindow.AutoSize = true;
            timerWindow.Size = new Size(1, 1);
            timerWindow.MaximizeBox = false;
            timerWindow.MinimizeBox = false;
            timerWindow.ControlBox = false;
            timerWindow.ShowInTaskbar = false;
            timerWindow.FormBorderStyle = FormBorderStyle.None;
            timerWindow.TopMost = true;
            timerWindow.Font = fontDialog1.Font;
            timerWindow.BackColor = bgColour.BackColor;
            if (bgTransparent.Checked) { timerWindow.TransparencyKey = timerWindow.BackColor; }

            var locy = 10;
            if (pre_text_opt.Checked) {
                var pre = newLabel(pre_text.Text, locy);
                timerWindow.Controls.Add(pre);
                locy = pre.Size.Height + 10;
            }

            timerTextbox = newLabel("0:00", locy);
            timerWindow.Controls.Add(timerTextbox);

            if (post_text_opt.Checked)
            {
                var post = newLabel(post_text.Text, timerTextbox.Top + timerTextbox.Size.Height);
                timerWindow.Controls.Add(post);
            }

            if (radio_countFrom.Checked)
            {
                endTime = DateTime.Now
                    .AddMinutes(text_countFrom.Value.Minute)
                    .AddSeconds(text_countFrom.Value.Second);
            } else
            {
                endTime = text_countUntil.Value;
            }
            endTime_flash = endTime.AddSeconds((double)onEnd_flash_seconds.Value);

            // Call the tick function directly to display the window with its correct content, to be positioned next.
            timer1_Tick(null, null);
            int x = (int)hcustom_px.Value;
            int y = (int)vcustom_px.Value;

            // special-casing this isn't great.
            if (centre.Checked) { x -= timerWindow.Width / 2; }
            if (middle.Checked) { y -= timerWindow.Height / 2; }

            if ((x + timerWindow.Width) > hcustom_px.Maximum)
            {
                x = (int)hcustom_px.Maximum - timerWindow.Width;
            }
            if ((y + timerWindow.Height) > vcustom_px.Maximum)
            {
                y = (int)vcustom_px.Maximum - timerWindow.Height;
            }
            x += screens.Find(s => s.isSelected()).screen_obj.Bounds.X;
            y += screens.Find(s => s.isSelected()).screen_obj.Bounds.Y;

            timerWindow.SetDesktopLocation(x, y);

            timer1.Start();
            WindowState = FormWindowState.Minimized;
        }

        private CustomLabel newLabel(String text, int locy)
        {
            var label = new CustomLabel();
            label.Click += new System.EventHandler(timerClick);
            label.AutoSize = true;
            label.Text = text;
            label.Location = new Point(10, locy);
            label.ForeColor = fontColour.BackColor;
            label.OutlineColor = borderColour.BackColor;
            label.OutlineWidth = borderWidth.Value;
            if (centre.Checked) { label.TextAlign = ContentAlignment.TopCenter; }
            if (right.Checked) { label.TextAlign = ContentAlignment.TopRight; }
            return label;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (null != timerWindow)
            {
                timer1.Stop();
                timerWindow.Hide();
                timerWindow = null;
                timerTextbox = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (null == timerTextbox)
            {
                return;
            }

            if (endTime < DateTime.Now)
            {
                // All done. Fire off any selected 'ended' events.
                if (onEnd_flash.Checked)
                {
                    if (endTime_flash > DateTime.Now)
                    {
                        invertColours();
                        return;
                    }
                }
                if (onEnd_quit.Checked)
                {
                    Application.Exit();
                }
                stopButton_Click(sender, e);
                WindowState = FormWindowState.Normal;
                return;
            }

            TimeSpan delta = endTime - DateTime.Now;
            var format = "m\\:ss";
            if (delta >= TimeSpan.FromHours(1))
            {
                format = "h\\:mm\\:ss";
            }
            timerTextbox.Text = delta.ToString(format);
            font_preview.Text = delta.ToString(format);

            if (!timerWindow.Visible)
            {
                timerWindow.Show();
                timerWindow.BringToFront();
            }
        }

        private void invertColours()
        {
            if (null == timerWindow)
            {
                return;
            }
            Color bg = timerTextbox.OutlineColor;
            Color fg = timerTextbox.ForeColor;
            timerTextbox.ForeColor = bg;
            timerTextbox.OutlineColor = fg;
        }

        private void foreColour_Click(object sender, EventArgs e)
        {
            colourDialog1.Color = fontColour.BackColor;
            colourDialog1.ShowDialog();
            fontColour.BackColor = colourDialog1.Color;
            ValidateForm(sender, e);
        }

        private void borderColour_Click(object sender, EventArgs e)
        {
            colourDialog1.Color = borderColour.BackColor;
            colourDialog1.ShowDialog();
            borderColour.BackColor = colourDialog1.Color;
            ValidateForm(sender, e);
        }

        private void bgColour_Click(object sender, EventArgs e)
        {
            colourDialog1.Color = bgColour.BackColor;
            colourDialog1.ShowDialog();
            bgColour.BackColor = colourDialog1.Color;
            ValidateForm(sender, e);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // http://stackoverflow.com/a/19851271
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            OutlineColor = Color.Green;
            OutlineWidth = 2;
        }
        public Color OutlineColor { get; set; }
        public decimal OutlineWidth { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            using (GraphicsPath gp = new GraphicsPath())
            using (Pen outline = new Pen(OutlineColor, (float)(OutlineWidth/10)) { LineJoin = LineJoin.Round })
            using (StringFormat sf = new StringFormat())
            using (Brush foreBrush = new SolidBrush(ForeColor))
            {
                gp.AddString(Text, Font.FontFamily, (int)Font.Style, Font.Size, ClientRectangle, sf);
                e.Graphics.ScaleTransform(1.3f, 1.35f);
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawPath(outline, gp);
                e.Graphics.FillPath(foreBrush, gp);
            }
        }
    }

    public class Screen
    {
        public System.Windows.Forms.Screen screen_obj { get; set; }
        public RadioButton radio_obj { get; set; }
        public bool isSelected()
        {
            return this.radio_obj.Checked;
        }
    }
}
