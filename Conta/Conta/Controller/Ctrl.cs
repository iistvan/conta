/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Conta.Ui;
using Conta.Repository;
using System.Windows.Forms;


namespace Conta.Controller {
	/// <summary>
	/// Description of Controller.
	/// </summary>
	public class Ctrl {
		Repo repo;
		
		public Ctrl(Repo repo) {
			this.repo = repo;
		}
		
		public Boolean FreshInstall() {
			if (repo.NrOfUsersInDB() < 1)
				return true;
			return false;
		}
		
		public Boolean Login(string u, string p) {
			return repo.Login(u, p);
		}
		
		public List<String> GetUtilizatori() {
			return repo.GetUtilizatori();
		}
		
		public void AddNewUser(string u, string p, string d) {
			repo.AddNewUser(u, p, d);
		}
		
		public void Exit() {
			Application.Exit();
		}
	}
}
