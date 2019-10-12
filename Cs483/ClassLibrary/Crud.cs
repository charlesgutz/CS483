using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Crud
    {
        //LLISTA DE PESSOAS
        static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();


            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Joao";
            pf.Idade = 25;
            pf.CPF = "055.477.857-44";
            listaPf.Add(pf);

            PessoaJuridica pj = new PessoaJuridica();
            pj.Nome = "Lurax LTDA";
            pj.Idade = 1;
            pj.CNPJ = "05.136.888/0001-09";
            listaPj.Add(pj);                      

        }
    }
}
