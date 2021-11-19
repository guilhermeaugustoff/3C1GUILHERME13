using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3C1GUILHERME13.Code.BLL;
using _3C1GUILHERME13.Code.DTO;

namespace _3C1GUILHERME13
{
    public partial class Frm_Oculos : Form
    {

        OculosBLL ocubll = new OculosBLL();
        OculosDTO ocudto = new OculosDTO();



        public Frm_Oculos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_oculos.DataSource = ocubll.Listar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ocudto.Nome = txt_nome.Text;
            ocudto.Cor = txt_cor.Text;

            ocubll.Inserir(ocudto);

            MessageBox.Show("Cadastrado com Sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_id.Clear();
            txt_nome.Clear();
            txt_cor.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ocudto.Id = int.Parse(txt_id.Text);
            ocudto.Nome = txt_nome.Text;
            ocudto.Cor = txt_cor.Text;

            ocubll.Editar(ocudto);

            MessageBox.Show("Alterado com sucesso!", "Oculos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ocubll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_cor.Clear();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ocudto.Id = int.Parse(txt_id.Text);

            ocubll.Excluir(ocudto);

            MessageBox.Show("Excluido com sucesso!", "Oculos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ocubll.Listar();

            txt_id.Clear();
            txt_nome.Clear();
            txt_cor.Clear();
        }

        private void dgv_oculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_oculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_oculos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_cor.Text = dgv_oculos.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
