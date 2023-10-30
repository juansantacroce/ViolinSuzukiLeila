﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ViolinSuzukiLeila
{
    public partial class FormCargarPersona : Form
    {
        Helper helper;

        public FormCargarPersona()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void rdbAlumno_CheckedChanged(object sender, EventArgs e)
        {
            //Hacer Metodo
            if (rdbAlumno.Checked)
            {
                rdbResponsable.Checked = false;
            }
            dtpFechaNac.Enabled = true;
            txtColegio.Enabled = true;
            cboTipoResponsable.Enabled = false;

        }

        private void rdbResponsable_CheckedChanged(object sender, EventArgs e)
        {
            //Hacer Metodo
            if (rdbResponsable.Checked)
            {
                rdbAlumno.Checked = false;
            }
            dtpFechaNac.Enabled = false;
            txtColegio.Enabled = false;
            cboTipoResponsable.Enabled = true;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //AGREGAR PARAMETROS GENERALES DE PERSONA
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", txtNombre.Text));
            parametros.Add(new Parametro("@apellido", txtApellido.Text));
            parametros.Add(new Parametro("@dni", txtDni.Text));
            parametros.Add(new Parametro("@calle", txtCalle.Text));
            parametros.Add(new Parametro("@altura", txtAltura.Text));
            parametros.Add(new Parametro("@id_ciudad", cboCiudad.SelectedIndex + 1)/*Le sumo 1 por diferencia de indices en SSMS*/);
            parametros.Add(new Parametro("@observaciones", txtObservaciones.Text));


            if (rdbAlumno.Checked == true)
            {
                //AGREGAR PARAMETROS PARTICULARES DE ALUMNO
                parametros.Add(new Parametro("@colegio", txtColegio.Text));
                parametros.Add(new Parametro("@fecha_nac", dtpFechaNac.Value));
                string resultado = helper.Insertar("SP_CARGAR_ALUMNO", parametros);
                MessageBox.Show(resultado, "Atencion!", MessageBoxButtons.OK);
                MessageBox.Show(resultado, "Atencion!",MessageBoxButtons.OK);
            }
            else
            {
                //AGREGAR PARAMETROS PARTICULARES DE RESPONSABLE
                parametros.Add(new Parametro("@id_tipo_responsable", cboTipoResponsable.SelectedValue));
                string resultado = helper.Insertar("SP_CARGAR_RESPONSABLE", parametros);
                MessageBox.Show(resultado, "Atencion!", MessageBoxButtons.OK);
            }
        }

        public void CargarCombo(string nombreTabla, System.Windows.Forms.ComboBox comboBox)
        {
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_" + nombreTabla);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void CargarComboCiudades(int indice)
        {
            Parametro parametro = new Parametro("@id_provincia", indice);
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_CIUDAD", parametro);
            cboCiudad.DataSource = dt;
            cboCiudad.DisplayMember = dt.Columns[1].ColumnName;
            cboCiudad.ValueMember = dt.Columns[0].ColumnName;
            cboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormCargarPersona_Load(object sender, EventArgs e)
        {
            CargarCombo("PROVINCIA", cboProvincia);
        }


        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = cboProvincia.SelectedIndex;
            CargarComboCiudades(idProvincia + 1);/*Le sumo 1 por diferencia de indices en SSMS*/
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
