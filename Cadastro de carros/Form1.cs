using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_carros
{
    public partial class frmCadastroCarros : Form
    {
        public frmCadastroCarros()
        {
            InitializeComponent();
        }

        private void frmCadastroCarros_Load(object sender, EventArgs e)
        {
            dtpDataCompra.Value = new DateTime(1990, 01, 01);
            mtbPlaca.Text = " - ";
        }

        private void btnAdiconarCarro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();

            cad.Placa = mtbPlaca.Text;
            cad.Modelo = txtModelo.Text;
            cad.Marca = mtbMarca.Text;
            cad.Dono = txtDono.Text;
            cad.Ano = int.Parse(mtbAno.Text);
            cad.DataCompra = dtpDataCompra.Value;

            cad.Registrar();

            MessageBox.Show(" Seu Registro Foi Efetuado com sucesso! ");
            LimparTela();
            mtbPlaca.Text = "";
            txtModelo.Text = "";
            mtbMarca.Text = "";
            txtDono.Text = "";
            dtpDataCompra.Value = new DateTime(1990, 01, 01);
        }
       
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string placa = mtbPlaca.Text;
            Cadastro cad = new Cadastro();
            ok = cad.Procurar(placa);

            if (ok)
            {
                mtbPlaca.Text = cad.Placa;
                txtModelo.Text = cad.Modelo;
                mtbMarca.Text = cad.Marca;
                txtDono.Text = cad.Dono;
                mtbAno.Text = cad.Ano.ToString();
                dtpDataCompra.Value = cad.DataCompra;
            }
            else
            {
                MessageBox.Show(" a Placa do Veículo Informada não está Cadastrada ou o Vaículo não Foi Encontrado! ");
            }
        }

        private void LimparTela()
        {
            mtbPlaca.Text = "";
            txtModelo.Text = "";
            mtbMarca.Text = "";
            txtDono.Text = "";
            dtpDataCompra.Value = new DateTime(1990, 01, 01);
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            txtLista.Text = cad.ListaTudo();
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbMarca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
