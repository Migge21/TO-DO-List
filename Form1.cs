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
            Limpar();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Tarefa", typeof(string));
            dt.Columns.Add("Prioridade", typeof(string));

            dtgTarefa.DataSource = dt;
         
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "btnRemover";
                button.HeaderText = "Remover Tarefa";
                button.Text = "Remover";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                dtgTarefa.Columns.Add(button);
            }

        }
        
        private void dtgTarefa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgTarefa.Rows[e.RowIndex];

            if(MessageBox.Show(string.Format("Tem certeza que deseja excluir ?",row.Cells["Tarefa"].Value),"Aviso",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dt.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Limpar()
        {
            txtTarefa.Clear();
            cbxPrioridade.SelectedIndex = -1;
        }
    }
}
