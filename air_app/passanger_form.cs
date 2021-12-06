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
    public partial class passanger_form : Form
    {
        public passanger_form()
        {
            InitializeComponent();
        }

        private void passengerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void passanger_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.passenger". При необходимости она может быть перемещена или удалена.
            this.passengerTableAdapter.Fill(this.airDataSet.passenger);

        }
    }
}
