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
    public partial class typeFlight_form : Form
    {
        public typeFlight_form()
        {
            InitializeComponent();
        }

        private void type_flightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.type_flightBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void typeFlight_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.type_flight". При необходимости она может быть перемещена или удалена.
            this.type_flightTableAdapter.Fill(this.airDataSet.type_flight);

        }
    }
}
