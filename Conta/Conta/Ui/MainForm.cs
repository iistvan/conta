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
		}
		
		public void LoadLoginWindow(){			
			//Van-e felhasznalo mar az adatbazisban?
			if (ctrl.FreshInstall()) {
				newUser = new NewUser(ctrl, new UsersForm(ctrl));
				newUser.ShowDialog();
			} else {
				loginForm = new LoginForm(ctrl);
				loginForm.ShowDialog();					
			}
		}
		
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
			usersForm.ShowDialog();
		}
	}
}
