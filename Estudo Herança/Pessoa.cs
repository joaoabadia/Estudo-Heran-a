using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Herança
{
    internal class Pessoa
    {
        public string primeiroNome;
        public string endereco;
        public string telefone;


        public string Nome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }

        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }



    }

    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }


    class PessoaJuridica : Pessoa
    {
        public string CNPJOTO { get; set; }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica
            {
                Nome = "João",
                Endereco = "Rua Real Grandeza, 231",
                Telefone = "31 996696136",
                CPF = "11606573608"
            };



            PessoaJuridica pessoaJuridica = new PessoaJuridica
            {
                Nome = "JJ Produções",
                Endereco = "Rua Real Grandeza, 231",
                Telefone = "31 975146136",
                CNPJOTO = "11606573608"
            };

            Console.WriteLine("Pessoa Fisica: ");
            Console.WriteLine("Nome: " + pessoaFisica.Nome);
            Console.WriteLine("Endereço: " + pessoaFisica.Endereco);
            Console.WriteLine("Telefone: " + pessoaFisica.Telefone);
            Console.WriteLine("CPF: " + pessoaFisica.CPF);

            Console.WriteLine("\nPessoa Jurídica:");
            Console.WriteLine("Nome: " + pessoaJuridica.Nome);
            Console.WriteLine("Endereço: " + pessoaJuridica.Endereco);
            Console.WriteLine("Telefone: " + pessoaJuridica.Telefone);
            Console.WriteLine("CNPJ: " + pessoaJuridica.CNPJOTO);



        }
    }
}
