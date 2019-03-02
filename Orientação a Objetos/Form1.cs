using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orientação_a_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInserirAgenda.Enabled = false;
            btnAtualizarAgenda.Enabled = false;
            btnPesquisarAgenda.Enabled = false;
            btnDeletarAgenda.Enabled = false;

            txtNomeAgenda.Enabled = false;
            txtRGAgenda.Enabled = false;
            mtxtCPFAgenda.Enabled = false;
            mtxtDataCadastro.Enabled = false;
            mtxtTelefone1.Enabled = false;
            mtxtTelefone3.Enabled = false;
            txtCidadeAgenda.Enabled = false;
            txtBairroAgenda.Enabled = false;
            txtEnderçoAgenda.Enabled = false;
            txtNumeroAgenda.Enabled = false;
            

        }

        private void btnNovoAgenda_Click(object sender, EventArgs e)
        {

            btnInserirAgenda.Enabled = true;
            btnAtualizarAgenda.Enabled = true;
            btnPesquisarAgenda.Enabled = true;
            btnDeletarAgenda.Enabled = true;

            txtNomeAgenda.Enabled = true;
            txtRGAgenda.Enabled = true;
            mtxtCPFAgenda.Enabled = true;
            mtxtDataCadastro.Enabled = true;
            mtxtTelefone1.Enabled = true;
            mtxtTelefone3.Enabled = true;
            txtCidadeAgenda.Enabled = true;
            txtBairroAgenda.Enabled = true;
            txtEnderçoAgenda.Enabled = true;
            txtNumeroAgenda.Enabled = true;

            txtNomeAgenda.Clear();
            txtRGAgenda.Clear();
            mtxtCPFAgenda.Clear();
            mtxtDataCadastro.Clear();
            mtxtTelefone1.Clear();
            mtxtTelefone3.Clear();
            txtCidadeAgenda.Clear();
            txtBairroAgenda.Clear();
            txtEnderçoAgenda.Clear();
            txtNumeroAgenda.Clear();

        }
    }
}
