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
using DocumentFormat.OpenXml.Spreadsheet;

namespace AppExemploExcel.Formularios
{
    public partial class FormObjetos : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        
        public FormObjetos()
        {
            InitializeComponent();
            dataGridView1.DataSource = pessoas.ToList();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Pessoa pessoa = new Pessoa();   
            //objeto preenchido com informações
            pessoa.Id = random.Next();
            pessoa.Nome = txtNome.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Rg = txtRg.Text;
            //colocar o objeto na lista
            pessoas.Add(pessoa);
            //dataGridView1.DataSource = pessoas.ToList();
            dataGridView1.DataSource = pessoas.OrderBy(p=>p.Nome).ToList();

            txtCpf.Clear();
            txtRg.Clear();
            txtNome.Clear();

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = pessoas.Where(p => p.Cpf == txtPesquisa.Text).ToList();
           
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook(@"C:\Users\2023102060010\Documents\testeExcel.xlsx");
            var plan1 = pasta.Worksheet(1);
            int tamanho = pessoas.Count();

            for (int i = 0; i < tamanho; i++)
            {
                int id = pessoas[i].Id;
                string nome = pessoas[i].Nome;
                string cpf = pessoas[i].Cpf;
                string rg = pessoas[i].Rg;

                plan1.Cell(i + 2, 1).Value = id;
                plan1.Cell(i + 2, 2).Value = nome;
                plan1.Cell(i + 2, 3).Value = cpf;
                plan1.Cell(i + 2, 4).Value = rg;
            }
            pasta.Save();
            MessageBox.Show("SALVO COM SUCESSO!!!");
        }
    }
}