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
    public partial class post_form : Form
    {
        public post_form()
        {
            InitializeComponent();
        }

        private void postBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void post_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.airDataSet.departament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.airDataSet.post);

        }

        private void postDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
