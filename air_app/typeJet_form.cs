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
    public partial class typeJet_form : Form
    {
        public typeJet_form()
        {
            InitializeComponent();
        }

        private void type_jetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.type_jetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airDataSet);

        }

        private void typeJet_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.type_jet". При необходимости она может быть перемещена или удалена.
            this.type_jetTableAdapter.Fill(this.airDataSet.type_jet);

        }
    }
}
