using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2___ATIVIDADE_NOTA
{
    public partial class Form1 : Form
    {
        string[] categorias =
        {
            "Livros",
            "Papelaria",
            "Eletronicos",
            "Filmes"
        };

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(categorias);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) &&
            !String.IsNullOrEmpty(textBox2.Text) &&
            !String.IsNullOrEmpty(textBox3.Text) &&
            !String.IsNullOrEmpty(textBox4.Text) &&
            !String.IsNullOrEmpty(textBox5.Text) &&
            !String.IsNullOrEmpty(textBox6.Text) &&
            !String.IsNullOrEmpty(textBox7.Text) &&
            !String.IsNullOrEmpty(comboBox1.Text))
            {
                ListViewItem itens = new ListViewItem(textBox1.Text);
                itens.SubItems.Add(textBox2.Text);
                itens.SubItems.Add(textBox3.Text);
                itens.SubItems.Add(textBox4.Text);
                itens.SubItems.Add(textBox5.Text);
                itens.SubItems.Add(comboBox1.Text);
                itens.SubItems.Add(textBox6.Text);
                itens.SubItems.Add(textBox7.Text);
                itens.SubItems.Add(dateTimePicker1.Value.ToString());
                if (radioButton1.Checked)
                {
                    itens.SubItems.Add(radioButton1.Text);
                }
                if (radioButton2.Checked)
                {
                    itens.SubItems.Add(radioButton2.Text);
                }
                listView1.Items.Add(itens);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                dateTimePicker1.Value = DateTime.Now.Date;
                radioButton1.Checked = true;

            } 
                else
            {
                MessageBox.Show("Preencha os campos!");
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
