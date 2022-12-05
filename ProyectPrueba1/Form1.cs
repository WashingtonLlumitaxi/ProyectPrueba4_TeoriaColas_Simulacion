using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;// move board
namespace ProyectPrueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormFijo(object formfija)
        {
            if (this.PnlCont1.Controls.Count > 0)
                this.PnlCont1.Controls.RemoveAt(0);
            Form fh = formfija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlCont1.Controls.Add(fh);
            this.PnlCont1.Tag = fh;
            fh.Show();

        }

        private void btnPICS_Click(object sender, EventArgs e)
        {
            //FrmNuecoCli objNewCl = new FrmNuecoCli();
            FrmPICS objPICS = new FrmPICS();

            AbrirFormFijo(objPICS);

            //OcultarSubMen();
        }

        private void btnPICM_Click(object sender, EventArgs e)
        {
            FrmPICM objPICM = new FrmPICM();

            AbrirFormFijo(objPICM);
        }

        private void btnPFCS_Click(object sender, EventArgs e)
        {
            FrmPFCS objPFCS = new FrmPFCS();

            AbrirFormFijo(objPFCS);

        }

        private void btnPFCM_Click(object sender, EventArgs e)
        {
            FrmPFCM objPFCM = new FrmPFCM();

            AbrirFormFijo(objPFCM);
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MAXIMIZAR_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\DELL\Desktop\Simulacion1_3\ProyectPrueba1\info.pdf";
            proceso.Start(); 
        }

        public void crearPDF() {
          
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
