﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace SystemPrestamos
{
   
    public partial class RegistroClientes : Form
       
    {
        
        public RegistroClientes()
        {
            InitializeComponent();
        }

        

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (idCtextBox.TextLength > 0)
            {
                Clientes cliente = new Clientes();
                cliente.ClienteId = int.Parse(idCtextBox.Text);
                if (cliente.Eliminar())
                {
                    MessageBox.Show("Cliente ha sido Eliminado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Eliminado");
                }

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            idCtextBox.Clear();
            nombreCtextBox.Clear();
            apellidoCtextBox.Clear();
            apodoCtextBox.Clear();
            direccionCtextBox.Clear();
            referenciaCtextBox.Clear();
            cedulaCtextBox.Clear();
            telefonoCtextBox.Clear();
            celularCtextBox.Clear();
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (nombreCtextBox.TextLength == 0 || apellidoCtextBox.TextLength == 0 || apodoCtextBox.TextLength == 0 || direccionCtextBox.TextLength == 0)
            {
                MessageBox.Show("No puede dejar ningun campo vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (idCtextBox.TextLength == 0)
            {
                cliente.Nombres = nombreCtextBox.Text;
                cliente.Apellidos = apellidoCtextBox.Text;
                cliente.Apodos = apodoCtextBox.Text;
                cliente.Direccion = direccionCtextBox.Text;
                cliente.Referencia = referenciaCtextBox.Text;
                if (MasculinoradioButton.Checked)
                {
                    cliente.Sexo = 1;
                }
                else
                {
                    cliente.Sexo = 0;
                }
                
                cliente.Cedula = cedulaCtextBox.Text;
                cliente.Telefono = telefonoCtextBox.Text;
                cliente.Celular = celularCtextBox.Text;
                if (cliente.Insertar())
                {
                    MessageBox.Show("Cliente ha sido Registrado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Registrado");
                }
            }
            else if (idCtextBox.TextLength > 0)
            {
                cliente.ClienteId = int.Parse(idCtextBox.Text);
                cliente.Nombres = nombreCtextBox.Text;
                cliente.Apellidos = apellidoCtextBox.Text;
                cliente.Apodos = apodoCtextBox.Text;
                cliente.Direccion = direccionCtextBox.Text;
                cliente.Referencia = referenciaCtextBox.Text;
                if (MasculinoradioButton.Checked)
                {
                    cliente.Sexo = 1;
                }
                else
                {
                    cliente.Sexo = 0;
                }
                cliente.Cedula = cedulaCtextBox.Text;
                cliente.Telefono = telefonoCtextBox.Text;
                cliente.Celular = celularCtextBox.Text;
                if (cliente.Editar())
                {
                    MessageBox.Show("Cliente ha sido Editado");
                }
                else
                {
                    MessageBox.Show("Cliente no ha sido Editado");
                }
            }
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            if (idCtextBox.TextLength == 0)
            {
                ErrorProvider error = new ErrorProvider();
                error.Clear();
                error.SetError(idCtextBox, "Debe especificar el id");
            }
            else
            if (cliente.Buscar(int.Parse(idCtextBox.Text)))
            {

                nombreCtextBox.Text = cliente.Nombres;
                apellidoCtextBox.Text = cliente.Apellidos;
                apodoCtextBox.Text = cliente.Apodos;
                direccionCtextBox.Text = cliente.Direccion;
                referenciaCtextBox.Text = cliente.Referencia;
                if (cliente.Sexo==1)
                {
                    MasculinoradioButton.Checked = true;

                }else
                {
                    FemeninoradioButton.Checked = true;
                }
                cedulaCtextBox.Text = cliente.Cedula;
                celularCtextBox.Text = cliente.Celular;
            }
            else
            {
                MessageBox.Show("ID no Existe");
            }
        }

        private void sexoCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void celularCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void telefonoCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void referenciaCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apodoCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FemeninoradioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nombreCtextBox_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void nombreCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void apellidoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void apodoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Letras(e);
        }

        private void idCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void cedulaCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void telefonoCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }

        private void celularCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Validacion v = new Validacion.Validacion();
            v.Numeros(e);
        }
    }
}
