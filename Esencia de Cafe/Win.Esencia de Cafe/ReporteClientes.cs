using BL.Esencia_de_cafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Esencia_de_Cafe
{
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();

            var _clienteBL = new ClientesBL();
            var bidingSource = new BindingSource();
            bidingSource.DataSource = _clienteBL.ObtenerClientes();

            var reporte = new DetalleClientes();
            reporte.SetDataSource(bidingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
