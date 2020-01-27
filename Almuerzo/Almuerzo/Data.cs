using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almuerzo
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            dtGrid.Columns.Add("identification", "Cedula");
            dtGrid.Columns.Add("name", "Name");
            dtGrid.Columns.Add("protein", "Proteina");
            dtGrid.Columns.Add("Grain", "Granos");
            dtGrid.Columns.Add("salad", "Ensalada");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void AddElements(string identification, string name, string protein, string grain, string salad)
        {
            dtGrid.Rows.Add(identification,name,protein,grain,salad);
        }


        private void Data_Load(object sender, EventArgs e)
        {
            
        }
    }
}
