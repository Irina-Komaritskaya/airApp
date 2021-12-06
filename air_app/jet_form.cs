using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace air_app
{
    public partial class jet_form : Form
    {
        public jet_form()
        {
            InitializeComponent();
        }

        private void jetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void jet_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.repair". При необходимости она может быть перемещена или удалена.
            this.repairTableAdapter.Fill(this.airDataSet.repair);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.brigade". При необходимости она может быть перемещена или удалена.
            this.brigadeTableAdapter.Fill(this.airDataSet.brigade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.jet_brigade". При необходимости она может быть перемещена или удалена.
            this.jet_brigadeTableAdapter.Fill(this.airDataSet.jet_brigade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.type_jet". При необходимости она может быть перемещена или удалена.
            this.type_jetTableAdapter.Fill(this.airDataSet.type_jet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.jet". При необходимости она может быть перемещена или удалена.
            this.jetTableAdapter.Fill(this.airDataSet.jet);

        }

        private void jet_brigadeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void jetDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
