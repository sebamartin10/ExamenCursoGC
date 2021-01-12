using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaExpertoLogica;
using LibreriaClases;

namespace VistaWinfForm
{
    public partial class Form1 : Form
    {
        ParametrosAplicativo paramAplicativo = null;
        ExpertoCotizacion expertoCotiz = new ExpertoCotizacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblNombreTienda.Text = expertoCotiz.GetNombreTienda();
            lblDatosVendedor.Text = expertoCotiz.GetDatosVendedor();
            lblDireccionTienda.Text = expertoCotiz.GetDireccionTienda();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            
            chkCuelloMao.Enabled = true;
            chkMangaCorta.Enabled = true;
            chkChupin.Enabled = false;
            Buscar();
        }

        private void rdbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            
            chkChupin.Enabled = true;
            chkCuelloMao.Enabled = false;
            chkMangaCorta.Enabled = false;
            Buscar();
        }

        private void chkMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void chkCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar() {
            if (rdbtnCamisa.Checked)
            {
                if (chkMangaCorta.Checked==true && chkCuelloMao.Checked==false) {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(2);
                }
                if (chkMangaCorta.Checked == false && chkCuelloMao.Checked == true) {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(3);
                }
                if (chkMangaCorta.Checked == true && chkCuelloMao.Checked == true) {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(4);
                }
                if (chkMangaCorta.Checked == false && chkCuelloMao.Checked == false) {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(0);
                }
            }
            if (rdbtnPantalon.Checked) {
                if (chkChupin.Checked)
                {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(5);
                }
                else {
                    lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.ConsultarStockDisponible(1);
                }
            }
            
        }

        private void chkChupin_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (String.IsNullOrEmpty(txtPrecio.Text)) {
                ErrorAplicativo err = new ErrorAplicativo();
                err.codigoError = -1;
                err.descripcionError = "Debe completar el campo Precio Unitario antes de continuar con la cotización";
                FrmError frmError = new FrmError();
                frmError.Controls["lblMensajeError"].Text = "Código Error: " + err.codigoError + " " + err.descripcionError;
                frmError.ShowDialog();
            }
            if (String.IsNullOrEmpty(txtCantidad.Text)) {
                ErrorAplicativo err = new ErrorAplicativo();
                err.codigoError = -1;
                err.descripcionError = "Debe completar el campo Cantidad antes de continuar con la cotización";
                FrmError frmError = new FrmError();
                frmError.Controls["lblMensajeError"].Text = "Código Error: " + err.codigoError + " " + err.descripcionError;
                frmError.ShowDialog();
            }
            #endregion
            (ErrorAplicativo err,decimal precioCotizado) respuesta = expertoCotiz.CalcularPrecioCotizacion(Convert.ToDecimal(txtPrecio.Text),Convert.ToInt32(txtCantidad.Text));
            if (respuesta.err.codigoError!=0) {
                FrmError frmError = new FrmError();
                    frmError.Controls["lblMensajeError"].Text = "Código Error: " + respuesta.err.codigoError + " " + respuesta.err.descripcionError;
                frmError.ShowDialog();
                
                    
                
            }
            lblPrecioCotizado.Text = String.Format("{0:c}", respuesta.precioCotizado);
            BorrarCampos();
        }

        private void rdbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.FiltrarPorCalidad(0);
           
        }

        private void rdbtnPremium_CheckedChanged(object sender, EventArgs e)
        {
            lblStockDisponible.Text = "Cantidad de stock disponible: " + expertoCotiz.FiltrarPorCalidad(1);
        }
        private void BorrarCampos() {
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            List<(int,string,string,int)> cotizaciones = expertoCotiz.ConsultarCotizaciones();
            FrmCotizaciones frmCotizaciones = new FrmCotizaciones();
            DataGridView dataGrid = frmCotizaciones.Controls["dataGridViewCotizaciones"] as DataGridView;
            dataGrid.Columns.Add("ID","ID");
            dataGrid.Columns.Add("Fecha","Fecha");
            dataGrid.Columns.Add("Precio", "Precio");
            dataGrid.Columns.Add("Cantidad", "Cantidad");
            foreach (var cotizacion in cotizaciones) {
                dataGrid.Rows.Add(cotizacion.Item1,cotizacion.Item2,cotizacion.Item3,cotizacion.Item4);
            }
            frmCotizaciones.ShowDialog();
        }
    }
}
