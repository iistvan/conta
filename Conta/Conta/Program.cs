/*
 * User: Istvan
 * Date: 14.08.2014
 * Time: 11:58
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
