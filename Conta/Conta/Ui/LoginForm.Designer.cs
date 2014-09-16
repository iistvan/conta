/*
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnIesire = new System.Windows.Forms.Button();
			this.cmbUtilizatori = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(107, 22);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(67, 21);
			this.lblUser.TabIndex = 4;
			this.lblUser.Text = "Utilizator";
			// 
			// lblPass
			// 
			this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPass.Location = new System.Drawing.Point(107, 56);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(53, 23);
			this.lblPass.TabIndex = 5;
			this.lblPass.Text = "Parola";
			// 
			// txtPass
			// 
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPass.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtPass.Location = new System.Drawing.Point(166, 55);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(147, 20);
			this.txtPass.TabIndex = 1;
			this.txtPass.Enter += new System.EventHandler(this.TxtPassEnter);
			this.txtPass.Leave += new System.EventHandler(this.TxtPassLeave);
			// 
			// btnLogin
			// 
			this.btnLogin.AutoSize = true;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(251, 109);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(83, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "✓ Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// btnIesire
			// 
			this.btnIesire.AutoSize = true;
			this.btnIesire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnIesire.Location = new System.Drawing.Point(12, 109);
			this.btnIesire.Name = "btnIesire";
			this.btnIesire.Size = new System.Drawing.Size(75, 23);
			this.btnIesire.TabIndex = 3;
			this.btnIesire.Text = "Iesire";
			this.btnIesire.UseVisualStyleBackColor = true;
			this.btnIesire.Click += new System.EventHandler(this.BtnIesireClick);
			// 
			// cmbUtilizatori
			// 
			this.cmbUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbUtilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbUtilizatori.FormattingEnabled = true;
			this.cmbUtilizatori.Location = new System.Drawing.Point(166, 21);
			this.cmbUtilizatori.Name = "cmbUtilizatori";
			this.cmbUtilizatori.Size = new System.Drawing.Size(147, 23);
			this.cmbUtilizatori.TabIndex = 0;
			this.cmbUtilizatori.SelectedIndexChanged += new System.EventHandler(this.CmbUtilizatoriSelectedIndexChanged);
			this.cmbUtilizatori.Enter += new System.EventHandler(this.CmbUtilizatoriEnter);
			this.cmbUtilizatori.Leave += new System.EventHandler(this.CmbUtilizatoriLeave);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(0, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(347, 2);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(22, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(59, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnIesire;
			this.ClientSize = new System.Drawing.Size(346, 144);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnIesire);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.cmbUtilizatori);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Autentificare";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbUtilizatori;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnIesire;
	}
}
