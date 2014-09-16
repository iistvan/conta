/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 16.09.2014
 * Time: 8:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Conta.Ui
{
	/// <summary>
	/// Description of LoginRepo.
	/// </summary>
	public class LoginRepo: Repository.Repo
	{
		public LoginRepo()
		{
		}
		
		public List<String> GetUtilizatori() {
			List<String> utilizatori = new List<String>();
			MySqlDataReader dr;
			if (this.OpenConnection()) {
				MySqlCommand cmd = new MySqlCommand("SELECT nume FROM Utilizatori ORDER BY nume", connection);
				dr = cmd.ExecuteReader();

				while (dr.Read())
					utilizatori.Add(dr[0].ToString());
  
				dr.Close();
				this.CloseConnection();
			}
			return utilizatori;
		}		
		
		public Boolean Login(string u, string p) {
			string query = "SELECT Count(*) FROM Utilizatori where nume = '" + u + "' and parola = '" + p + "'";
			int Count = -1;
			
			//Open Connection
			if (this.OpenConnection() == true) {
				//Create Mysql Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				//ExecuteScalar will return one value
				Count = int.Parse(cmd.ExecuteScalar() + "");
				
				//close Connection
				this.CloseConnection();
			}
			if (Count < 1)
				return false;
			return true;
		}
	}
}
