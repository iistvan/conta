/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Conta.Ui
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.administrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configSocietateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.administrareToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(963, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// administrareToolStripMenuItem
			// 
			this.administrareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.utilizatoriToolStripMenuItem,
			this.configSocietateToolStripMenuItem});
			this.administrareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.administrareToolStripMenuItem.Name = "administrareToolStripMenuItem";
			this.administrareToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
			this.administrareToolStripMenuItem.Text = "Administrare";
			// 
			// utilizatoriToolStripMenuItem
			// 
			this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
			this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
			this.utilizatoriToolStripMenuItem.Click += new System.EventHandler(this.UtilizatoriToolStripMenuItemClick);
			// 
			// configSocietateToolStripMenuItem
			// 
			this.configSocietateToolStripMenuItem.Name = "configSocietateToolStripMenuItem";
			this.configSocietateToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
			this.configSocietateToolStripMenuItem.Text = "Config. Societate";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 451);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Conta";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem administrareToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configSocietateToolStripMenuItem;
	}
}
