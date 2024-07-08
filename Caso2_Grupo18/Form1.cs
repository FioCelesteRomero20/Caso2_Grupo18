using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso2_Grupo18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatosACargar();
        }

        public class EF_Grupo18
        {
            //creamos sus atributos...
            public string Nombre_Grupo18 { get; set; }
            public string Fecha_Grupo18 { get; set; }
            public bool G_o_P_Grupo18 { get; set; }
            public int Puntos_Grupo18 { get; set; }
            public string Resultado_Grupo18 => G_o_P_Grupo18 ? "Ganado" : "Perdido";
            //Asignamos atributos con variable llamando al constructor...
            public EF_Grupo18(string nombre_Grupo18, string sfecha_Grupo18, bool g_o_p_Grupo18, int puntos_Grupo18)
            {
                Nombre_Grupo18 = nombre_Grupo18;
                Fecha_Grupo18 = sfecha_Grupo18;
                G_o_P_Grupo18 = g_o_p_Grupo18;
                Puntos_Grupo18 = puntos_Grupo18;
            }

            public override string ToString()
            {
                return $"{Nombre_Grupo18},{Fecha_Grupo18},{G_o_P_Grupo18},{Puntos_Grupo18}";
            }

        }

        private const string FiloPath = "base_de_informacion.txt";
        private int totalPuntos_Grupo18;

        private void GuardarRegistro(EF_Grupo18 eF_Grupo18)
        {
            try
            {
                using (StreamWriter esc_Grupo18 = new StreamWriter(FiloPath, true))
                {
                    esc_Grupo18.WriteLine(eF_Grupo18.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Estan en error los datos registrados " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosACargar()
        {
            if (File.Exists(FiloPath))
            {
                try
                {
                    string[] lin_Grupo18 = File.ReadAllLines(FiloPath);
                    // Para que podamos leer cada dato del txt es necesario recorrer una linea ...
                    foreach (string l_Grupo18 in lin_Grupo18)
                    {
                        string[] p_Grupo18 = l_Grupo18.Split('.');
                        if (p_Grupo18.Length == 4)
                        {
                            string nombreJuego_Grupo18 = p_Grupo18[0];
                            string sfecha_Grupo18 = p_Grupo18[1];
                            bool ganado_Grupo18 = bool.Parse(p_Grupo18[2]);
                            int puntos_Grupo18 = int.Parse(p_Grupo18[3]);

                            //Para recuperar los datos, creamos un objeto de la clase
                            EF_Grupo18 eF_Grupo18 = new EF_Grupo18(nombreJuego_Grupo18, sfecha_Grupo18, ganado_Grupo18, puntos_Grupo18);
                            // Vemos los datos de DateGriedView
                            dgvRegistroVideojuego.Rows.Add(eF_Grupo18.Nombre_Grupo18, eF_Grupo18.Fecha_Grupo18, eF_Grupo18.Resultado_Grupo18, eF_Grupo18.Puntos_Grupo18);
                            // Cargamos el total de puntos
                            totalPuntos_Grupo18 += puntos_Grupo18;
                        }
                    }
                    // Vemos los puntos totales...
                    lblPuntosTotales.Text = "Total de Puntos: " + totalPuntos_Grupo18.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se detectó un error en los datos cargados, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarDatos(string nombreJuego_Grupo18)
        {
            try
            {
                string[] l_Grupo18 = File.ReadAllLines(FiloPath);
                using (StreamWriter registro = new StreamWriter(FiloPath, false))
                {
                    foreach (string li_Grupo18 in l_Grupo18)
                    {
                        string[] s_partes_Grupo18 = li_Grupo18.Split('.');
                        if (s_partes_Grupo18.Length == 4 && s_partes_Grupo18[0] != nombreJuego_Grupo18)
                        {
                            registro.WriteLine(li_Grupo18);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se detectó un error en los datos para eliminar " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreJuego_Grupo18 = textBox2.Text.Trim();
                bool ganado_Grupo18 = RButtGane.Checked;
                string sfecha_Grupo18 = DateTime.Now.ToString("dd/MM/yyyy");

                //No permitir el ingreso de valores vacios
                if (string.IsNullOrWhiteSpace(nombreJuego_Grupo18))
                {
                    throw new ArgumentException();
                }
                //Almacenamos los puntos
                int puntos_Grupo18;
                if (ganado_Grupo18 == true)
                {
                    puntos_Grupo18 = 100;
                }
                else
                {
                    puntos_Grupo18 = -20;
                }
                totalPuntos_Grupo18 += puntos_Grupo18;

                //Ingresamos los parametros correspondientes...
                EF_Grupo18 eF_Grupo18 = new EF_Grupo18(nombreJuego_Grupo18, sfecha_Grupo18, ganado_Grupo18, puntos_Grupo18);

                // Guardamos los datos en el texto que elegimos ...
                GuardarRegistro(eF_Grupo18);

                //Registramos los datos en DateGriedView
                dgvRegistroVideojuego.Rows.Add(eF_Grupo18.Nombre_Grupo18, eF_Grupo18.Fecha_Grupo18, eF_Grupo18.Resultado_Grupo18, eF_Grupo18.Puntos_Grupo18);

                //Imprimimos con los puntos acumulados
                lblPuntosTotales.Text = "Total de Puntos: " + totalPuntos_Grupo18.ToString();

                //Limpiamos
                textBox2.Text = "";
                RButtGane.Checked = true;

            }
            catch 
            { 
               MessageBox.Show("Ingrese el nombre del videojuego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }


        private void RButtGane_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textNewEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
