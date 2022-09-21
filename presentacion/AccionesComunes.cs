using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace presentacion
{
    internal class AccionesComunes
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LlenarCombo(string consulta, ComboBox combo, string  id, string txt)
        {
            combo.Items.Clear();
            combo.ValueMember=id;
            combo.DisplayMember=txt;
            DataTable dt;
            dt=conexion.EjecutaSeleccion(consulta);
            DataRow r = dt.NewRow();
            r[0] = 0;
            r[1] = "todos";
            dt.Rows.InsertAt(r, 0);
            if (dt==null)
            {
                return;
            }
            combo.DataSource=dt;
        }
    }
}
