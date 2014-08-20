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
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.ctrl = ctrl;
			this.IsMdiContainer = true;
			
			//Adatbazishoz kapcsolodas teszt			
			if (!ctrl.TestConnectionToDB()) {				
				Application.Exit();
				return;
			}
			
			//Van-e felhasznalo mar az adatbazisban?
			if (ctrl.FreshInstall()) {
				newUser = new NewUser(ctrl);
				newUser.MdiParent = this;
				newUser.Show();
			} else {
				loginForm = new LoginForm(ctrl);
				loginForm.MdiParent = this;
				loginForm.Show();	
				
//				loginForm.ShowDialog();
//				while (loginForm.Visible)
//					this.Enabled = false;
			}
		}
		
		void AdaugareToolStripMenuItemClick(object sender, EventArgs e) {
				newUser = new NewUser(ctrl);
				newUser.MdiParent = this;
				newUser.Show();
		}
	}
}
