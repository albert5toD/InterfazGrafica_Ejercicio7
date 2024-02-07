using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtNotaCompletivo.Clear();
            txtPromedio.Clear();
            txtTotal.Clear();
            txtEstado.Clear();
            txtNotaPruebaCompletivo.Text = "0";
            txtNotaPruebaCompletivo.Enabled = false;
            txtPromedio.BackColor = SystemColors.Window;
            txtEstado.BackColor = SystemColors.Window;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4, nota_prueba_completivo = 0;
            double promedio, nota_completivo, total;
            string estado = "";

            //Leer las notas
            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
            nota3 = int.Parse(txtNota3.Text);
            nota4 = int.Parse(txtNota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4.0;

            //Estructura condicional

            if (promedio >= 70)
            {
                estado = "Aprobado";
                txtEstado.BackColor = Color.Green;
                txtPromedio.BackColor = Color.Green;
            }

            else
            {

                txtNotaPruebaCompletivo.Enabled = true;


                nota_completivo = (promedio * 0.5);


                // Leer la nota completivo
                nota_prueba_completivo = int.Parse(txtNotaPruebaCompletivo.Text);
                total = nota_completivo + (nota_prueba_completivo * 0.5);

                    txtTotal.Text = total.ToString();
                    txtNotaCompletivo.Text = nota_completivo.ToString();

                    if (total >= 70)
                    {
                        estado = "Aprobado";
                        txtEstado.BackColor = Color.Green;
                        txtPromedio.BackColor = Color.Green;
                    }
                    else
                    {
                        estado = "Reprobado";
                        txtEstado.BackColor = Color.Red;
                        txtPromedio.BackColor = Color.Red;
                    }
                }

            txtPromedio.Text = promedio.ToString();
            txtEstado.Text = estado;
        }

        }
    }

