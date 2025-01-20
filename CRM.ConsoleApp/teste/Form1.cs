using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        List<Empresa> listaEmpresa;
        public Form1()
        {
            InitializeComponent();

            listaEmpresa = new List<Empresa>();

            comboEstado.Items.Add("Paraná");
            comboEstado.Items.Add("Santa Catarina");
            comboEstado.Items.Add("Rio Grande do sul");
            comboEstado.Items.Add("São Paulo");
            comboEstado.Items.Add("Roraima");

            // vai mostar Prana ja de Inicio pusca pelo Indexação
            comboEstado.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            comboEstado.SelectedIndex = 0;
            txtTelefone.Text = "";
            checkMultinacional.Checked = false;
            checkNacional.Checked = false;
            radioHospitalar.Checked = false;
            radioMetalurgica.Checked = true;
            radioMontadora.Checked = false;
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            //VERIFICAR SE EMPRESA JA CADASTRADA
            foreach (Empresa em in listaEmpresa) 
            {
                //SE NOME EMPRESA FOR NOME DO NOVO CADASTRO JA CADASTRADO
                if (em.Nome == txtNome.Text) 
                {
                    index = listaEmpresa.IndexOf(em);
                }
            }
            //CONDIÇÃO PARA VERIFICAR CAMPO OBRIGATORIO
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome.");
                txtNome.Focus();//VAI FICAR EM FOCO CHAMANDO ATENÇÃO
                return;//finalizar metodo devido erro
            }

            //CONDIÇÃO PARA VERIFICAR CAMPO OBRIGATORIO
            if (txtTelefone.Text == "(  )       - ")
            {
                MessageBox.Show("Preencha o Campo Telefone.");
                txtTelefone.Focus();//VAI FICAR EM FOCO CHAMANDO ATENÇÃO
                return;//finalizar metodo devido erro
            }
            //VERIFICAR CHECK
            char segmento;

            if (radioMetalurgica.Checked)
            {
                segmento = 'M';
            }
            else if (radioHospitalar.Checked)
            {
                segmento = 'H';
            }
            else 
            {
                segmento = 'A';
            }

            Empresa empresa = new Empresa();
            empresa.Nome = txtNome.Text;
            empresa.DataNascimento = txtData.Text;
            empresa.Estado = comboEstado.SelectedItem.ToString();
            empresa.Telefone = txtTelefone.Text;
            empresa.Nacional = checkNacional.Checked;
            empresa.Multinacional = checkMultinacional.Checked;
            empresa.Segmento = segmento;

            //VERIFICAÇAO NOVA EMPRESA OU EXIGENTE
            //SE INDEX FOR MAIOR 0 ADICONAR NOVA EMPRESA
            if (index < 0) 
            {
                listaEmpresa.Add(empresa);
            }
            else 
            {
                listaEmpresa[index] = empresa;
            }

            button1_Click_1(btnLimpar, EventArgs.Empty);

            Listar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            listaEmpresa.RemoveAt(indice);
            Listar();
        }

        private void Listar() 
        {
            lista.Items.Clear();

            foreach (Empresa e in listaEmpresa) 
            {
                lista.Items.Add(e.Nome);
            }
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Empresa empresa = listaEmpresa[indice];

            txtNome.Text = empresa.Nome;
            txtData.Text = empresa.DataNascimento;
            comboEstado.SelectedItem = empresa.Estado;
            txtTelefone.Text = empresa.Telefone;
            checkMultinacional.Checked = empresa.Multinacional;
            checkNacional.Checked = empresa.Nacional;

            switch (empresa.Segmento) 
            {
                case 'M':
                    radioMetalurgica.Checked = true;
                    break;
                case 'H':
                    radioHospitalar.Checked = false;
                    break;
                default:
                    radioMontadora.Checked = false;
                    break;
            }

        }
    }
}
