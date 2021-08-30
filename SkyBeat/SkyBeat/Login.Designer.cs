
namespace SkyBeat
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLoginHeading1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.lblLoginSignup = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbEarphones = new System.Windows.Forms.PictureBox();
            this.pbShowPassword = new System.Windows.Forms.PictureBox();
            this.pbLockIcon = new System.Windows.Forms.PictureBox();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lblRights2 = new System.Windows.Forms.Label();
            this.lblLoginHeading2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblViewPlayers = new System.Windows.Forms.Label();
            this.rtxtViewAll = new System.Windows.Forms.RichTextBox();
            this.lblBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEarphones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginHeading1
            // 
            this.lblLoginHeading1.AutoSize = true;
            this.lblLoginHeading1.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading1.Location = new System.Drawing.Point(334, 27);
            this.lblLoginHeading1.Name = "lblLoginHeading1";
            this.lblLoginHeading1.Size = new System.Drawing.Size(87, 32);
            this.lblLoginHeading1.TabIndex = 0;
            this.lblLoginHeading1.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(317, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.SkyBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(320, 107);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 13);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(317, 138);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.SkyBlue;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(320, 161);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(150, 13);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPass.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.Location = new System.Drawing.Point(317, 195);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(123, 13);
            this.lblForgotPass.TabIndex = 8;
            this.lblForgotPass.Text = "Forgot your password?";
            this.lblForgotPass.Click += new System.EventHandler(this.lblForgotPass_Click);
            // 
            // lblLoginSignup
            // 
            this.lblLoginSignup.AutoSize = true;
            this.lblLoginSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginSignup.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginSignup.Location = new System.Drawing.Point(317, 224);
            this.lblLoginSignup.Name = "lblLoginSignup";
            this.lblLoginSignup.Size = new System.Drawing.Size(120, 13);
            this.lblLoginSignup.TabIndex = 9;
            this.lblLoginSignup.Text = "Don\'t have an account?";
            this.lblLoginSignup.Click += new System.EventHandler(this.lblSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(329, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 30);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbEarphones
            // 
            this.pbEarphones.Image = ((System.Drawing.Image)(resources.GetObject("pbEarphones.Image")));
            this.pbEarphones.Location = new System.Drawing.Point(-41, 129);
            this.pbEarphones.Name = "pbEarphones";
            this.pbEarphones.Size = new System.Drawing.Size(364, 241);
            this.pbEarphones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEarphones.TabIndex = 11;
            this.pbEarphones.TabStop = false;
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowPassword.Image = global::SkyBeat.Properties.Resources.ShowPass;
            this.pbShowPassword.Location = new System.Drawing.Point(470, 157);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(22, 20);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPassword.TabIndex = 7;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseDown);
            this.pbShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPassword_MouseUp);
            // 
            // pbLockIcon
            // 
            this.pbLockIcon.Image = global::SkyBeat.Properties.Resources.Lock_Logo;
            this.pbLockIcon.Location = new System.Drawing.Point(292, 157);
            this.pbLockIcon.Name = "pbLockIcon";
            this.pbLockIcon.Size = new System.Drawing.Size(22, 20);
            this.pbLockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLockIcon.TabIndex = 6;
            this.pbLockIcon.TabStop = false;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = global::SkyBeat.Properties.Resources.Username_Logo;
            this.pbUserIcon.Location = new System.Drawing.Point(292, 103);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(22, 20);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserIcon.TabIndex = 2;
            this.pbUserIcon.TabStop = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.Black;
            this.pnlUsername.Location = new System.Drawing.Point(320, 122);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(150, 1);
            this.pnlUsername.TabIndex = 12;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Black;
            this.pnlPassword.Location = new System.Drawing.Point(320, 176);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(150, 1);
            this.pnlPassword.TabIndex = 13;
            // 
            // lblRights2
            // 
            this.lblRights2.AutoSize = true;
            this.lblRights2.Font = new System.Drawing.Font("Bahnschrift", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRights2.Location = new System.Drawing.Point(189, 344);
            this.lblRights2.Name = "lblRights2";
            this.lblRights2.Size = new System.Drawing.Size(441, 12);
            this.lblRights2.TabIndex = 14;
            this.lblRights2.Text = "@ 2021 SkyBeat. All rights reserved. | Design by Helene Conradie, Henco De Lange," +
    " Hermann Smit";
            // 
            // lblLoginHeading2
            // 
            this.lblLoginHeading2.AutoSize = true;
            this.lblLoginHeading2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading2.Location = new System.Drawing.Point(12, 9);
            this.lblLoginHeading2.Name = "lblLoginHeading2";
            this.lblLoginHeading2.Size = new System.Drawing.Size(84, 24);
            this.lblLoginHeading2.TabIndex = 16;
            this.lblLoginHeading2.Text = "SkyBeat";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(353, 59);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(46, 16);
            this.lblPlayer.TabIndex = 17;
            this.lblPlayer.Text = "Player";
            // 
            // lblViewPlayers
            // 
            this.lblViewPlayers.AutoSize = true;
            this.lblViewPlayers.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewPlayers.Location = new System.Drawing.Point(619, 100);
            this.lblViewPlayers.Name = "lblViewPlayers";
            this.lblViewPlayers.Size = new System.Drawing.Size(102, 16);
            this.lblViewPlayers.TabIndex = 18;
            this.lblViewPlayers.Text = "View all Players";
            this.lblViewPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblViewPlayers_MouseDown);
            this.lblViewPlayers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblViewPlayers_MouseUp);
            // 
            // rtxtViewAll
            // 
            this.rtxtViewAll.Location = new System.Drawing.Point(622, 122);
            this.rtxtViewAll.Name = "rtxtViewAll";
            this.rtxtViewAll.Size = new System.Drawing.Size(100, 115);
            this.rtxtViewAll.TabIndex = 19;
            this.rtxtViewAll.Text = "";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(373, 306);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(36, 16);
            this.lblBack.TabIndex = 20;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.rtxtViewAll);
            this.Controls.Add(this.lblViewPlayers);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblLoginHeading2);
            this.Controls.Add(this.lblRights2);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginSignup);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.pbShowPassword);
            this.Controls.Add(this.pbLockIcon);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginHeading1);
            this.Controls.Add(this.pbEarphones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 400);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEarphones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginHeading1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pbLockIcon;
        private System.Windows.Forms.PictureBox pbShowPassword;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.Label lblLoginSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbEarphones;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label lblRights2;
        private System.Windows.Forms.Label lblLoginHeading2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblViewPlayers;
        private System.Windows.Forms.RichTextBox rtxtViewAll;
        private System.Windows.Forms.Label lblBack;
    }
}