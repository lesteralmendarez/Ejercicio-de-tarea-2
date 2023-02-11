using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIODETAREA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void PROMEDIObutton_Click(object sender, EventArgs e)
        {
            // definicion y lecturas de las variables que se utilizaran 
            decimal parcial1 = Convert.ToDecimal (PARCIAL1textBox.Text);
            decimal parcial2 = Convert.ToDecimal(PARCIAL2textBox.Text);
            decimal parcial3 = Convert.ToDecimal(PARCIAL3textBox.Text);
            decimal parcial4 = Convert.ToDecimal(PARCIAL4textBox.Text);

            // llamamiento de la funcion con sus respectivos parametros
            decimal promedio = await PromediarAsync( parcial1, parcial2, parcial3,  parcial4);
            // mensaje de impresion para ver el promedio en pantalla
            MessageBox.Show($"EL PROMEDIO DEL ESTUDIANTE ES :{promedio}");

            }
        //función asíncrona que permita devolver el resultado final del Promedio
        private async Task<decimal> PromediarAsync(decimal parcial1, decimal parcial2, decimal parcial3, decimal parcial4) {

            decimal promedio = await Task.Run(() => {

                //operacion aritmetica para calcular promedio
                return ((parcial1 + parcial2 + parcial3 + parcial4) / 4);
            
            
            });


            return promedio;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
