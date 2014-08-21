/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Conta.Controller;

namespace Conta.Ui
{
	/// <summary>
	/// Main window
	/// </summary>
	public partial class MainForm : Form {
		NewUser newUser;
		LoginForm loginForm;
		Ctrl ctrl;
		
		public MainForm(Ctrl ctrl) {
			InitializeComponent();			
			this.ctrl = ctrl;
			this.IsMdiContainer = true;						
		}
		
		public void LoadLoginWindow(){			
			//Van-e felhasznalo mar az adatbazisban?
			if (ctrl.FreshInstall()) {
				newUser = new NewUser(ctrl, new UsersForm(ctrl));
				newUser.MdiParent = this;
				newUser.Show();
			} else {
				loginForm = new LoginForm(ctrl);
				loginForm.MdiParent = this;
//				loginForm.Owner = this;
				loginForm.Show();	
				
//				loginForm.ShowDialog();
//				while (loginForm.Visible)
//					this.Enabled = false;
			}
		}
		
//		void AdaugareToolStripMenuItemClick(object sender, EventArgs e) {
//				newUser = new NewUser(ctrl);
//				newUser.MdiParent = this;
//				newUser.Show();
//		}
		
		void MainFormLoad(object sender, EventArgs e) {			
			//Adatbazishoz kapcsolodas teszt
			if (!ctrl.TestConnectionToDB()) {
				ctrl.Exit();
			} else {
				LoadLoginWindow();
			}
		}
		void UtilizatoriToolStripMenuItemClick(object sender, EventArgs e) {
			UsersForm usersForm = new UsersForm(ctrl);
			usersForm.Show();
		}
	}
}
