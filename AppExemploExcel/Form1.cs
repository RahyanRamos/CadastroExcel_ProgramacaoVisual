using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemploExcel.Formularios;

namespace AppExemploExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar frm = new FormCadastrar();    
            frm.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListar frm = new FormListar();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormListarObjetos frm = new FormListarObjetos();
            frm.ShowDialog();
        }

        private void btExemploObjeto_Click(object sender, EventArgs e)
        {
            FormObjetos frm = new FormObjetos();
            frm.ShowDialog();
        }
    }
}
