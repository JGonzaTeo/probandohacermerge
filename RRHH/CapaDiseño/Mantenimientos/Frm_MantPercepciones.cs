﻿using CapaDiseño.Consulta;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantPercepciones : Form
    {
        string slocalIP;
        string smacAddresses;
        string suser;
        string tipopermiso;
        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
               if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }               
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }        

        Logica logic = new Logica();
        public Frm_MantPercepciones(String susuario,String permiso)
        {
            InitializeComponent();

            Cbo_estado.Items.Add("Activo");
            Cbo_estado.Items.Add("Inactivo");

            bloquear();
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            Btn_consultar.Enabled = false;
            Txt_Cod.Text= logic.siguiente("concepto", "pkcodigoconcepto");
            obtenerip();
            // MessageBox.Show(susuario);
            suser = susuario;
            tipopermiso = permiso;
        }
        public void bloquear()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Saldo.Enabled = false;
            Cbo_estado.Enabled = false;
            Cbo_tipo.Enabled = false;
            Cbo_tipooperacion.Enabled = false;
        }
        public void desbloquear()
        {
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_Saldo.Enabled = true;
            Cbo_estado.Enabled = true;
            Cbo_tipo.Enabled = true;
            Cbo_tipooperacion.Enabled = true;
        }
        public void permisos()
        {
            if (tipopermiso == "1111")
            {
                //todos
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "1001")
            {
                //Guardar
                Btn_guardar.Enabled = true;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "0101")
            {
                //modificar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "0011")
            {
                //eliminar
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                desbloquear();
            }
            if (tipopermiso == "0001")
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_ingresar.Enabled = false;
                Btn_consultar.Enabled = true;
            }
        }
        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Txt_Saldo.Text = "";
            Cbo_estado.Text = "";
            Cbo_tipo.Text = "";
            Cbo_tipooperacion.Text = "";

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta="";
            string indice="";
          
                OdbcDataReader mostrarEmpleado = logic.consultaayuda("1");
                try
                {
                    while (mostrarEmpleado.Read())
                    {
                    ruta = mostrarEmpleado.GetString(1);
                    indice = mostrarEmpleado.GetString(2);
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

              Help.ShowHelp(this, ruta, indice);
            //Help.ShowHelp(this, "Ayudas Mant/ayudasrrhh.chm", "Conceptos.html");
         



        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarconcepto(Txt_Cod.Text,Txt_nombre.Text,Cbo_tipo.Text,Txt_Saldo.Text,Cbo_tipooperacion.Text,Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.siguiente("concepto", "pkcodigoconcepto");
           
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            permisos();
           
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarConcepto(Txt_Cod.Text, Txt_nombre.Text, Cbo_tipo.Text, Txt_Saldo.Text, Cbo_tipooperacion.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarconcepto(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            limpiar();
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Cbo_tipo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Saldo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_tipooperacion.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                     Cells[5].Value.ToString();
            }
        }

        private void Txt_Cod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_tipooperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cbo_estado.Items.Add("1");
            Cbo_estado.Items.Add("0");
        }
    }
}
