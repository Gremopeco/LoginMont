using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grecia
{
    public partial class forlogin : Form
    {
        public forlogin()
        {
            InitializeComponent();
        }

        private void butcancelar_Click(object sender, EventArgs e)
        {
            texuser.Clear();
            texcontra.Clear();

        }

        private void butingresar_Click(object sender, EventArgs e)
        {
            if(texuser.Text == "grecia" && texcontra.Text == "111")
            {
                forinico forinico = new forinico();
                this.Hide();
                forinico.Show();
                 
            }
            else
            {
                MessageBox.Show("nono es incorrecto usuario o contraseña");

            }
        }
    }
}
