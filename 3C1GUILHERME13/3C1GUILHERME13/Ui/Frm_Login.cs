
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using _3C1GUILHERME13.Code.BLL;
using _3C1GUILHERME13.Code.DTO;

namespace _3C1GUILHERME13.Ui
{
    public partial class Frm_Login : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();




        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txt_email.Text;
            loginDTO.Senha = txt_senha.Text;

            if(loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_Oculos frm_Oculos = new Frm_Oculos();
                frm_Oculos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnklabesqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("11901438@aluno.cotemig.com.br", "uhczkadjphzmmpye"),
                EnableSsl = true
            };

            loginDTO.Email = txt_email.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);

            client.Send("11901438@aluno.cotemig.com.br", $"{txt_email.Text}", "Redefinição de Senha", $"Seu e-mail é {txt_email.Text} com senha {senha}");

            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
