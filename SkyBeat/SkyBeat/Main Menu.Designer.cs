
namespace SkyBeat
{
    partial class frmMain
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
            this.lblMainHeading2 = new System.Windows.Forms.Label();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.pbGuitar = new System.Windows.Forms.PictureBox();
            this.lblMainHeading3 = new System.Windows.Forms.Label();
            this.lblMainHeading1 = new System.Windows.Forms.Label();
            this.lblRights = new System.Windows.Forms.Label();
            this.lblDesignby = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuitar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainHeading2
            // 
            this.lblMainHeading2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMainHeading2.AutoSize = true;
            this.lblMainHeading2.BackColor = System.Drawing.Color.Black;
            this.lblMainHeading2.Font = new System.Drawing.Font("Harrington", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading2.ForeColor = System.Drawing.Color.White;
            this.lblMainHeading2.Location = new System.Drawing.Point(220, 45);
            this.lblMainHeading2.Name = "lblMainHeading2";
            this.lblMainHeading2.Size = new System.Drawing.Size(220, 47);
            this.lblMainHeading2.TabIndex = 2;
            this.lblMainHeading2.Text = "Main Menu";
            // 
            // btnSingle
            // 
            this.btnSingle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSingle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingle.Location = new System.Drawing.Point(251, 156);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(150, 30);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.Text = "Single Player";
            this.btnSingle.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMulti.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(251, 212);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(150, 30);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "Multiplayer";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // pbGuitar
            // 
            this.pbGuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGuitar.Image = global::SkyBeat.Properties.Resources.Guitar;
            this.pbGuitar.Location = new System.Drawing.Point(228, 133);
            this.pbGuitar.Name = "pbGuitar";
            this.pbGuitar.Size = new System.Drawing.Size(444, 268);
            this.pbGuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGuitar.TabIndex = 6;
            this.pbGuitar.TabStop = false;
            // 
            // lblMainHeading3
            // 
            this.lblMainHeading3.AutoSize = true;
            this.lblMainHeading3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading3.ForeColor = System.Drawing.Color.White;
            this.lblMainHeading3.Location = new System.Drawing.Point(247, 107);
            this.lblMainHeading3.Name = "lblMainHeading3";
            this.lblMainHeading3.Size = new System.Drawing.Size(171, 23);
            this.lblMainHeading3.TabIndex = 7;
            this.lblMainHeading3.Text = "Choose your mode:";
            // 
            // lblMainHeading1
            // 
            this.lblMainHeading1.AutoSize = true;
            this.lblMainHeading1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading1.ForeColor = System.Drawing.Color.White;
            this.lblMainHeading1.Location = new System.Drawing.Point(12, 9);
            this.lblMainHeading1.Name = "lblMainHeading1";
            this.lblMainHeading1.Size = new System.Drawing.Size(84, 24);
            this.lblMainHeading1.TabIndex = 8;
            this.lblMainHeading1.Text = "SkyBeat";
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRights.ForeColor = System.Drawing.Color.White;
            this.lblRights.Location = new System.Drawing.Point(12, 378);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(196, 14);
            this.lblRights.TabIndex = 9;
            this.lblRights.Text = "@ 2021 SkyBeat. All rights reserved.";
            // 
            // lblDesignby
            // 
            this.lblDesignby.AutoSize = true;
            this.lblDesignby.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignby.ForeColor = System.Drawing.Color.White;
            this.lblDesignby.Location = new System.Drawing.Point(204, 378);
            this.lblDesignby.Name = "lblDesignby";
            this.lblDesignby.Size = new System.Drawing.Size(328, 14);
            this.lblDesignby.TabIndex = 10;
            this.lblDesignby.Text = "| Design by Helene Conradie, Henco De Lange, Hermann Smit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.lblDesignby);
            this.Controls.Add(this.lblRights);
            this.Controls.Add(this.lblMainHeading1);
            this.Controls.Add(this.lblMainHeading3);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.lblMainHeading2);
            this.Controls.Add(this.pbGuitar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 440);
            this.MinimumSize = new System.Drawing.Size(680, 440);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Mode";
            ((System.ComponentModel.ISupportInitialize)(this.pbGuitar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMainHeading2;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.PictureBox pbGuitar;
        private System.Windows.Forms.Label lblMainHeading3;
        private System.Windows.Forms.Label lblMainHeading1;
        private System.Windows.Forms.Label lblRights;
        private System.Windows.Forms.Label lblDesignby;
    }
}

