using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace AppExemploExcel.Formularios
{
    public partial class FormListar : Form
    {
        public FormListar()
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
                dataGridView1.Rows.Add(plan1.Cell(linha, 1).Value,
                                       plan1.Cell(linha, 2).Value,
                                       plan1.Cell(linha, 3).Value,
                                       plan1.Cell(linha, 4).Value);  
            }
        }
    }
}
