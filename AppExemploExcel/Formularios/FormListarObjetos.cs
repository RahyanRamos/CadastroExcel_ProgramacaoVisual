using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploExcel.RegrasDeNegocio;
using ClosedXML.Excel;

namespace AppExemploExcel.Formularios
{
    public partial class FormListarObjetos : Form
    {
        List<Pessoa> listaDePessoas = new List<Pessoa>();   
        public FormListarObjetos()
        {
            InitializeComponent();
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            var pasta = new XLWorkbook("C:\\teste\\cadastro.xlsx");
            var plan1 = pasta.Worksheet(1);
            int totalLinhas = plan1.RowsUsed().Count();//total de linhas
            for (int linha = 2; linha < totalLinhas+1; linha++)
            {
                Pessoa objPessoa = new Pessoa();
                objPessoa.Id = Convert.ToInt32(plan1.Cell(linha,1).Value.ToString());
                objPessoa.Nome = plan1.Cell(linha, 2).Value.ToString();
                objPessoa.Rg = plan1.Cell(linha, 3).Value.ToString();
                objPessoa.Cpf = plan1.Cell(linha, 4).Value.ToString();
                listaDePessoas.Add(objPessoa);

            }
            dataGridView1.DataSource = listaDePessoas.ToList();
        }
    }
}
