using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_carros
{
    class Cadastro
    {
        public String Placa { get; set; }

        public string Modelo { get; set; }

        public string Marca  { get; set; }

        public String Dono { get; set; }

        public int Ano { get; set; }

        public DateTime DataCompra { get; set; }

        

        public void Registrar()
        {
            StreamWriter gravar = new StreamWriter("Registrar.txt", true);

            gravar.WriteLine(Placa);
            gravar.WriteLine(Modelo);
            gravar.WriteLine(Marca);
            gravar.WriteLine(Dono);
            gravar.WriteLine(Ano);
            gravar.WriteLine(DataCompra);
            gravar.WriteLine(" ");

            gravar.Close();
        }


        public bool Procurar (string placa)
        {
            bool ok = false;
            string linha;
            StreamReader ler = new StreamReader("Registrar.txt");

            while(!ler.EndOfStream)
            {
                linha = ler.ReadLine();

                if(linha.ToUpper().Trim() == placa.ToUpper().Trim())
                {
                    linha = ler.ReadLine();
                    Modelo = linha;

                    linha = ler.ReadLine();
                    Marca = linha;

                    linha = ler.ReadLine();
                    Dono = linha;

                    linha = ler.ReadLine();
                    Ano = int.Parse(linha);

                    linha = ler.ReadLine();
                    DataCompra = DateTime.Parse(linha);

                    ok = true;
                    break;
                }
            }

            ler.Close();
            return ok;
        }


        public string ListaTudo()
        {
            string linha, linhaLista = "";
            StreamReader ler = new StreamReader("Registrar.txt");

            while (!ler.EndOfStream)
            {
                linha = ler.ReadLine();

                Placa = linha;

                for (int i = 0; i < 6 ; i++)
                {
                    ler.ReadLine();
                }

                linhaLista = linhaLista + " | " + linha;
            }

            ler.Close();
            return linhaLista;
        }

    }
}
