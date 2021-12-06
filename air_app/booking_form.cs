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
    public partial class booking_form : Form
    {
        public booking_form()
        {
            InitializeComponent();
        }

        private void bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookingBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.airDataSet);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void booking_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.return_ticket". При необходимости она может быть перемещена или удалена.
            this.return_ticketTableAdapter.Fill(this.airDataSet.return_ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.passenger". При необходимости она может быть перемещена или удалена.
            this.passengerTableAdapter.Fill(this.airDataSet.passenger);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.airDataSet.flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.airDataSet.timetable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.timetable". При необходимости она может быть перемещена или удалена.
            this.timetableTableAdapter.Fill(this.airDataSet.timetable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.booking". При необходимости она может быть перемещена или удалена.
            this.bookingTableAdapter.Fill(this.airDataSet.booking);

        }

        private void bookingDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void timetableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
