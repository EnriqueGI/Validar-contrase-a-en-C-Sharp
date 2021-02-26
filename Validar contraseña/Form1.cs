using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Te estan entrevistando para unirte a un equipo de seguridad. Quieren que crees un evaluador de contraseñas para su entrevista técnica para validar la entrada.

 Tarea: Escriba un programa que tome una cadena como entrada y la evalúe como una contraseña válida. 
La contraseña es válida si tiene como mínimo 2 números, 2 de los siguientes caracteres especiales ('!', '@', '#', '$', '%', '&', '*'), Y una longitud de al menos 7 caracteres. Si la contraseña pasa la verificación, la salida 'Fuerte', de lo contrario la salida 'Débil'. 
Formato de entrada: Una cadena que representa la contraseña a evaluar. 
Formato de salida: Una cadena que dice "Fuerte" si la entrada cumple con los requisitos, o "Débil", si no. Entrada de muestra: Hola @ $ World19 Salida de muestra: Fuerte

 */





namespace Validar_contraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = textBox1.Text;

            int totalNumeros = 0;
            int totalEspecial = 0;
            int n;
            bool result;
            



             for (int i = 0; i < contraseña.Length; i++)
             {

                char l = contraseña.ElementAt(i);
                result = Int32.TryParse(l.ToString(), out n);
                if (result)
                 {
                     totalNumeros++;
                 }
                 if (l.ToString()=="!" || l.ToString()=="@" || l.ToString()=="#" || l.ToString()=="$" || l.ToString()=="%" || l.ToString()=="&" || l.ToString()=="*")
                 {
                     totalEspecial++;
                 }


             }
           

             if (contraseña.Length <= 6 || totalNumeros <= 1 || totalEspecial <= 1)
             {
                 label2.Text = "contrasela debil";
             }
             else
             {
                 label2.Text = "Es una buena contraseña";
             }

         
        }

        }
    }
