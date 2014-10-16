/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 16.10.2014
 * Time: 11:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conta.Ui
{
	/// <summary>
	/// Description of NewUserRepo.
	/// </summary>
	public class NewUserRepo: Repository.Repo
	{		
		public Boolean AddNewUser(string u, string p, string d) {
			string query = "INSERT INTO Utilizatori (nume, parola, drepturi) VALUES ('" + u + "', '" + p + "', '" + d + "')";
			Boolean sikerult = true;
			if (this.OpenConnection() == true) {
				MySqlCommand cmd = new MySqlCommand(query, connection);
				try {
					cmd.ExecuteNonQuery();				
				} catch (MySqlException ex) {
					if (ex.Number == 1062)
            			MessageBox.Show("Exista deja un utilizator cu acest nume.", "Adaugare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else
						MessageBox.Show(ex.Message, "Adaugare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					sikerult = false;
				}
				this.CloseConnection();
			}
			return sikerult;
		}
		
	}
}
