using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErrorHandler;

namespace ErrorHandlerView
{
    public partial class frmErrorHandlerView : Form
    {
        public frmErrorHandlerView()
        {
            InitializeComponent();
        }

        private void btnGenerarError_Click(object sender, EventArgs e)
        {
            try
            {


                string[] a = new string[0];

                a[5] = "5";
                
            }
            catch (Exception ex)
            {
                clsErrorHandler.getInstancia.checkError(ex);
            }
        }
    }
}
