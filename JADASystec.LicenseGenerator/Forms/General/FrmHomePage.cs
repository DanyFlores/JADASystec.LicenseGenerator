using JADASystec.LicenseGenerator.Forms.Keys;
using JADASystect.CrossCutting.Helpers;
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

namespace JADASystec.LicenseGenerator.Forms.General
{
    public partial class FrmHomePage : Form
    {
        #region Variables Globales
        int X, Y;
        #endregion

        #region Constructor
        public FrmHomePage()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que quiere salir del sistema...?") == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Maximizar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmHomePage ~ btnMaximizar_Click(object sender, EventArgs e)");
            }
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Restaurar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmHomePage ~ btnRestaurar_Click(object sender, EventArgs e)");
            }
        }
        private void pb_img_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlContainer.Controls.Count > 0)
                {
                    for (int i = 1; i < pnlContainer.Controls.Count; i++)
                    {
                        pnlContainer.Controls.RemoveAt(i);
                    }
                }                
                this.pnl_Menu.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void pnl_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Metodos

        #region Abrir Formulario dentro del panel Container
        private void GetPanel(object Formhijo)
        {
            try
            {
                if (this.pnlContainer.Controls.Count > 0)
                {
                    //this.pnl_Contenedor.Controls.RemoveAt(0);
                    this.pnl_Menu.Visible = false;
                    for (int i = 1; i < pnlContainer.Controls.Count; i++)
                    {
                        pnlContainer.Controls.RemoveAt(i);
                    }
                }
                Form Fchild = Formhijo as Form;
                Fchild.TopLevel = false;
                Fchild.Dock = DockStyle.Fill;
                this.pnlContainer.Controls.Add(Fchild);
                this.pnlContainer.Tag = Fchild;
                Fchild.Dock = DockStyle.Fill;
                Fchild.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        public void Maximizar()
        {
            try
            {
                X = Location.X;
                Y = Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.btnMaximizar.Visible = false;
                this.btnRestaurar.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            try
            {
                Maximizar();
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmHomePage ~ FrmHomePage_Load(object sender, EventArgs e)");
            }
        }

        public void Restaurar()
        {
            try
            {
                Size = new Size(1280, 720);
                this.CenterToScreen();
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmHomePage ~ Restaurar()");
            }
        }

        #region Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsp, int wparam, int lparam);

        #endregion

        #endregion

        #region Eventos btn
        private void btnLlaves_Click(object sender, EventArgs e)
        {
            try
            {
                GetPanel(new FrmListadoLlaves());
            }
            catch (Exception ex)
            {
                ErrorLogHelper.AddExcFileTxt(ex, "FrmHomePage ~  btnLlaves_Click(object sender, EventArgs e)");
            }
        }
        #endregion
    }
}
