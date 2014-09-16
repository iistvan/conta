/*
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

namespace Conta.Ui {
	/// <summary>
	/// Login window
	/// </summary>
	public partial class LoginForm : Form {
		Ctrl ctrl;
		LoginRepo loginRepo;
		
		public LoginForm(Ctrl ctrl) {			
			InitializeComponent();		
			this.ctrl = ctrl;
			Initialize();
		}
		
		private void Initialize() {	
			loginRepo = new LoginRepo();
			PopulateCmbUtilizatori();
		}
		
		private void PopulateCmbUtilizatori() {
			foreach (String s in loginRepo.GetUtilizatori())
				cmbUtilizatori.Items.Add(s);
		}
		
		void BtnLoginClick(object sender, EventArgs e) {
			string username = cmbUtilizatori.Text;
			string pass = txtPass.Text;
			if (loginRepo.Login(username, pass))
				this.Dispose();
			else {
				MessageBox.Show("Parola incorecta.", "Autentificare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);	
				txtPass.BackColor = Color.LightSalmon;
			}
		}
		
		void BtnIesireClick(object sender, EventArgs e) {
			ctrl.Exit();
		}
		
		void CmbUtilizatoriSelectedIndexChanged(object sender, EventArgs e) {
			txtPass.Clear();
			txtPass.Focus();
		}
		
		void TxtPassEnter(object sender, EventArgs e) {
			txtPass.BackColor = Color.LightGoldenrodYellow;
		}
		
		void TxtPassLeave(object sender, EventArgs e) {
			txtPass.BackColor = Color.White;
		}
		
		void CmbUtilizatoriEnter(object sender, EventArgs e) {
			cmbUtilizatori.BackColor = Color.LightGoldenrodYellow;
		}
		
		void CmbUtilizatoriLeave(object sender, EventArgs e) {
			cmbUtilizatori.BackColor = Color.White;
		}
	}
}
