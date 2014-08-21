/*
 * Created by SharpDevelop.
 * User: Istvan
 * Date: 14.08.2014
 * Time: 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Conta.Controller;

namespace Conta.Ui {
    /// <summary>
    /// Window for new user
    /// </summary>
    public partial class NewUser : Form {
        Ctrl ctrl;

        public NewUser(Ctrl ctrl) {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.ctrl = ctrl;
        }

        void BtnCreareClick(object sender, EventArgs e) {
            string username = txtUser.Text;
            string pass = txtPass.Text;
            string drepturi = cmbDrepturi.SelectedText;

            if (AreFieldsValid())
                ctrl.AddNewUser(username, pass, drepturi);
        }

        private Boolean AreFieldsValid() {
            StringBuilder errors = new StringBuilder();

            //Validate username
            Regex validator = new Regex(@"^[a-z][a-z0-9]+$");

            if (!validator.Match(txtUser.Text).Success)
                errors.AppendLine("Numele de utilizator poate contine doar litere si cifre.");

            //Validate pass
            if (!validator.Match(txtPass.Text).Success)
                errors.AppendLine("Parola poate contine doar litere si cifre.");

            //Validate drepturi		   
            string drepturi = cmbDrepturi.Text;
            if (!drepturi.Equals("Administrator", StringComparison.Ordinal))
                if (!drepturi.Equals("Altul", StringComparison.Ordinal))
                    errors.AppendLine("Nu ati selectat drepturi.");

            if (errors.ToString() == String.Empty)
                return true;
            else
                MessageBox.Show(errors.ToString(), "Validare esuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
