using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaWinfForm
{
    public partial class FrmCotizaciones : Form
    {
        public FrmCotizaciones()
        {
            InitializeComponent();
        }

        private void FrmCotizaciones_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
