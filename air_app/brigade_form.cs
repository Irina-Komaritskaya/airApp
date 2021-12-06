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
    public partial class brigade_form : Form
    {
        public brigade_form()
        {
            InitializeComponent();
        }

        private void brigadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brigadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void brigade_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.airDataSet.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.airDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.airDataSet.departament);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.brigade". При необходимости она может быть перемещена или удалена.
            this.brigadeTableAdapter.Fill(this.airDataSet.brigade);

        }

        private void employeeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void brigadeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
