using LaboratorioFinal.Data;
using LaboratorioFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LaboratorioFinal
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();
        model  usr = new model();
        List<model> todos = new List<model>();
        ClsCursor cursor1 = new ClsCursor();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            todos = Clscone.ObtenerTodosLosUsuarios();
            dataGridView1.DataSource = todos;
            if (todos.Count > 0)
            {
                cursor1.totalRegistros = todos.Count;
                //cursor1.current = 0;
                //MostrarRegistros();
                MessageBox.Show("Total de registros: " + cursor1.totalRegistros);
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
          
        }

        private void buttonIngresarDatos_Click(object sender, EventArgs e)
        {
            usr.nombre_consola = textBoxNombreConsola.Text;
            usr.compania  = textBoxCompania.Text;
            usr.anio_lanzamiento  = dateTimePickerAnioLanzamiento.Value;
            usr.generacion  = decimal.Parse(textBoxGeneracion.Text);
            Clscone.Insertar(usr);
            MessageBox.Show("El registro se agrego correctamente");
        }

        private void MostrarRegistros()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                model u = todos[cursor1.current];
                textBoxIdConsola.Text = u.id_consola.ToString();
                textBoxNombreConsola.Text = u.nombre_consola;
                textBoxCompania.Text = u.compania ;
                dateTimePickerAnioLanzamiento.Value = u.anio_lanzamiento;
                textBoxGeneracion.Text = u.generacion.ToString();
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }
    }
}
