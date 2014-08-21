/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 13:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conta.Repository {
	/// <summary>
	/// Description of DBConnect.
	/// </summary>
	public class Repo {
		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;
		
		//Constructor
		public Repo() {
			Initialize();
		}
		
		//Initialize values
		private void Initialize() {
			server = "85.10.205.173";
			database = "ganesha";
			uid = "attilabajko";
			password = "shivashakti";
			string connectionString;
			connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
			
			connection = new MySqlConnection(connectionString);
		}
		
		public Boolean TestConnectionToDB() {
			try {
				connection.Open();
			} catch (MySqlException ex) {
				MessageBox.Show("Test: Eroare la conectare la baza de date:\n" + ex.Message, "Eroare conectare", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			connection.Close();
			return true;
		}
		
		//open connection to database
		public bool OpenConnection() {
			try {
				connection.Open();
				return true;
			} catch (MySqlException ex) {
				MessageBox.Show("OpenConnection: Eroare la conectare la baza de date:\n" + ex.Message, "Eroare conectare", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			return false;
		}
		
		//Close connection
		public bool CloseConnection() {
			try {
				connection.Close();
				return true;
			} catch (MySqlException ex) {
				MessageBox.Show("CloseConnection: Eroare la conectare la baza de date:\n" + ex.Message, "Eroare conectare", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
			return false;
		}
		
		//Check no of existing users in DB
		public int NrOfUsersInDB() {
			string query = "SELECT Count(*) FROM Utilizatori";
			int Count = -1;
			
			//Open Connection
			if (this.OpenConnection() == true) {
				//Create Mysql Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				//ExecuteScalar will return one value
				Count = int.Parse(cmd.ExecuteScalar() + "");
				
				//close Connection
				this.CloseConnection();
				
				return Count;
			} else {
				return Count;
			}
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
		
		public void AddNewUser(string u, string p, string d) {
			string query = "INSERT INTO Utilizatori (nume, parola, drepturi) VALUES ('" + u + "', '" + p + "', '" + d + "')";
			if (this.OpenConnection() == true) {
				MySqlCommand cmd = new MySqlCommand(query, connection);
				try {
					cmd.ExecuteNonQuery();				
				} catch (MySqlException ex) {
					MessageBox.Show(ex.Message);
				}
				this.CloseConnection();
			}
		}
		
		public List<String> GetUtilizatori() {
			List<String> utilizatori = new List<String>();
			MySqlDataReader dr;
			if (this.OpenConnection()) {
				MySqlCommand cmd = new MySqlCommand("SELECT nume FROM Utilizatori", connection);
				dr = cmd.ExecuteReader();

				while (dr.Read())
					utilizatori.Add(dr[0].ToString());
  
				dr.Close();
				this.CloseConnection();
			}
			return utilizatori;
		}

		public DataSet FelhasznalokDataSet() {
			DataSet dataSet = new DataSet();
			if (this.OpenConnection()) {
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT nume as Nume, drepturi as Drepturi FROM Utilizatori", connection);
				dataAdapter.Fill(dataSet);
				this.CloseConnection();
			}
			return dataSet;
		}		
		
		//Insert statement
		public void Insert() {
			string query = "INSERT INTO Utilizatori VALUES('12', 'newUser3', 'test', 'admin')";
			
			//open connection
			if (this.OpenConnection() == true) {
				MessageBox.Show("connected...");
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				//Execute command
				cmd.ExecuteNonQuery();
				
				MessageBox.Show("closing conn");
				//close connection
				this.CloseConnection();
			}
		}
		
		//Update statement
		public void Update() {
			string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
			
			//Open connection
			if (this.OpenConnection() == true) {
				//create mysql command
				MySqlCommand cmd = new MySqlCommand();
				//Assign the query using CommandText
				cmd.CommandText = query;
				//Assign the connection using Connection
				cmd.Connection = connection;
				
				//Execute query
				cmd.ExecuteNonQuery();
				
				//close connection
				this.CloseConnection();
			}
		}
		
		//Delete statement
		public void Delete() {
			string query = "DELETE FROM tableinfo WHERE name='John Smith'";
			
			if (this.OpenConnection() == true) {
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.ExecuteNonQuery();
				this.CloseConnection();
			}
		}
		
		//Select statement
		public List<string>[] Select() {
			string query = "SELECT * FROM tableinfo";
			
			//Create a list to store the result
			List<string>[] list = new List<string>[3];
			list[0] = new List<string>();
			list[1] = new List<string>();
			list[2] = new List<string>();
			
			//Open connection
			if (this.OpenConnection() == true) {
				//Create Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader();
				
				//Read the data and store them in the list
				while (dataReader.Read()) {
					list[0].Add(dataReader["id"] + "");
					list[1].Add(dataReader["name"] + "");
					list[2].Add(dataReader["age"] + "");
				}
				
				//close Data Reader
				dataReader.Close();
				
				//close Connection
				this.CloseConnection();
				
				//return list to be displayed
				return list;
			} else {
				return list;
			}
		}	
		
		public int Count() {
			string query = "SELECT Count(*) FROM Utilizatori";
			int Count = -1;
			
			//Open Connection
			if (this.OpenConnection() == true) {
				//Create Mysql Command
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				//ExecuteScalar will return one value
				Count = int.Parse(cmd.ExecuteScalar() + "");
				
				//close Connection
				this.CloseConnection();
				
				return Count;
			} else {
				return Count;
			}
		}
		
		//Backup
		//		public void Backup()
		//		{
		//			try
		//			{
		//				DateTime Time = DateTime.Now;
		//				int year = Time.Year;
		//				int month = Time.Month;
		//				int day = Time.Day;
		//				int hour = Time.Hour;
		//				int minute = Time.Minute;
		//				int second = Time.Second;
		//				int millisecond = Time.Millisecond;
		//
		//				//Save file to C:\ with the current date as a filename
		//				string path;
		//				path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
		//				StreamWriter file = new StreamWriter(path);
		//
		//
		//				ProcessStartInfo psi = new ProcessStartInfo();
		//				psi.FileName = "mysqldump";
		//				psi.RedirectStandardInput = false;
		//				psi.RedirectStandardOutput = true;
		//				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
		//				psi.UseShellExecute = false;
		//
		//				Process process = Process.Start(psi);
		//
		//				string output;
		//				output = process.StandardOutput.ReadToEnd();
		//				file.WriteLine(output);
		//				process.WaitForExit();
		//				file.Close();
		//				process.Close();
		//			}
		//			catch (IOException ex)
		//			{
		//				MessageBox.Show("Error , unable to backup!");
		//			}
		//		}
		//
		//		//Restore
		//		public void Restore()
		//		{
		//			try
		//			{
		//				//Read file from C:\
		//				string path;
		//				path = "C:\\MySqlBackup.sql";
		//				StreamReader file = new StreamReader(path);
		//				string input = file.ReadToEnd();
		//				file.Close();
		//
		//
		//				ProcessStartInfo psi = new ProcessStartInfo();
		//				psi.FileName = "mysql";
		//				psi.RedirectStandardInput = true;
		//				psi.RedirectStandardOutput = false;
		//				psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
		//				psi.UseShellExecute = false;
		//
		//
		//				Process process = Process.Start(psi);
		//				process.StandardInput.WriteLine(input);
		//				process.StandardInput.Close();
		//				process.WaitForExit();
		//				process.Close();
		//			}
		//			catch (IOException ex)
		//			{
		//				MessageBox.Show("Error , unable to Restore!");
		//			}
		//		}
	}
}