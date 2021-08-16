
namespace SkyBeat
{
    partial class frmMainGameForm
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
            this.pbArtist = new System.Windows.Forms.PictureBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.lblMainGameHeading1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArtist
            // 
            this.pbArtist.Location = new System.Drawing.Point(12, 111);
            this.pbArtist.Name = "pbArtist";
            this.pbArtist.Size = new System.Drawing.Size(200, 150);
            this.pbArtist.TabIndex = 0;
            this.pbArtist.TabStop = false;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.Location = new System.Drawing.Point(378, 105);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(55, 23);
            this.cb1.TabIndex = 1;
            this.cb1.Text = "Pop";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // lblMainGameHeading1
            // 
            this.lblMainGameHeading1.AutoSize = true;
            this.lblMainGameHeading1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainGameHeading1.Location = new System.Drawing.Point(8, 9);
            this.lblMainGameHeading1.Name = "lblMainGameHeading1";
            this.lblMainGameHeading1.Size = new System.Drawing.Size(77, 21);
            this.lblMainGameHeading1.TabIndex = 2;
            this.lblMainGameHeading1.Text = "SkyBeat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyBeat.Properties.Resources.Music_Notes;
            this.pictureBox1.Location = new System.Drawing.Point(168, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(209, 50);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(140, 19);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Timer \"00 : 00 : 21\"";
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.Location = new System.Drawing.Point(378, 143);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(63, 23);
            this.cb2.TabIndex = 5;
            this.cb2.Text = "Rock";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3.Location = new System.Drawing.Point(378, 181);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(68, 23);
            this.cb3.TabIndex = 6;
            this.cb3.Text = "Metal";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb4.Location = new System.Drawing.Point(378, 219);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(85, 23);
            this.cb4.TabIndex = 7;
            this.cb4.Text = "Country";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5.Location = new System.Drawing.Point(378, 259);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(85, 23);
            this.cb5.TabIndex = 8;
            this.cb5.Text = "Hip Hop";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // frmMainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMainGameHeading1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.pbArtist);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "frmMainGameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArtist;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label lblMainGameHeading1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
    }
}