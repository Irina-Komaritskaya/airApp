namespace air_app
{
    partial class flight_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flight_form));
            this.airDataSet = new air_app.airDataSet();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new air_app.airDataSetTableAdapters.flightTableAdapter();
            this.tableAdapterManager = new air_app.airDataSetTableAdapters.TableAdapterManager();
            this.flightBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.flightBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.typeflightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_flightTableAdapter = new air_app.airDataSetTableAdapters.type_flightTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flight_cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_cityTableAdapter = new air_app.airDataSetTableAdapters.flight_cityTableAdapter();
            this.flight_cityDataGridView = new System.Windows.Forms.DataGridView();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new air_app.airDataSetTableAdapters.cityTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingNavigator)).BeginInit();
            this.flightBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeflightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_cityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // airDataSet
            // 
            this.airDataSet.DataSetName = "airDataSet";
            this.airDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.airDataSet;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.brigadeTableAdapter = null;
            this.tableAdapterManager.checkupTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.delaysTableAdapter = null;
            this.tableAdapterManager.departamentTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.flight_cityTableAdapter = this.flight_cityTableAdapter;
            this.tableAdapterManager.flightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager.jet_brigadeTableAdapter = null;
            this.tableAdapterManager.jetTableAdapter = null;
            this.tableAdapterManager.medicalTableAdapter = null;
            this.tableAdapterManager.passengerTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.repairTableAdapter = null;
            this.tableAdapterManager.return_ticketTableAdapter = null;
            this.tableAdapterManager.timetableTableAdapter = null;
            this.tableAdapterManager.type_flightTableAdapter = this.type_flightTableAdapter;
            this.tableAdapterManager.type_jetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = air_app.airDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightBindingNavigator
            // 
            this.flightBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flightBindingNavigator.BindingSource = this.flightBindingSource;
            this.flightBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flightBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flightBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.flightBindingNavigatorSaveItem});
            this.flightBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flightBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flightBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flightBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flightBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flightBindingNavigator.Name = "flightBindingNavigator";
            this.flightBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flightBindingNavigator.Size = new System.Drawing.Size(660, 25);
            this.flightBindingNavigator.TabIndex = 0;
            this.flightBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // flightBindingNavigatorSaveItem
            // 
            this.flightBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flightBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flightBindingNavigatorSaveItem.Image")));
            this.flightBindingNavigatorSaveItem.Name = "flightBindingNavigatorSaveItem";
            this.flightBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.flightBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.flightBindingNavigatorSaveItem.Click += new System.EventHandler(this.flightBindingNavigatorSaveItem_Click);
            // 
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AutoGenerateColumns = false;
            this.flightDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.flightDataGridView.DataSource = this.flightBindingSource;
            this.flightDataGridView.Location = new System.Drawing.Point(12, 41);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.Size = new System.Drawing.Size(271, 397);
            this.flightDataGridView.TabIndex = 1;
            this.flightDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.flightDataGridView_DataError);
            // 
            // typeflightBindingSource
            // 
            this.typeflightBindingSource.DataMember = "type_flight";
            this.typeflightBindingSource.DataSource = this.airDataSet;
            // 
            // type_flightTableAdapter
            // 
            this.type_flightTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_flight";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_flight";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_flight";
            this.dataGridViewTextBoxColumn2.HeaderText = "название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_type";
            this.dataGridViewTextBoxColumn3.DataSource = this.typeflightBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_type";
            this.dataGridViewTextBoxColumn3.Width = 49;
            // 
            // flight_cityBindingSource
            // 
            this.flight_cityBindingSource.DataMember = "R_8";
            this.flight_cityBindingSource.DataSource = this.flightBindingSource;
            // 
            // flight_cityTableAdapter
            // 
            this.flight_cityTableAdapter.ClearBeforeFill = true;
            // 
            // flight_cityDataGridView
            // 
            this.flight_cityDataGridView.AutoGenerateColumns = false;
            this.flight_cityDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.flight_cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flight_cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.flight_cityDataGridView.DataSource = this.flight_cityBindingSource;
            this.flight_cityDataGridView.Location = new System.Drawing.Point(310, 41);
            this.flight_cityDataGridView.Name = "flight_cityDataGridView";
            this.flight_cityDataGridView.Size = new System.Drawing.Size(326, 397);
            this.flight_cityDataGridView.TabIndex = 2;
            this.flight_cityDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.flight_cityDataGridView_DataError);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.airDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_flight";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_flight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn5.HeaderText = "тип";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "прилет",
            "отлет",
            "пересадка"});
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 49;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_flight_city";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_flight_city";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_city";
            this.dataGridViewTextBoxColumn7.DataSource = this.cityBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "name_city";
            this.dataGridViewTextBoxColumn7.HeaderText = "город";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "id_city";
            this.dataGridViewTextBoxColumn7.Width = 61;
            // 
            // flight_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 458);
            this.Controls.Add(this.flight_cityDataGridView);
            this.Controls.Add(this.flightDataGridView);
            this.Controls.Add(this.flightBindingNavigator);
            this.Name = "flight_form";
            this.Text = "рейсы";
            this.Load += new System.EventHandler(this.flight_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingNavigator)).EndInit();
            this.flightBindingNavigator.ResumeLayout(false);
            this.flightBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeflightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flight_cityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airDataSet airDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private airDataSetTableAdapters.flightTableAdapter flightTableAdapter;
        private airDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flightBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton flightBindingNavigatorSaveItem;
        private airDataSetTableAdapters.type_flightTableAdapter type_flightTableAdapter;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.BindingSource typeflightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private airDataSetTableAdapters.flight_cityTableAdapter flight_cityTableAdapter;
        private System.Windows.Forms.BindingSource flight_cityBindingSource;
        private airDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.DataGridView flight_cityDataGridView;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}