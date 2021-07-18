using System;

namespace dell_aula_2._3
{
    class Program
    {
        static void Main(string[] args)
        {


            
        }

        public class PessoaFisica:Pessoa
        {            
            private String cpf;

            public void setCpf(String valorCpf)
            {
                cpf = valorCpf;
            }

            public String getCpf()
            {
                return cpf;
            }

        }
        public class PessoaJuridica : Pessoa
        {
            private String cnpj;

            public void setCnpj(String valorCnpj)
            {
                cnpj = valorCnpj;
            }

            public String getCnpj()
            {
                return cnpj;
            }

        }
        public class Pessoa
        {
            private String nome;
            private int telefone;

            public void setNome(String valorNome)
            {
                nome = valorNome;
            }

            public String getNome()
            {
                return nome;
            }

            public void setTelefone(int valorTelefone)
            {
                telefone = valorTelefone;
            }

            public int getTelefone()
            {
                return telefone;
            }
        }
    }
}
