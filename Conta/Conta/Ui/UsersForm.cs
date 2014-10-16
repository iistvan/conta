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
		NewUser newUserForm;		
		
		/*
		 * TODO: Lehet hogy nem kell majd ide se a CTRL!
		 */
		
		public UsersForm(Ctrl ctrl) {
			InitializeComponent();
			this.ctrl = ctrl;
			UpdateUsersList();
			DataGridViewLinkColumn link = new DataGridViewLinkColumn();
			link.Name = "Modificare";
			link.UseColumnTextForLinkValue = true;
			link.Text = "sterge/parola";
            dataGridView1.Columns.Add(link);			
		}
		
		void BtnAdaugaClick(object sender, EventArgs e) {
			newUserForm = new NewUser(this);
			newUserForm.ShowDialog();
		}
		
		public void UpdateUsersList() {
			DataSet dataSet = ctrl.FelhasznalokDataSet();
			this.dataGridView1.DataSource = dataSet;
			this.dataGridView1.DataMember = dataSet.Tables[0].TableName;			
		}		
	}
}
