namespace air_app
{
    partial class typeFlight_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(typeFlight_form));
            this.airDataSet = new air_app.airDataSet();
            this.type_flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_flightTableAdapter = new air_app.airDataSetTableAdapters.type_flightTableAdapter();
            this.tableAdapterManager = new air_app.airDataSetTableAdapters.TableAdapterManager();
            this.type_flightBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.type_flightBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.type_flightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightBindingNavigator)).BeginInit();
            this.type_flightBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airDataSet
            // 
            this.airDataSet.DataSetName = "airDataSet";
            this.airDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_flightBindingSource
            // 
            this.type_flightBindingSource.DataMember = "type_flight";
            this.type_flightBindingSource.DataSource = this.airDataSet;
            // 
            // type_flightTableAdapter
            // 
            this.type_flightTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.brigadeTableAdapter = null;
            this.tableAdapterManager.checkupTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.delaysTableAdapter = null;
            this.tableAdapterManager.departamentTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.flight_cityTableAdapter = null;
            this.tableAdapterManager.flightTableAdapter = null;
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
            // type_flightBindingNavigator
            // 
            this.type_flightBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.type_flightBindingNavigator.BindingSource = this.type_flightBindingSource;
            this.type_flightBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.type_flightBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.type_flightBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.type_flightBindingNavigatorSaveItem});
            this.type_flightBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.type_flightBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.type_flightBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.type_flightBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.type_flightBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.type_flightBindingNavigator.Name = "type_flightBindingNavigator";
            this.type_flightBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.type_flightBindingNavigator.Size = new System.Drawing.Size(360, 25);
            this.type_flightBindingNavigator.TabIndex = 0;
            this.type_flightBindingNavigator.Text = "bindingNavigator1";
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
            // type_flightBindingNavigatorSaveItem
            // 
            this.type_flightBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.type_flightBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("type_flightBindingNavigatorSaveItem.Image")));
            this.type_flightBindingNavigatorSaveItem.Name = "type_flightBindingNavigatorSaveItem";
            this.type_flightBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.type_flightBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.type_flightBindingNavigatorSaveItem.Click += new System.EventHandler(this.type_flightBindingNavigatorSaveItem_Click);
            // 
            // type_flightDataGridView
            // 
            this.type_flightDataGridView.AllowUserToAddRows = false;
            this.type_flightDataGridView.AutoGenerateColumns = false;
            this.type_flightDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.type_flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.type_flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.type_flightDataGridView.DataSource = this.type_flightBindingSource;
            this.type_flightDataGridView.Location = new System.Drawing.Point(12, 38);
            this.type_flightDataGridView.Name = "type_flightDataGridView";
            this.type_flightDataGridView.Size = new System.Drawing.Size(333, 400);
            this.type_flightDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_type";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 49;
            // 
            // typeFlight_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.type_flightDataGridView);
            this.Controls.Add(this.type_flightBindingNavigator);
            this.Name = "typeFlight_form";
            this.Text = "тип рейса";
            this.Load += new System.EventHandler(this.typeFlight_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightBindingNavigator)).EndInit();
            this.type_flightBindingNavigator.ResumeLayout(false);
            this.type_flightBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.type_flightDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airDataSet airDataSet;
        private System.Windows.Forms.BindingSource type_flightBindingSource;
        private airDataSetTableAdapters.type_flightTableAdapter type_flightTableAdapter;
        private airDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator type_flightBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton type_flightBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView type_flightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}