/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Conta.Ui
{
	partial class NewUser
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.cmbDrepturi = new System.Windows.Forms.ComboBox();
			this.btnCreare = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nume utilizator";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Parola";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Drepturi";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(125, 25);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(141, 21);
			this.txtUser.TabIndex = 4;
			this.txtUser.Enter += new System.EventHandler(this.TxtUserEnter);
			this.txtUser.Leave += new System.EventHandler(this.TxtUserLeave);
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(125, 51);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(141, 21);
			this.txtPass.TabIndex = 5;
			this.txtPass.Enter += new System.EventHandler(this.TxtPassEnter);
			this.txtPass.Leave += new System.EventHandler(this.TxtPassLeave);
			// 
			// cmbDrepturi
			// 
			this.cmbDrepturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDrepturi.FormattingEnabled = true;
			this.cmbDrepturi.Items.AddRange(new object[] {
			"Administrator",
			"Altul"});
			this.cmbDrepturi.Location = new System.Drawing.Point(125, 74);
			this.cmbDrepturi.Name = "cmbDrepturi";
			this.cmbDrepturi.Size = new System.Drawing.Size(141, 24);
			this.cmbDrepturi.TabIndex = 6;
			this.cmbDrepturi.Enter += new System.EventHandler(this.CmbDrepturiEnter);
			this.cmbDrepturi.Leave += new System.EventHandler(this.CmbDrepturiLeave);
			// 
			// btnCreare
			// 
			this.btnCreare.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCreare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreare.Location = new System.Drawing.Point(81, 142);
			this.btnCreare.Name = "btnCreare";
			this.btnCreare.Size = new System.Drawing.Size(149, 27);
			this.btnCreare.TabIndex = 7;
			this.btnCreare.Text = "Salveaza";
			this.btnCreare.UseVisualStyleBackColor = true;
			this.btnCreare.Click += new System.EventHandler(this.BtnCreareClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbDrepturi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtPass);
			this.groupBox1.Controls.Add(this.txtUser);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(285, 118);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Date utilizator";
			// 
			// NewUser
			// 
			this.AcceptButton = this.btnCreare;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 181);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCreare);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewUser";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adaugare utilizator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.ComboBox cmbDrepturi;
		private System.Windows.Forms.Button btnCreare;
	}
}
