namespace air_app
{
    partial class jet_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jet_form));
            this.airDataSet = new air_app.airDataSet();
            this.jetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jetTableAdapter = new air_app.airDataSetTableAdapters.jetTableAdapter();
            this.tableAdapterManager = new air_app.airDataSetTableAdapters.TableAdapterManager();
            this.jetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.jetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jetDataGridView = new System.Windows.Forms.DataGridView();
            this.typejetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_jetTableAdapter = new air_app.airDataSetTableAdapters.type_jetTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jet_brigadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jet_brigadeTableAdapter = new air_app.airDataSetTableAdapters.jet_brigadeTableAdapter();
            this.jet_brigadeDataGridView = new System.Windows.Forms.DataGridView();
            this.brigadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brigadeTableAdapter = new air_app.airDataSetTableAdapters.brigadeTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairTableAdapter = new air_app.airDataSetTableAdapters.repairTableAdapter();
            this.repairDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBindingNavigator)).BeginInit();
            this.jetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typejetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet_brigadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet_brigadeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airDataSet
            // 
            this.airDataSet.DataSetName = "airDataSet";
            this.airDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jetBindingSource
            // 
            this.jetBindingSource.DataMember = "jet";
            this.jetBindingSource.DataSource = this.airDataSet;
            // 
            // jetTableAdapter
            // 
            this.jetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.brigadeTableAdapter = this.brigadeTableAdapter;
            this.tableAdapterManager.checkupTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.delaysTableAdapter = null;
            this.tableAdapterManager.departamentTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.flight_cityTableAdapter = null;
            this.tableAdapterManager.flightTableAdapter = null;
            this.tableAdapterManager.jet_brigadeTableAdapter = this.jet_brigadeTableAdapter;
            this.tableAdapterManager.jetTableAdapter = this.jetTableAdapter;
            this.tableAdapterManager.medicalTableAdapter = null;
            this.tableAdapterManager.passengerTableAdapter = null;
            this.tableAdapterManager.postTableAdapter = null;
            this.tableAdapterManager.repairTableAdapter = this.repairTableAdapter;
            this.tableAdapterManager.return_ticketTableAdapter = null;
            this.tableAdapterManager.timetableTableAdapter = null;
            this.tableAdapterManager.type_flightTableAdapter = null;
            this.tableAdapterManager.type_jetTableAdapter = this.type_jetTableAdapter;
            this.tableAdapterManager.UpdateOrder = air_app.airDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jetBindingNavigator
            // 
            this.jetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jetBindingNavigator.BindingSource = this.jetBindingSource;
            this.jetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jetBindingNavigatorSaveItem});
            this.jetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jetBindingNavigator.Name = "jetBindingNavigator";
            this.jetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jetBindingNavigator.Size = new System.Drawing.Size(757, 25);
            this.jetBindingNavigator.TabIndex = 0;
            this.jetBindingNavigator.Text = "bindingNavigator1";
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
            // jetBindingNavigatorSaveItem
            // 
            this.jetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jetBindingNavigatorSaveItem.Image")));
            this.jetBindingNavigatorSaveItem.Name = "jetBindingNavigatorSaveItem";
            this.jetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.jetBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.jetBindingNavigatorSaveItem.Click += new System.EventHandler(this.jetBindingNavigatorSaveItem_Click);
            // 
            // jetDataGridView
            // 
            this.jetDataGridView.AllowUserToAddRows = false;
            this.jetDataGridView.AutoGenerateColumns = false;
            this.jetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.jetDataGridView.DataSource = this.jetBindingSource;
            this.jetDataGridView.Location = new System.Drawing.Point(12, 44);
            this.jetDataGridView.Name = "jetDataGridView";
            this.jetDataGridView.Size = new System.Drawing.Size(221, 394);
            this.jetDataGridView.TabIndex = 1;
            this.jetDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.jetDataGridView_DataError);
            // 
            // typejetBindingSource
            // 
            this.typejetBindingSource.DataMember = "type_jet";
            this.typejetBindingSource.DataSource = this.airDataSet;
            // 
            // type_jetTableAdapter
            // 
            this.type_jetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_jet";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_jet";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_jet";
            this.dataGridViewTextBoxColumn2.HeaderText = "название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_type";
            this.dataGridViewTextBoxColumn3.DataSource = this.typejetBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_type";
            this.dataGridViewTextBoxColumn3.Width = 49;
            // 
            // jet_brigadeBindingSource
            // 
            this.jet_brigadeBindingSource.DataMember = "R_20";
            this.jet_brigadeBindingSource.DataSource = this.jetBindingSource;
            // 
            // jet_brigadeTableAdapter
            // 
            this.jet_brigadeTableAdapter.ClearBeforeFill = true;
            // 
            // jet_brigadeDataGridView
            // 
            this.jet_brigadeDataGridView.AutoGenerateColumns = false;
            this.jet_brigadeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.jet_brigadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jet_brigadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.jet_brigadeDataGridView.DataSource = this.jet_brigadeBindingSource;
            this.jet_brigadeDataGridView.Location = new System.Drawing.Point(239, 44);
            this.jet_brigadeDataGridView.Name = "jet_brigadeDataGridView";
            this.jet_brigadeDataGridView.Size = new System.Drawing.Size(198, 394);
            this.jet_brigadeDataGridView.TabIndex = 2;
            this.jet_brigadeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.jet_brigadeDataGridView_DataError);
            // 
            // brigadeBindingSource
            // 
            this.brigadeBindingSource.DataMember = "brigade";
            this.brigadeBindingSource.DataSource = this.airDataSet;
            // 
            // brigadeTableAdapter
            // 
            this.brigadeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_brigade";
            this.dataGridViewTextBoxColumn4.DataSource = this.brigadeBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "name_brigade";
            this.dataGridViewTextBoxColumn4.HeaderText = "прикрепленные бригады";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id_brigade";
            this.dataGridViewTextBoxColumn4.Width = 144;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_jet";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_jet";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "R_14";
            this.repairBindingSource.DataSource = this.jetBindingSource;
            // 
            // repairTableAdapter
            // 
            this.repairTableAdapter.ClearBeforeFill = true;
            // 
            // repairDataGridView
            // 
            this.repairDataGridView.AutoGenerateColumns = false;
            this.repairDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.repairDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.repairDataGridView.DataSource = this.repairBindingSource;
            this.repairDataGridView.Location = new System.Drawing.Point(443, 44);
            this.repairDataGridView.Name = "repairDataGridView";
            this.repairDataGridView.Size = new System.Drawing.Size(300, 394);
            this.repairDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_repair";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_repair";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_start";
            this.dataGridViewTextBoxColumn7.HeaderText = "дата начала ремонта";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 88;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "date_finish";
            this.dataGridViewTextBoxColumn8.HeaderText = "дата окончания ремонта,,";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 105;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_jet";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_jet";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // jet_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.repairDataGridView);
            this.Controls.Add(this.jet_brigadeDataGridView);
            this.Controls.Add(this.jetDataGridView);
            this.Controls.Add(this.jetBindingNavigator);
            this.Name = "jet_form";
            this.Text = "самолеты";
            this.Load += new System.EventHandler(this.jet_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jetBindingNavigator)).EndInit();
            this.jetBindingNavigator.ResumeLayout(false);
            this.jetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typejetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet_brigadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet_brigadeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brigadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airDataSet airDataSet;
        private System.Windows.Forms.BindingSource jetBindingSource;
        private airDataSetTableAdapters.jetTableAdapter jetTableAdapter;
        private airDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jetBindingNavigatorSaveItem;
        private airDataSetTableAdapters.type_jetTableAdapter type_jetTableAdapter;
        private System.Windows.Forms.DataGridView jetDataGridView;
        private System.Windows.Forms.BindingSource typejetBindingSource;
        private airDataSetTableAdapters.jet_brigadeTableAdapter jet_brigadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource jet_brigadeBindingSource;
        private airDataSetTableAdapters.brigadeTableAdapter brigadeTableAdapter;
        private System.Windows.Forms.DataGridView jet_brigadeDataGridView;
        private System.Windows.Forms.BindingSource brigadeBindingSource;
        private airDataSetTableAdapters.repairTableAdapter repairTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private System.Windows.Forms.DataGridView repairDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}