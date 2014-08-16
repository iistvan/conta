﻿/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Conta.Controller;

namespace Conta.Ui
{
	/// <summary>
	/// Login window
	/// </summary>
	public partial class LoginForm : Form
	{
		Ctrl ctrl;
		
		public LoginForm(Ctrl ctrl)	{			
			InitializeComponent();			
			this.ctrl = ctrl;
		}
		
		void BtnLoginClick(object sender, EventArgs e) {
			string username = txtUser.Text;
			string pass = txtPass.Text;
			if (ctrl.Login(username, pass))
				this.Dispose();
			else
				MessageBox.Show("Utilizator sau parola incorecta!", "Autentificare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);			
		}
		
		void LoginFormFormClosing(object sender, FormClosingEventArgs e) {
			ctrl.Exit();
		}
		
		void BtnIesireClick(object sender, EventArgs e) {
			ctrl.Exit();
		}
	}
}