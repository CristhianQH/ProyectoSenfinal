using System;
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
    public partial class InicioUsuario : Form
    {
        public InicioUsuario()
        {
            InitializeComponent();
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

        private void btnTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalUser principal = new PrincipalUser();
            principal.ShowDialog();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteUser cliente = new ClienteUser();
            cliente.ShowDialog();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipoUser equipo = new EquipoUser();
            equipo.ShowDialog();
        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {
            //copiar aqui
           IntPtr region = CreateRoundRectRgn(0, 0, btnRegistrarC.Width, btnRegistrarC.Height, 30, 30);
            SetWindowRgn(btnRegistrarC.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnRegistrarE.Width, btnRegistrarE.Height, 30, 30);
            SetWindowRgn(btnRegistrarE.Handle, region1, true);


            IntPtr region2 = CreateRoundRectRgn(0, 0, btnTareas.Width, btnTareas.Height, 30, 30);
            SetWindowRgn(btnTareas.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnCSesion.Width, btnCSesion.Height, 30, 30);
            SetWindowRgn(btnCSesion.Handle, region3, true);

            IntPtr region4 = CreateRoundRectRgn(0, 0, btnAsignar.Width, btnAsignar.Height, 30, 30);
            SetWindowRgn(btnAsignar.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30);
            SetWindowRgn(panel3.Handle, region5, true);



        }

        private void btnCSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login equipo = new Login();
            equipo.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarReUser reporte = new AsignarReUser();
            reporte.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
