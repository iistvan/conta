/*
 * Created by SharpDevelop.
 * User: SFO
 * Date: 20/10/2014
 * Time: 12:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Conta.Ui
{
	partial class ConfigSocietateForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxCUI;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxCUI = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(638, 501);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.textBoxCUI);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(630, 475);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Date generale";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(230, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Verifică";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBoxCUI
			// 
			this.textBoxCUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCUI.Location = new System.Drawing.Point(87, 20);
			this.textBoxCUI.Name = "textBoxCUI";
			this.textBoxCUI.Size = new System.Drawing.Size(126, 22);
			this.textBoxCUI.TabIndex = 1;
			this.textBoxCUI.Focus();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "C.U.I ";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(630, 475);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Alte setări";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ConfigSocietateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 505);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigSocietateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configurare date Societate";
			this.Click += new System.EventHandler(this.Button2Click);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
