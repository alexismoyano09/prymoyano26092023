using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace prymoyano26092023
{
    public partial class Frmmain : Form
    {
        OleDbConnection conexionBD;
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Alumnos\\source\\repos\\prymoyano26092023\\prymoyano26092023\\base\\EL_CLUB.accdb");
            
            conexionBD.Open();//abrir base de datos

            lblresultado.Text = "Conectado a la Base";
            lblresultado.ForeColor = System.Drawing.Color.Green;


        }
    }
}
