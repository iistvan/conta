/*
 * Attila
 * Gyuri
 * pista
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:58
 * Geza
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Conta.Repository;
using Conta.Controller;
using Conta.Ui;

namespace Conta
{
	/// <summary>/// <summary>
	/// ///
	/// </summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			// Database management
			Repo repo = new Repo();
			
			// Manager
			Ctrl ctrl = new Ctrl(repo);
			
			// Main window
			MainForm mainForm = new MainForm(ctrl);				
			Application.Run(mainForm);
		}		
	}
}
