using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace air_app
{
    public partial class procedure_form : Form
    {
        public procedure_form()
        {
            InitializeComponent();
        }

        private void ExecuteSqlCommand(SqlCommand sql)
        {
            sqlConnection1.Open();
            var reader = sql.ExecuteReader();

            var dset = new DataSet();
            dset.Tables.Add();
            dset.Tables[0].Load(reader);
            dataGridView1.DataSource = dset.Tables[0];

            sqlConnection1.Close();
        }

        private void procedure_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.type_flight". При необходимости она может быть перемещена или удалена.
            this.type_flightTableAdapter.Fill(this.airDataSet.type_flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.airDataSet.flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.brigade". При необходимости она может быть перемещена или удалена.
            this.brigadeTableAdapter.Fill(this.airDataSet.brigade);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airDataSet.departament". При необходимости она может быть перемещена или удалена.
            this.departamentTableAdapter.Fill(this.airDataSet.departament);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlCommand1.Parameters.AddWithValue ("@id_dep", comboBox1.SelectedValue);
            sqlCommand1.Parameters.AddWithValue ("@exp", textBox1.Text);
            sqlCommand1.Parameters.AddWithValue ("@sex", comboBox2.SelectedItem);
            sqlCommand1.Parameters.AddWithValue ("@old", textBox2.Text);
            sqlCommand1.Parameters.AddWithValue ("@child", textBox3.Text);
            sqlCommand1.Parameters.AddWithValue ("@salary", textBox4.Text);
            ExecuteSqlCommand(sqlCommand1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCommand2.Parameters.AddWithValue("@brigade", comboBox3.SelectedValue);
            sqlCommand2.Parameters.AddWithValue("@dep", comboBox4.SelectedValue);
            sqlCommand2.Parameters.AddWithValue("@flight", comboBox5.SelectedValue);
            sqlCommand2.Parameters.AddWithValue("@old", textBox7.Text);
            sqlCommand2.Parameters.AddWithValue("@salary", textBox5.Text);
            ExecuteSqlCommand(sqlCommand2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlCommand3.Parameters.AddWithValue("@traversed", checkBox1.CheckState);
            sqlCommand3.Parameters.AddWithValue("@old", textBox8.Text);
            sqlCommand3.Parameters.AddWithValue("@year", textBox9.Text);
            sqlCommand3.Parameters.AddWithValue("@salary", textBox6.Text);
            ExecuteSqlCommand(sqlCommand3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand4.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            sqlCommand4.Parameters.AddWithValue("@count", textBox10.Text);
            ExecuteSqlCommand(sqlCommand4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlCommand5.Parameters.AddWithValue("@date1", dateTimePicker2.Value);
            sqlCommand5.Parameters.AddWithValue("@date2", dateTimePicker3.Value);
            sqlCommand5.Parameters.AddWithValue("@date3", dateTimePicker4.Value);
            sqlCommand5.Parameters.AddWithValue("@count", textBox11.Text);
            ExecuteSqlCommand(sqlCommand5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlCommand6.Parameters.AddWithValue("@flight", comboBox6.SelectedValue);
            sqlCommand6.Parameters.AddWithValue("@count", textBox12.Text);
            ExecuteSqlCommand(sqlCommand6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sqlCommand6.Parameters.AddWithValue("@id_type", comboBox7.SelectedValue);
            sqlCommand6.Parameters.AddWithValue("@count", textBox13.Text);
            ExecuteSqlCommand(sqlCommand6);
        }
    }
}
