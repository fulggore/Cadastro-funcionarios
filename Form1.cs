using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    
    public partial class Form1 : Form
    {
         Funcionario func = new Funcionario();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null
                || textBox5.Text == null || textBox6.Text == null || textBox7.Text == null)
            {
                MessageBox.Show("Por favor verifique os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            func.setId(int.Parse(textBox1.Text));
            func.setNome(textBox2.Text);
            func.setCargo(textBox3.Text);
            func.setSalario(float.Parse(textBox4.Text));
            func.setLogradouro(textBox5.Text);
            func.setNumero(textBox6.Text);
            func.setCep(textBox7.Text);
            MessageBox.Show("Dados armazanados com sucesso!!!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label9.Text = "Id: " + func.getId() +
                           "\nNome: " + func.getNome() +
                           "\nCargo: " + func.getCargo() +
                           "\nSalário: " + func.getSalario() +
                           "\n\nEndereço: " +
                           "Logradouro: " + func.getLogradouro() + "," + func.getNumero() +
                           "\nCEP: " + func.getCep();

        }
    }
}
