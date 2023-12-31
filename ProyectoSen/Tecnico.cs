﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWithEllipse,
           int nHeightEllipse
                );
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.DeleteTecnico(txtId);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.modificarTecnico(txtId, txtNombre, txtApellido, txtDni, txtTelefono, txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.guardarTecnico(txtNombre, txtApellido, txtDni, txtTelefono, txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.ResetTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin formularioP = new InicioAdmin();
            formularioP.ShowDialog();
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void Tecnico_Load(object sender, EventArgs e)
        {

            IntPtr region = CreateRoundRectRgn(0, 0, btnReset.Width, btnReset.Height, 30, 30);
            SetWindowRgn(btnReset.Handle, region, true);


            IntPtr region1 = CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 30, 30);
            SetWindowRgn(btnSave.Handle, region1, true);


            IntPtr region2 = CreateRoundRectRgn(0, 0, btnModificar.Width, btnModificar.Height, 30, 30);
            SetWindowRgn(btnModificar.Handle, region2, true);


            IntPtr region3 = CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30);
            SetWindowRgn(btnClear.Handle, region3, true);


            IntPtr region4 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30);
            SetWindowRgn(panel1.Handle, region5, true);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
