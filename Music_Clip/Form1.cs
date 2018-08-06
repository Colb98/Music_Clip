using LedControllerWS2801;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace Music_Clip
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        bool load = true;
        bool pic_load = false;
        bool song_load = false;
        string song_path;
        string pic_path;
        MyPlayer player = new MyPlayer();
        Analyzer analyzer;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            
            BassNet.Registration("naruvssasu@gmail.com", "2X143820152222");

            analyzer = new Analyzer(pb1, pb2, spectrum1, comboBox1);

            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Enabled = true;

            timer.Tick += Timer_Tick;
            label1.Text = label2.Text = "";

            btn_exit.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, Color.White);
            btn_exit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);

            btn_mini.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, Color.White);
            btn_mini.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);

            btn_back.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, Color.White);
            btn_back.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (load)
                Opacity += 0.01;
            if (Opacity == 100)
                load = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Multiselect = false;
            open1.Filter = "Image|*.jpg;*.png";
            open1.RestoreDirectory = true;
            
            if(open1.ShowDialog() == DialogResult.OK)
            {
                pic_path = open1.FileName;
                pic_load = true;
                label1.Text = "OK";
            }

            if (song_load && pic_load)
                btn_play.Enabled = true;
        }

        private void btn_song_Click(object sender, EventArgs e)
        {
            OpenFileDialog open1 = new OpenFileDialog();
            open1.Multiselect = false;
            open1.Filter = "Music|*.mp3;*.flac";
            open1.RestoreDirectory = true;

            if (open1.ShowDialog() == DialogResult.OK)
            {
                song_path = open1.FileName;
                song_load = true;
                label2.Text = "OK";
            }

            if (song_load && pic_load)
                btn_play.Enabled = true;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Width = 0;
            elementHost3.Visible = true;
            btn_play.Visible = false;
            btn_song.Visible = false;
            btn_pic.Visible = false;
            button1.Visible = true;
            label1.Visible = label2.Visible = false;
            btn_back.Visible = true;
            this.BackgroundImage = new Bitmap(pic_path);
            
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;

            //Graphics graphic = this.CreateGraphics();
            //Pen pen = new Pen(Color.White, 3);
            //graphic.DrawRectangle(pen, 85, 640, 1110, 35);
            //graphic.Dispose();

            player.Open(song_path);
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 10;
            timer.Tick += Timer_Tick1;            
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(player.player.Position.Ticks * 1100.0 / player.duration.Ticks);
            if (val > 1100)
                val = 1100;

            panel1.Width = val;
            label3.Text = val.ToString() + "\n" + player.Position().Ticks.ToString() + "\n" + player.duration.Ticks.ToString();
        }
        
        private void Stop()
        {
            this.BackColor = Color.FromArgb(100,100,100);
            this.BackgroundImage = null;
            panel1.Visible = !true;
            elementHost3.Visible = !true;
            btn_play.Visible = !false;
            btn_song.Visible = !false;
            btn_pic.Visible = !false;
            button1.Visible = !true;
            label1.Visible = label2.Visible = !false;
            btn_back.Visible = !true;

            player.player.Stop();
            analyzer.DisplayEnable = false;
            analyzer.Enable = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
