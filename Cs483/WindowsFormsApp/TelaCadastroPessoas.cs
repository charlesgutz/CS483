using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class TelaCadastroPessoas : Form
    {
        List<PessoaFisica> listaPf = new List<PessoaFisica>();
        List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

        public TelaCadastroPessoas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;


            if ()
            {
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = nome;
                pf.Idade = 25;
                pf.CPF = "055.477.857-44";
                listaPf.Add(pf);
            }
            else
            {
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = nome;
                pj.Idade = 1;
                pj.CNPJ = "05.136.888/0001-09";
                listaPj.Add(pj);
            }
            

           
        }
    }
}
