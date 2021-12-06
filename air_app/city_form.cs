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
    public partial class city_form : Form
    {
        public city_form()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void city_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.city". При необходимости она может быть перемещена или удалена.
            this.cityTableAdapter.Fill(this.airDataSet.city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.airDataSet.country);

        }
    }
}
