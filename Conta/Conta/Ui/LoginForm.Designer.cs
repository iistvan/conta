﻿/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Conta.Ui
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnIesire = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(12, 56);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(67, 21);
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "Utilizator";
			// 
			// lblPass
			// 
			this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPass.Location = new System.Drawing.Point(12, 90);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(53, 23);
			this.lblPass.TabIndex = 1;
			this.lblPass.Text = "Parola";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(81, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Autentificare";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(71, 55);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(147, 20);
			this.txtUser.TabIndex = 3;
			// 
			// txtPass
			// 
			this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtPass.Location = new System.Drawing.Point(71, 89);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(147, 20);
			this.txtPass.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(153, 145);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// btnIesire
			// 
			this.btnIesire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnIesire.Location = new System.Drawing.Point(39, 145);
			this.btnIesire.Name = "btnIesire";
			this.btnIesire.Size = new System.Drawing.Size(75, 23);
			this.btnIesire.TabIndex = 6;
			this.btnIesire.Text = "Iesire";
			this.btnIesire.UseVisualStyleBackColor = true;
			this.btnIesire.Click += new System.EventHandler(this.BtnIesireClick);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnIesire;
			this.ClientSize = new System.Drawing.Size(287, 204);
			this.Controls.Add(this.btnIesire);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUser);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autentificare";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnIesire;
	}
}