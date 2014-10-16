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
using System.Data;
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
		
		public Boolean TestConnectionToDB() {
			return repo.TestConnectionToDB();			
		}
		
		public DataSet FelhasznalokDataSet() {
			return repo.FelhasznalokDataSet();
		}
		
		public Boolean FreshInstall() {
			if (repo.NrOfUsersInDB() == 0)
				return true;
			return false;
		}		
		
		public void Exit() {
			Application.Exit();
		}
	}
}
