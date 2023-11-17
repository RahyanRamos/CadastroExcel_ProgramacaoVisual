using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace AppExemploExcel.Formularios
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook("C:\\teste\\cadastro.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();//quantidade de linhas usadas
            int linhaRegistro = qtdLinhas + 1;
            plan1.Cell(linhaRegistro,1).Value = linhaRegistro;
            plan1.Cell(linhaRegistro,2).Value = txtNome.Text;
            plan1.Cell(linhaRegistro,3).Value = txtRg.Text;
            plan1.Cell(linhaRegistro,4).Value = txtCpf.Text;

            //salvar o registro
            pasta.Save();
            MessageBox.Show("SALVO COM SUCESSO!!!"); 
            txtNome.Clear();txtCpf.Clear();txtRg.Clear();
            txtNome.Focus();


        }
    }
}
