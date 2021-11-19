using _3C1GUILHERME13.Code.DTO;
using _3C1GUILHERME13.Code.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3C1GUILHERME13.Code.BLL
{
    class OculosBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "oculos";

        public void Inserir (OculosDTO ocuDto)
        {

            string inserir = $"insert into {tabela} values(null, '{ocuDto.Nome}','{ocuDto.Cor}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar (OculosDTO ocuDto)
        {
            string alterar = $"uptade {tabela} set nome = '{ocuDto.Nome}', cor = '{ocuDto.Cor}', where id = '{ocuDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir (OculosDTO ocuDto)
        {
            string excluir = $"delete from {tabela} where id = '{ocuDto.Id}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
