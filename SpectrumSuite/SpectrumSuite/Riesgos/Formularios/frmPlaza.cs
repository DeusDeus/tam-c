using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentesNegocio;
using ComponentesGUI;

namespace SpectrumSuite
{
    public partial class frmPlaza : Form
    {
        public frmPlaza()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmPlaza_Load(object sender, EventArgs e)
        {
            DataSet ds = clsNegocio.CargarFormulario(this.Name);
            dgvPlaza.DataSource = ds;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
            //    foreach (Control ctr in this.Controls)
            //    {
            //        if (ctr.HasChildren)
            //        {
            //            foreach (Control ctr2 in ctr.Controls)
            //            {
            //                CargarControl(dr, ctr2);
            //            }
            //        }
            //        else
            //        {
            //            CargarControl(dr, ctr);
            //        }
            //    }
                CargarControl(this, dr);
            }
        }

        private void CargarControl(Control pctr, DataRow pdr)
        {
            if (pdr["NombreObjeto"].ToString().CompareTo(pctr.Name)==0)
            {
                switch (pdr["TipoObjeto"].ToString())
                {
                    case "cmd": break;
                    case "cbx": break;
                    case "cbo": break;
                    case "dtp": break;
                    case "lbl": break;
                    case "txt": ((ucTextBox)pctr).Text = "WILDER"; break;
                }
            }

            if (pctr.HasChildren)
            {
                foreach (Control ctr in pctr.Controls)
                {
                    CargarControl(ctr, pdr);
                }
            }
        }

        //private void CargarControl(DataRow pdr, Control pctr)
        //{
        //    if (pdr["NombreObjeto"].ToString().CompareTo(pctr.Name) == 0)
        //    {
        //        switch (pdr["TipoObjeto"].ToString())
        //        {
        //            case "cmd": break;
        //            case "cbx": break;
        //            case "cbo": break;
        //            case "dtp": break;
        //            case "lbl": break;
        //            case "txt": ((ucButton)pctr).Text = "WILDER"; break;
        //        }
        //    }
        //}
    }
}
