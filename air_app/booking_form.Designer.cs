namespace air_app
{
    partial class booking_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking_form));
            this.airDataSet = new air_app.airDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new air_app.airDataSetTableAdapters.bookingTableAdapter();
            this.tableAdapterManager = new air_app.airDataSetTableAdapters.TableAdapterManager();
            this.flightTableAdapter = new air_app.airDataSetTableAdapters.flightTableAdapter();
            this.passengerTableAdapter = new air_app.airDataSetTableAdapters.passengerTableAdapter();
            this.timetableTableAdapter = new air_app.airDataSetTableAdapters.timetableTableAdapter();
            this.bookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.return_ticketTableAdapter = new air_app.airDataSetTableAdapters.return_ticketTableAdapter();
            this.return_ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).BeginInit();
            this.bookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ticketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airDataSet
            // 
            this.airDataSet.DataSetName = "airDataSet";
            this.airDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.airDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.brigadeTableAdapter = null;
            this.tableAdapterManager.checkupTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.delaysTableAdapter = null;
            this.tableAdapterManager.departamentTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.flight_cityTableAdapter = null;
            this.tableAdapterManager.flightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager.jet_brigadeTableAdapter = null;
            this.tableAdapterManager.jetTableAdapter = null;
            this.tableAdapterManager.medicalTableAdapter = null;
            this.tableAdapterManager.passengerTableAdapter = this.passengerTableAdapter;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.repairTableAdapter = null;
            this.tableAdapterManager.return_ticketTableAdapter = null;
            this.tableAdapterManager.timetableTableAdapter = this.timetableTableAdapter;
            this.tableAdapterManager.type_flightTableAdapter = null;
            this.tableAdapterManager.type_jetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = air_app.airDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // passengerTableAdapter
            // 
            this.passengerTableAdapter.ClearBeforeFill = true;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingNavigator
            // 
            this.bookingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookingBindingNavigator.BindingSource = this.bookingBindingSource;
            this.bookingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookingBindingNavigatorSaveItem});
            this.bookingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookingBindingNavigator.Name = "bookingBindingNavigator";
            this.bookingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookingBindingNavigator.Size = new System.Drawing.Size(973, 25);
            this.bookingBindingNavigator.TabIndex = 0;
            this.bookingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bookingBindingNavigatorSaveItem
            // 
            this.bookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingBindingNavigatorSaveItem.Image")));
            this.bookingBindingNavigatorSaveItem.Name = "bookingBindingNavigatorSaveItem";
            this.bookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingBindingNavigatorSaveItem_Click);
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataMember = "timetable";
            this.timetableBindingSource.DataSource = this.airDataSet;
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.AllowUserToAddRows = false;
            this.timetableDataGridView.AutoGenerateColumns = false;
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.timetableDataGridView.DataSource = this.timetableBindingSource;
            this.timetableDataGridView.Location = new System.Drawing.Point(12, 38);
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.Size = new System.Drawing.Size(360, 412);
            this.timetableDataGridView.TabIndex = 1;
            this.timetableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.timetableDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_timetable";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_timetable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "start";
            this.dataGridViewTextBoxColumn2.HeaderText = "вылет";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 63;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "finish";
            this.dataGridViewTextBoxColumn3.HeaderText = "прилет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "remove";
            this.dataGridViewCheckBoxColumn1.HeaderText = "remove";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_jet";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_jet";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fact_start";
            this.dataGridViewTextBoxColumn5.HeaderText = "fact_start";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_flight";
            this.dataGridViewTextBoxColumn6.DataSource = this.flightBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "name_flight";
            this.dataGridViewTextBoxColumn6.HeaderText = "рейс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id_flight";
            this.dataGridViewTextBoxColumn6.Width = 56;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.airDataSet;
            // 
            // bookingBindingSource1
            // 
            this.bookingBindingSource1.DataMember = "R_16";
            this.bookingBindingSource1.DataSource = this.timetableBindingSource;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.bookingDataGridView.DataSource = this.bookingBindingSource1;
            this.bookingDataGridView.Location = new System.Drawing.Point(387, 38);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.Size = new System.Drawing.Size(394, 412);
            this.bookingDataGridView.TabIndex = 2;
            this.bookingDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.bookingDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_booking";
            this.dataGridViewTextBoxColumn7.HeaderText = "номер брони";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn8.HeaderText = "цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_timetable";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_timetable";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_passenger";
            this.dataGridViewTextBoxColumn10.DataSource = this.passengerBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "name_passenger";
            this.dataGridViewTextBoxColumn10.HeaderText = "пассажир";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "id_passenger";
            this.dataGridViewTextBoxColumn10.Width = 82;
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataMember = "passenger";
            this.passengerBindingSource.DataSource = this.airDataSet;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_booking";
            this.dataGridViewTextBoxColumn11.HeaderText = "дата брони";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 88;
            // 
            // return_ticketBindingSource
            // 
            this.return_ticketBindingSource.DataMember = "R_18";
            this.return_ticketBindingSource.DataSource = this.bookingBindingSource1;
            // 
            // return_ticketTableAdapter
            // 
            this.return_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // return_ticketDataGridView
            // 
            this.return_ticketDataGridView.AutoGenerateColumns = false;
            this.return_ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.return_ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.return_ticketDataGridView.DataSource = this.return_ticketBindingSource;
            this.return_ticketDataGridView.Location = new System.Drawing.Point(801, 38);
            this.return_ticketDataGridView.Name = "return_ticketDataGridView";
            this.return_ticketDataGridView.Size = new System.Drawing.Size(157, 412);
            this.return_ticketDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id_return";
            this.dataGridViewTextBoxColumn12.HeaderText = "id_return";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "date_return";
            this.dataGridViewTextBoxColumn13.HeaderText = "дата возврата";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "id_booking";
            this.dataGridViewTextBoxColumn14.HeaderText = "id_booking";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // booking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 505);
            this.Controls.Add(this.return_ticketDataGridView);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.timetableDataGridView);
            this.Controls.Add(this.bookingBindingNavigator);
            this.Name = "booking_form";
            this.Text = "бронирование и покупка билетов";
            this.Load += new System.EventHandler(this.booking_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).EndInit();
            this.bookingBindingNavigator.ResumeLayout(false);
            this.bookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.return_ticketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airDataSet airDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private airDataSetTableAdapters.bookingTableAdapter bookingTableAdapter;
        private airDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookingBindingNavigatorSaveItem;
        private airDataSetTableAdapters.timetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private airDataSetTableAdapters.flightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridView timetableDataGridView;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private airDataSetTableAdapters.passengerTableAdapter passengerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bookingBindingSource1;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource return_ticketBindingSource;
        private airDataSetTableAdapters.return_ticketTableAdapter return_ticketTableAdapter;
        private System.Windows.Forms.DataGridView return_ticketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}