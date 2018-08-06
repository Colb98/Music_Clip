namespace Music_Clip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pic = new System.Windows.Forms.Button();
            this.btn_song = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_mini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new AudioSpectrumAdvance.Spectrum();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.pb2 = new LedControllerWS2801.PB();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pb1 = new LedControllerWS2801.PB();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Enabled = false;
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_play.FlatAppearance.BorderSize = 2;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(530, 270);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(220, 65);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pic
            // 
            this.btn_pic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pic.FlatAppearance.BorderSize = 2;
            this.btn_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pic.Location = new System.Drawing.Point(530, 358);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(220, 65);
            this.btn_pic.TabIndex = 0;
            this.btn_pic.Text = "BG IMG";
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // btn_song
            // 
            this.btn_song.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_song.FlatAppearance.BorderSize = 2;
            this.btn_song.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_song.Location = new System.Drawing.Point(530, 446);
            this.btn_song.Name = "btn_song";
            this.btn_song.Size = new System.Drawing.Size(220, 65);
            this.btn_song.TabIndex = 0;
            this.btn_song.Text = "Song";
            this.btn_song.UseVisualStyleBackColor = true;
            this.btn_song.Click += new System.EventHandler(this.btn_song_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("000 AnimeAce3 [TeddyBear]", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1202, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(50, 50);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.BackColor = System.Drawing.Color.Transparent;
            this.btn_mini.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Font = new System.Drawing.Font("000 AnimeAce3 [TeddyBear]", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mini.Location = new System.Drawing.Point(1130, 12);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(50, 50);
            this.btn_mini.TabIndex = 0;
            this.btn_mini.Text = "_";
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(796, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("000 Blambot Pro Lite TB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(796, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 57);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(90, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 25);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(82, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1116, 41);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("000 AnimeAce3 [TeddyBear]", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.TabIndex = 0;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1106, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "label3";
            this.label4.Visible = false;
            // 
            // elementHost3
            // 
            this.elementHost3.BackColor = System.Drawing.Color.Transparent;
            this.elementHost3.Location = new System.Drawing.Point(90, 459);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(1100, 172);
            this.elementHost3.TabIndex = 6;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Visible = false;
            this.elementHost3.Child = this.spectrum1;
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(517, 202);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(200, 100);
            this.elementHost2.TabIndex = 5;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Visible = false;
            this.elementHost2.Child = this.pb2;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(302, 202);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Visible = false;
            this.elementHost1.Child = this.pb1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mini);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.elementHost3);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_song);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.btn_play);
            this.Font = new System.Drawing.Font("000 AnimeAce3 [TeddyBear]", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Awesome Music Clip";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.Button btn_song;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LedControllerWS2801.PB pb1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LedControllerWS2801.PB pb2;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private AudioSpectrumAdvance.Spectrum spectrum1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label4;
    }
}

