/*
 * Created by SharpDevelop.
 * User: SFO
 * Date: 20/10/2014
 * Time: 12:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Conta.Controller;

namespace Conta.Ui
{
	/// <summary>
	/// Description of ConfigSocietate.
	/// </summary>
	public partial class ConfigSocietateForm : Form
	{
		Ctrl ctrl;
		public ConfigSocietateForm(Ctrl ctrl)
		{
			InitializeComponent();
			this.ctrl=ctrl;
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			String lekerdezes;
			lekerdezes="http://openapi.ro/api/companies/"+this.textBoxCUI.Text+".xml";
			XmlDocument docXml = new XmlDocument();
			docXml.Load(lekerdezes);
			XmlNodeList cui,denumire,adresa,oras,judet;
				
			cui = docXml.GetElementsByTagName("cif");
			denumire=docXml.GetElementsByTagName("name");
			adresa=docXml.GetElementsByTagName("address");
			oras=docXml.GetElementsByTagName("city");
			judet=docXml.GetElementsByTagName("state");
			
			String eredmeny=cui[0].InnerXml+'/'+denumire[0].InnerXml+'/'+adresa[0].InnerXml+'/'+oras[0].InnerXml+'/'+judet[0].InnerXml+'/';
			MessageBox.Show(eredmeny, "Eredmeny", MessageBoxButtons.OK);
		
		
		}
	}
}
