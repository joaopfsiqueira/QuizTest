using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            if(p1Correta.Checked == true)  //checked é checado.
            {
                resultado = resultado + 5;
                lbl1Incorretas.Text = "Resposta Correta";
            }else{
                lbl1Incorretas.Text = "Resposta incorreta";
            }

            if(p2Correta.Checked == true) 
            {
                resultado = resultado + 5;
                lbl2Incorretas.Text = "Resposta Correta";
            } else
            {
                lbl2Incorretas.Text = "Resposta Incorreta";
            }

            lblResultado.Text = resultado.ToString();

        }
    }
}
