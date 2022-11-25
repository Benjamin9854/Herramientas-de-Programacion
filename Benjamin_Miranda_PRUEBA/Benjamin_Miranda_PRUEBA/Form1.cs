using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benjamin_Miranda_PRUEBA
{
    public partial class Form1 : Form
    {
        private Cliente[] clientes_registrados = new Cliente[20];
        private int num_client = 0;
        private string atencionesyclientes, clientes, atenciones;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txbox_Rut.Clear();
            txbox_Celular.Clear();
            txbox_Email.Clear();
            txbox_Nombre.Clear();
            txbox_Celular_E.Clear();
            txbox_Email_E.Clear();
            txbox_Nombre_E.Clear();
            chbox_Cabello.Checked = false;
            chbox_Barba.Checked = false;
        }

        private void mostrar(Cliente c, Atencion a)
        {
            string reserva = "NOMBRE: "+c.Nombre + "     RUT: " + c.Rut + "     FECHA: " + a.Fecha +"     HORA: "+ a.Hora + "     TIPO: " + a.TipoAtencion;
            lst_Mostrar.Items.Add(reserva);
            atencionesyclientes += c.Nombre + "," + c.Rut + "," + c.Celular + "," + c.Email + "," + a.Fecha + "," + a.Hora + "," +a.TipoAtencion+ "\n";
            atenciones += a.Fecha + "," + a.Hora + "," + c.Nombre + "\n";
        }

        private Cliente buscarCliente(string RUT)
        {
            for (int i = 0; i < 20; i++)
            {
                if (clientes_registrados[i].Rut == RUT)
                    return clientes_registrados[i];
            }
            MessageBox.Show("CLIENTE NO ENCONTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if ((chbox_Barba.Checked == true || chbox_Cabello.Checked == true) && mthCa_Fecha.SelectionStart >= mthCa_Fecha.TodayDate && (cmbox_Hora.Text != "HORA:" || cmbox_Hora.Text != ""))
            {
                //Crear la atencion
                Atencion a = new Atencion();
                if(chbox_Barba.Checked == true)
                    a.TipoAtencion = chbox_Barba.Text;
                if (chbox_Cabello.Checked == true)
                    a.TipoAtencion = chbox_Cabello.Text;
                if (chbox_Barba.Checked == true && chbox_Cabello.Checked == true)
                    a.TipoAtencion = chbox_Barba.Text +" y "+ chbox_Cabello.Text;
                a.Fecha = mthCa_Fecha.SelectionStart.Date.ToString();
                a.Fecha = a.Fecha.Substring(0, 10);
                a.Hora = cmbox_Hora.Text;


                if (txbox_Rut.Text != "" && txbox_Nombre.Text != "" && txbox_Celular.Text != "" && txbox_Email.Text != "")
                {
                    //Crear el cliente
                    Cliente c = new Cliente();
                    c.Rut = txbox_Rut.Text;
                    c.Nombre = txbox_Nombre.Text;
                    c.Celular = txbox_Celular.Text;
                    c.Email = txbox_Email.Text;


                    //Juntar la atencion con el cliente
                    a.ClienteAtencion = c;
                    c[c.Cantidad] = a;
                    mostrar(c, a);
                    MessageBox.Show("El NUEVO cliente (" + c.Nombre + ") ha sido ingresado exitosamente\nTiene " + c.Cantidad + " reserva(s) en total");

                    //Agregar RUT del cliente al ComboBox y al registro de clientes
                    cmbox_Rut_E.Items.Add(c.Rut);
                    clientes_registrados[num_client] = c;
                    clientes += clientes_registrados[num_client].Rut.ToString()+","+ clientes_registrados[num_client].Nombre.ToString() + "," + clientes_registrados[num_client].Celular.ToString() + "," + clientes_registrados[num_client].Email.ToString() + "\n";
                    num_client++;


                }
                else if (cmbox_Rut_E.SelectedItem != null)
                {
                    //Selecciono un Propietario existente
                    Cliente c = buscarCliente(cmbox_Rut_E.Text);

                    //Juntar la atencion con el cliente
                    a.ClienteAtencion = c;
                    c[c.Cantidad] = a;
                    mostrar(c, a);
                    MessageBox.Show("El cliente (" + c.Nombre + ") ha sido ingresado exitosamente\nTiene " + c.Cantidad + " reserva(s) en total");
                }
                else
                {
                    MessageBox.Show("EL FORMULARIO DEL CLIENTE ESTA INCOMPLETO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if(mthCa_Fecha.SelectionStart < mthCa_Fecha.TodayDate)
                    MessageBox.Show("LA FECHA NO ES FACTIBLE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(cmbox_Hora.Text == "HORA:" || cmbox_Hora.Text == "")
                    MessageBox.Show("DEBE SELECCIONAR UNA HORA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("SELECCIONE AL MENOS UN TIPO DE ATENCION (CABELLO O BARBA)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cmbox_Rut_E.SelectedItem != null)
            {
                Cliente c = buscarCliente(cmbox_Rut_E.Text);
                txbox_Nombre_E.Text = c.Nombre;
                txbox_Celular_E.Text = c.Celular;
                txbox_Email_E.Text = c.Email;
            }
            else
            {
                MessageBox.Show("Seleccione un Rut o ingrese un nuevo cliente");
            }
            
        }

      

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\benja\\Desktop\\atencionesyclientes_" + DateTime.Today.Year.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Day.ToString() + ".csv");

                sw.Write(atencionesyclientes);
                sw.Close();
                MessageBox.Show("Archivo Guardado");
            }
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void crearAficheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAfiche afiche = new frmAfiche();
            afiche.ShowDialog();
        }

        private void atencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\benja\\Desktop\\atenciones_" + DateTime.Today.Year.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Day.ToString() + ".csv");

                sw.Write(atenciones);
                sw.Close();
                MessageBox.Show("Archivo Guardado");
            }
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\benja\\Desktop\\clientes_" + DateTime.Today.Year.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Day.ToString() + ".csv");
                
                sw.Write(clientes);
                sw.Close();
                MessageBox.Show("Archivo Guardado");
            }
            catch (Exception ex) { MessageBox.Show("ERROR: " + ex.Message); }
        }
    }
}
