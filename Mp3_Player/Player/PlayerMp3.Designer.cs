namespace Player
{
    partial class Pl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pl));
            this.SoundBar = new System.Windows.Forms.TrackBar();
            this.TimeBar = new System.Windows.Forms.TrackBar();
            this.Name = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxVisual = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._next = new System.Windows.Forms.Button();
            this._stop = new System.Windows.Forms.Button();
            this._pause = new System.Windows.Forms.Button();
            this._play = new System.Windows.Forms.Button();
            this._prev = new System.Windows.Forms.Button();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SoundBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // SoundBar
            // 
            this.SoundBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SoundBar.Location = new System.Drawing.Point(332, 177);
            this.SoundBar.Maximum = 100;
            this.SoundBar.Name = "SoundBar";
            this.SoundBar.Size = new System.Drawing.Size(110, 45);
            this.SoundBar.TabIndex = 5;
            this.SoundBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SoundBar.Value = 50;
            this.SoundBar.Scroll += new System.EventHandler(this.SoundBar_Scroll);
            // 
            // TimeBar
            // 
            this.TimeBar.LargeChange = 10;
            this.TimeBar.Location = new System.Drawing.Point(12, 28);
            this.TimeBar.Maximum = 100;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(440, 45);
            this.TimeBar.SmallChange = 5;
            this.TimeBar.TabIndex = 6;
            this.TimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeBar.Scroll += new System.EventHandler(this.TimeBar_Scroll);
            this.TimeBar.ValueChanged += new System.EventHandler(this.TimeBar_ValueChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(58, 151);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(0, 13);
            this.Name.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.ForeColor = System.Drawing.SystemColors.Control;
            this.Time.Location = new System.Drawing.Point(458, 28);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(34, 13);
            this.Time.TabIndex = 8;
            this.Time.Text = "00:00";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBox1.Location = new System.Drawing.Point(169, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Плейлист";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxVisual
            // 
            this.checkBoxVisual.AutoSize = true;
            this.checkBoxVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVisual.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBoxVisual.Location = new System.Drawing.Point(16, 228);
            this.checkBoxVisual.Name = "checkBoxVisual";
            this.checkBoxVisual.Size = new System.Drawing.Size(135, 20);
            this.checkBoxVisual.TabIndex = 13;
            this.checkBoxVisual.Text = "Визуализация";
            this.checkBoxVisual.UseVisualStyleBackColor = true;
            this.checkBoxVisual.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(313, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(448, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Track name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Player.Properties.Resources.Amazing_phone_wallpapers_H6X;
            this.pictureBox1.Location = new System.Drawing.Point(181, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 147);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // _next
            // 
            this._next.BackColor = System.Drawing.SystemColors.Highlight;
            this._next.Image = ((System.Drawing.Image)(resources.GetObject("_next.Image")));
            this._next.Location = new System.Drawing.Point(251, 177);
            this._next.Name = "_next";
            this._next.Size = new System.Drawing.Size(39, 35);
            this._next.TabIndex = 4;
            this._next.UseVisualStyleBackColor = false;
            this._next.Click += new System.EventHandler(this._next_Click);
            // 
            // _stop
            // 
            this._stop.BackColor = System.Drawing.Color.Crimson;
            this._stop.Image = ((System.Drawing.Image)(resources.GetObject("_stop.Image")));
            this._stop.Location = new System.Drawing.Point(193, 177);
            this._stop.Name = "_stop";
            this._stop.Size = new System.Drawing.Size(40, 35);
            this._stop.TabIndex = 3;
            this._stop.UseVisualStyleBackColor = false;
            this._stop.Click += new System.EventHandler(this._stop_Click);
            // 
            // _pause
            // 
            this._pause.BackColor = System.Drawing.Color.Fuchsia;
            this._pause.Image = ((System.Drawing.Image)(resources.GetObject("_pause.Image")));
            this._pause.Location = new System.Drawing.Point(135, 177);
            this._pause.Name = "_pause";
            this._pause.Size = new System.Drawing.Size(40, 35);
            this._pause.TabIndex = 2;
            this._pause.UseVisualStyleBackColor = false;
            this._pause.Click += new System.EventHandler(this._pause_Click);
            // 
            // _play
            // 
            this._play.BackColor = System.Drawing.Color.ForestGreen;
            this._play.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._play.Image = ((System.Drawing.Image)(resources.GetObject("_play.Image")));
            this._play.Location = new System.Drawing.Point(75, 177);
            this._play.Name = "_play";
            this._play.Size = new System.Drawing.Size(41, 35);
            this._play.TabIndex = 1;
            this._play.UseVisualStyleBackColor = false;
            this._play.Click += new System.EventHandler(this._play_Click);
            // 
            // _prev
            // 
            this._prev.BackColor = System.Drawing.Color.DodgerBlue;
            this._prev.Image = ((System.Drawing.Image)(resources.GetObject("_prev.Image")));
            this._prev.Location = new System.Drawing.Point(16, 177);
            this._prev.Name = "_prev";
            this._prev.Size = new System.Drawing.Size(42, 35);
            this._prev.TabIndex = 0;
            this._prev.UseVisualStyleBackColor = false;
            this._prev.Click += new System.EventHandler(this._prev_Click);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.Image = global::Player.Properties.Resources.q;
            this.pictureBoxGif.InitialImage = global::Player.Properties.Resources.q;
            this.pictureBoxGif.Location = new System.Drawing.Point(-8, -165);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(507, 486);
            this.pictureBoxGif.TabIndex = 10;
            this.pictureBoxGif.TabStop = false;
            this.pictureBoxGif.Click += new System.EventHandler(this.pictureBoxGif_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(391, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(436, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(492, 257);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxVisual);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.SoundBar);
            this.Controls.Add(this._next);
            this.Controls.Add(this._stop);
            this.Controls.Add(this._pause);
            this.Controls.Add(this._play);
            this.Controls.Add(this._prev);
            this.Controls.Add(this.pictureBoxGif);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
          //  this.Name = "Pl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mp3 Плеер";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Pl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoundBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _prev;
        private System.Windows.Forms.Button _play;
        private System.Windows.Forms.Button _pause;
        private System.Windows.Forms.Button _stop;
        private System.Windows.Forms.Button _next;
        private System.Windows.Forms.TrackBar SoundBar;
        private System.Windows.Forms.TrackBar TimeBar;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private System.Windows.Forms.CheckBox checkBoxVisual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
    }
}

