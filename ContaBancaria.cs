using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista_2
{
    internal class ContaBancaria
    {
        private string titular;
        private double saldo;

        public ContaBancaria()
        {

        }

        public double Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Você não tem esse valor na conta!");
                return -1;
            }
            else
            {
                saldo =- valor;
                return valor;
            }
                
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"O valor de R${valor} foi depositado na conta, totalizando o valor de R${saldo} reais.");
            }
            else
                Console.WriteLine("Digite um valor real!");
        }

        public double ExibirSaldo()
        {
            return Saldo;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
    }
}

