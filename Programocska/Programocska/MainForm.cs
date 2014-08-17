/*
 * Created by SharpDevelop.
 * User: Shiva
 * Date: 16.08.2014
 * Time: 21:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Programocska
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//kapcsolodas az adatbazishoz
			 MySqlConnection kapcsolat = new MySqlConnection("SERVER=85.10.205.173;DATABASE=ganesha;UID=attilabajko;PASSWORD=shivashakti");
			 string queryString = "SELECT * FROM Utilizatori";
			 MySqlCommand parancs = new MySqlCommand(queryString, kapcsolat);
        	 MySqlDataAdapter users = new MySqlDataAdapter(queryString,kapcsolat);
			 kapcsolat.Open();
			 users.Fill(this.dataSet1);
			 this.dataGrid1.DataSource = this.dataSet1;	
			 this.dataGrid1.DataMember = this.dataSet1.Tables[0].TableName;
			 users.Update(this.dataSet1);
			 kapcsolat.Close();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
