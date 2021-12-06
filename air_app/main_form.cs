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
    public partial class main_form : Form
    {
        private int childFormNumber = 0;
        private Dictionary<string, Form> _forms = new Dictionary<string, Form>();

        public main_form()
        {
            InitializeComponent();
            _forms.Add("работники", new brigade_form() { MdiParent = this });
            _forms.Add("отделы", new departament_form() { MdiParent = this });
            _forms.Add("должности", new post_form() { MdiParent = this });
            _forms.Add("продажи", new booking_form() { MdiParent = this });
            _forms.Add("пассажиры", new passanger_form() { MdiParent = this });
            _forms.Add("выдать билет", new tikcetBooking_form() { MdiParent = this });
            _forms.Add("города", new city_form() { MdiParent = this });
            _forms.Add("самолеты", new jet_form() { MdiParent = this });
            _forms.Add("тип самолета", new typeJet_form() { MdiParent = this });
            _forms.Add("рейсы", new flight_form() { MdiParent = this });
            _forms.Add("расписание", new timetable_form() { MdiParent = this });
            _forms.Add("тип рейса", new typeFlight_form() { MdiParent = this });
            _forms.Add("процедуры", new procedure_form() { MdiParent = this });
           
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            var form_name = (sender as ToolStripMenuItem).Text;
            _forms[form_name].Show();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

    }
}
