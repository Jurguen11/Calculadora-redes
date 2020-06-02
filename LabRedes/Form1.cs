using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRedes
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        Double accHost1;
        Double accHost2;
        Double accHost3;
        String ip = "";
        public void mostrarIDRed(Double catSubNet, Double numSubNet)
        {
            accHost1 = 0;
            accHost2 = 0;
            accHost3 = 0;
            for (int i = 0; i < numSubNet; i++)
            {
                if (textBox_Clase.Text.Equals("A"))
                {
                    ip = textBox_IP1.Text + "." + Convert.ToString(accHost1) + "." + Convert.ToString(accHost2) + "." + Convert.ToString(accHost3);
                    accHost1 = accHost1 + catSubNet;
                }
                else if (textBox_Clase.Text.Equals("B"))
                {
                    ip = textBox_IP1.Text + "." + textBox_IP2.Text + "." + Convert.ToString(accHost2) + "." + Convert.ToString(accHost3);
                    accHost2 = accHost2 + catSubNet;
                }
                else if (textBox_Clase.Text.Equals("C"))
                {
                    ip = textBox_IP1.Text + "." + textBox_IP2.Text + "." + textBox_IP3.Text + "." + Convert.ToString(accHost3);
                    accHost3 = accHost3 + catSubNet;
                }

                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = i;
                grid.Rows[i].Cells[1].Value = ip;

            }
        }

        String ip1 = "";
        String ip2 = "";
        public void mostrarRango(Double numSubNet, Double catSubNet)
        {
            accHost1 = 0;
            accHost2 = 0;
            accHost3 = 0;

            for (int i = 0; i < numSubNet; i++)
            {
                if (textBox_Clase.Text.Equals("A"))
                {
                    ip1 = textBox_IP1.Text + "." + Convert.ToString(accHost1) + "." + Convert.ToString(accHost2) + "." + Convert.ToString(accHost3 + 1);
                    accHost1 = accHost1 + catSubNet;
                    ip2 = textBox_IP1.Text + "." + Convert.ToString(accHost1 - 1) + "." + Convert.ToString(accHost2 + 255) + "." + Convert.ToString((accHost3 + 255) - 1);
                }
                else if (textBox_Clase.Text.Equals("B"))
                {
                    ip1 = textBox_IP1.Text + "." + textBox_IP2.Text + "." + Convert.ToString(accHost2) + "." + Convert.ToString(accHost3 + 1);
                    accHost2 = accHost2 + catSubNet;
                    ip2 = textBox_IP1.Text + "." + textBox_IP2.Text + "." + Convert.ToString(accHost2 - 2) + "." + Convert.ToString((accHost3 + 255) - 1);
                }
                else if (textBox_Clase.Text.Equals("C"))
                {
                    ip1 = textBox_IP1.Text + "." + textBox_IP2.Text + "." + textBox_IP3.Text + "." + Convert.ToString(accHost3 + 1);
                    accHost3 = accHost3 + catSubNet;
                    ip2 = textBox_IP1.Text + "." + textBox_IP2.Text + "." + textBox_IP3.Text + "." + Convert.ToString(accHost3 - 2);
                }

                String rangoIPs = ip1 + " -- " + ip2;
                grid.Rows.Add();
                grid.Rows[i].Cells[2].Value = rangoIPs;

            }

        }

        public void mostrarSubNet(double miSubNet)
        {
            for (int i = 0; i < miSubNet; i++)
            {
                grid.Rows[i + 1].DefaultCellStyle.BackColor = Color.SpringGreen;
            }
        }

        public void mostrarDireccionesDifusion(Double numSubNet, Double catSubNet)
        {
            accHost1 = 0;
            accHost2 = 0;
            accHost3 = 0;
            for (int i = 0; i < numSubNet; i++)
            {
                if (textBox_Clase.Text.Equals("A"))
                {
                    accHost1 = accHost1 + catSubNet;
                    ip = textBox_IP1.Text + "." + Convert.ToString(accHost1 - 1) + "." + Convert.ToString(accHost3 + 255) + "." + Convert.ToString(accHost3 + 255);
                }
                else if (textBox_Clase.Text.Equals("B"))
                {
                    accHost2 = accHost2 + catSubNet;
                    ip = textBox_IP1.Text + "." + textBox_IP2.Text + "." + Convert.ToString(accHost2 - 1) + "." + Convert.ToString(accHost3 + 255);
                }
                else if (textBox_Clase.Text.Equals("C"))
                {
                    accHost3 = accHost3 + catSubNet;
                    ip = textBox_IP1.Text + "." + textBox_IP2.Text + "." + textBox_IP3.Text + "." + Convert.ToString(accHost3 - 1);
                }
                grid.Rows.Add();
                grid.Rows[i].Cells[3].Value = ip;

            }
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {

        }
    }
}