using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TO_DO_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        DataTable dt = new DataTable();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            dt.Rows.Add(txtTarefa.Text,cbxPrioridade.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Tarefa", typeof(string));
            dt.Columns.Add("Prioridade", typeof(string));

            dtgTarefa.DataSource = dt;
         
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "Button";
                button.Text = "Button";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                dtgTarefa.Columns.Add(button);
            }

        }
    }
}
