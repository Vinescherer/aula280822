using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_2808__22
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int i;
        int[] valores = new int[15];
        int[] valores2 = new int[15];


        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               


                for (int i = 0; i < 15; i++)
                {
                    valores[i] = random.Next(-10,10);
                    listBox1.Items.Add(valores[i]);
                    valores2[i] = random.Next(-10,10);
                    listBox2.Items.Add(valores2[i]);
                    listBox3.Items.Add(valores2[i] + valores[i]);


                }

                
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());

            }
        }
    }
}
