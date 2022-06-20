using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL_System.Model;

namespace MySQL_System
{
    public partial class LoginForm : Form
    {
        UserModel model = new UserModel();
        public LoginForm()
        {
            InitializeComponent();
        }
        public void Login(User dado)
        {
            try
            {
                if(txtUser.Text == "")
                {
                    lbl_message.Text = "Preencha o Usuário";
                    lbl_message.ForeColor = Color.Gold;
                    txtUser.Focus();
                    return;
                }
                if (txt_Pass.Text == "")
                {
                    lbl_message.Text = "Preencha a Senha";
                    lbl_message.ForeColor = Color.Gold;
                    txt_Pass.Focus();
                    return;
                }


                dado.Usuario = txtUser.Text;
                dado.Senha = txt_Pass.Text;

                dado = model.Login(dado);

                if(dado.Usuario == null)
                {
                    lbl_message.Text = "Usuário ou senha incorreto!!!";
                    lbl_message.ForeColor = Color.Red;
                    return;
                }
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Logar: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(new User());
        }
    }
}
