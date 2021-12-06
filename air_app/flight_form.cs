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
    public partial class flight_form : Form
    {
        public flight_form()
        {
            InitializeComponent();
        }

        private void flightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void flight_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.city". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.airDataSet.city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.flight_city". При необходимости она может быть перемещена или удалена.
            this.flight_cityTableAdapter.Fill(this.airDataSet.flight_city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.type_flight". При необходимости она может быть перемещена или удалена.
            this.type_flightTableAdapter.Fill(this.airDataSet.type_flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.airDataSet.flight);

        }

        private void flightDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void flight_cityDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
