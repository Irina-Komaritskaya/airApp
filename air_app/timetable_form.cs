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
    public partial class timetable_form : Form
    {
        public timetable_form()
        {
            InitializeComponent();
        }

        private void timetableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.timetableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.airDataSet);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timetable_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.checkup". При необходимости она может быть перемещена или удалена.
            this.checkupTableAdapter.Fill(this.airDataSet.checkup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.delays". При необходимости она может быть перемещена или удалена.
            this.delaysTableAdapter.Fill(this.airDataSet.delays);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.airDataSet.flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.jet". При необходимости она может быть перемещена или удалена.
            this.jetTableAdapter.Fill(this.airDataSet.jet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.airDataSet.timetable);

        }

        private void timetableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
