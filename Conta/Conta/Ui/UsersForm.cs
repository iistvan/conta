/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 21.08.2014
 * Time: 12:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Conta.Controller;

namespace Conta.Ui {
	/// <summary>
	/// Description of UsersForm.
	/// </summary>
	public partial class UsersForm : Form {
		Ctrl ctrl;
		
		public UsersForm(Ctrl ctrl) {
			InitializeComponent();
			this.ctrl = ctrl;
			UpdateUsersList();
		}
		
		void BtnAdaugaClick(object sender, EventArgs e) {
			NewUser newUserForm = new NewUser(ctrl, this);
			newUserForm.Show();
		}
		
		public void UpdateUsersList() {
			DataSet dataSet = ctrl.FelhasznalokDataSet();
			this.dataGridView1.DataSource = dataSet;
			this.dataGridView1.DataMember = dataSet.Tables[0].TableName;
		}
	}
}
