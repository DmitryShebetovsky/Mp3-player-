namespace Player
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.PlayList = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.SystemColors.MenuText;
            this.PlayList.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.Location = new System.Drawing.Point(-1, -1);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(485, 199);
            this.PlayList.TabIndex = 0;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            this.PlayList.DoubleClick += new System.EventHandler(this.PlayList_DoubleClick);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.Color.Green;
            this.Add.Location = new System.Drawing.Point(12, 214);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "добавить музыку";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remove.ForeColor = System.Drawing.Color.Crimson;
            this.Remove.Location = new System.Drawing.Point(126, 214);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(92, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "удалить музыку";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.Location = new System.Drawing.Point(238, 214);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(107, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "сохранить плейлист";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Load.ForeColor = System.Drawing.Color.Green;
            this.Load.Location = new System.Drawing.Point(364, 214);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(107, 23);
            this.Load.TabIndex = 4;
            this.Load.Text = "открыть плейлист";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // SoundList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PlayList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoundList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плейлист";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}