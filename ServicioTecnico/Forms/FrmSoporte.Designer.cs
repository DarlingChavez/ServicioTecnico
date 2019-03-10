namespace ServicioTecnico
{
    partial class FrmSoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoporte));
            this.panelControlProperties = new DevExpress.XtraEditors.PanelControl();
            this.memoEditDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.textEditCliente = new DevExpress.XtraEditors.TextEdit();
            this.textEditSerieMainBoard = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEditProcesador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.procesadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProcesador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFabricante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpEditMarca = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditMarcaView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControlData = new DevExpress.XtraEditors.PanelControl();
            this.gridControlEquipos = new DevExpress.XtraGrid.GridControl();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEquipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucMantenimientoEquipos = new ServicioTecnico.UcMantenimiento();
            this.xtraScrollableControlSoporte = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProperties)).BeginInit();
            this.panelControlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSerieMainBoard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProcesador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcesador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMarcaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlData)).BeginInit();
            this.panelControlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlProperties
            // 
            this.panelControlProperties.Controls.Add(this.memoEditDescripcion);
            this.panelControlProperties.Controls.Add(this.textEditCliente);
            this.panelControlProperties.Controls.Add(this.textEditSerieMainBoard);
            this.panelControlProperties.Controls.Add(this.labelControl6);
            this.panelControlProperties.Controls.Add(this.labelControl5);
            this.panelControlProperties.Controls.Add(this.labelControl4);
            this.panelControlProperties.Controls.Add(this.labelControl3);
            this.panelControlProperties.Controls.Add(this.searchLookUpEditProcesador);
            this.panelControlProperties.Controls.Add(this.searchLookUpEditMarca);
            this.panelControlProperties.Controls.Add(this.textEditId);
            this.panelControlProperties.Controls.Add(this.labelControl2);
            this.panelControlProperties.Controls.Add(this.labelControl1);
            this.panelControlProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlProperties.Location = new System.Drawing.Point(0, 84);
            this.panelControlProperties.Name = "panelControlProperties";
            this.panelControlProperties.Size = new System.Drawing.Size(872, 124);
            this.panelControlProperties.TabIndex = 1;
            // 
            // memoEditDescripcion
            // 
            this.memoEditDescripcion.Location = new System.Drawing.Point(443, 61);
            this.memoEditDescripcion.Name = "memoEditDescripcion";
            this.memoEditDescripcion.Size = new System.Drawing.Size(197, 57);
            this.memoEditDescripcion.TabIndex = 11;
            // 
            // textEditCliente
            // 
            this.textEditCliente.Location = new System.Drawing.Point(443, 32);
            this.textEditCliente.Name = "textEditCliente";
            this.textEditCliente.Size = new System.Drawing.Size(197, 20);
            this.textEditCliente.TabIndex = 10;
            // 
            // textEditSerieMainBoard
            // 
            this.textEditSerieMainBoard.Location = new System.Drawing.Point(443, 6);
            this.textEditSerieMainBoard.Name = "textEditSerieMainBoard";
            this.textEditSerieMainBoard.Size = new System.Drawing.Size(197, 20);
            this.textEditSerieMainBoard.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(318, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Descripción:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(318, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Cliente:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(318, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Serie de la mainboard:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Procesador: ";
            // 
            // searchLookUpEditProcesador
            // 
            this.searchLookUpEditProcesador.EditValue = "";
            this.searchLookUpEditProcesador.Location = new System.Drawing.Point(99, 58);
            this.searchLookUpEditProcesador.Name = "searchLookUpEditProcesador";
            this.searchLookUpEditProcesador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditProcesador.Properties.DataSource = this.procesadorBindingSource;
            this.searchLookUpEditProcesador.Properties.DisplayMember = "Descripcion";
            this.searchLookUpEditProcesador.Properties.NullText = "[Seleccione]";
            this.searchLookUpEditProcesador.Properties.NullValuePromptShowForEmptyValue = true;
            this.searchLookUpEditProcesador.Properties.PopupView = this.gridViewProcesador;
            this.searchLookUpEditProcesador.Properties.ShowClearButton = false;
            this.searchLookUpEditProcesador.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.searchLookUpEditProcesador.Properties.ShowPopupShadow = false;
            this.searchLookUpEditProcesador.Properties.ValueMember = "IdProcesador";
            this.searchLookUpEditProcesador.Size = new System.Drawing.Size(174, 20);
            this.searchLookUpEditProcesador.TabIndex = 4;
            // 
            // procesadorBindingSource
            // 
            this.procesadorBindingSource.DataSource = typeof(ServicioTecnico.Procesador);
            // 
            // gridViewProcesador
            // 
            this.gridViewProcesador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProcesador,
            this.colDescripcionProcesador,
            this.colFabricante,
            this.colEstadoProcesador});
            this.gridViewProcesador.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewProcesador.Name = "gridViewProcesador";
            this.gridViewProcesador.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewProcesador.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewProcesador.OptionsFind.AllowFindPanel = false;
            this.gridViewProcesador.OptionsMenu.EnableColumnMenu = false;
            this.gridViewProcesador.OptionsMenu.EnableFooterMenu = false;
            this.gridViewProcesador.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewProcesador.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProcesador.OptionsView.ShowGroupPanel = false;
            this.gridViewProcesador.OptionsView.ShowIndicator = false;
            // 
            // colIdProcesador
            // 
            this.colIdProcesador.FieldName = "IdProcesador";
            this.colIdProcesador.Name = "colIdProcesador";
            // 
            // colDescripcionProcesador
            // 
            this.colDescripcionProcesador.Caption = "Descripción";
            this.colDescripcionProcesador.FieldName = "Descripcion";
            this.colDescripcionProcesador.Name = "colDescripcionProcesador";
            this.colDescripcionProcesador.Visible = true;
            this.colDescripcionProcesador.VisibleIndex = 0;
            // 
            // colFabricante
            // 
            this.colFabricante.FieldName = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.Visible = true;
            this.colFabricante.VisibleIndex = 1;
            // 
            // colEstadoProcesador
            // 
            this.colEstadoProcesador.FieldName = "EstadoRegistro";
            this.colEstadoProcesador.Name = "colEstadoProcesador";
            // 
            // searchLookUpEditMarca
            // 
            this.searchLookUpEditMarca.EditValue = "";
            this.searchLookUpEditMarca.Location = new System.Drawing.Point(99, 32);
            this.searchLookUpEditMarca.Name = "searchLookUpEditMarca";
            this.searchLookUpEditMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditMarca.Properties.DataSource = this.marcaBindingSource;
            this.searchLookUpEditMarca.Properties.DisplayMember = "Descripcion";
            this.searchLookUpEditMarca.Properties.NullText = "[Seleccione]";
            this.searchLookUpEditMarca.Properties.NullValuePromptShowForEmptyValue = true;
            this.searchLookUpEditMarca.Properties.PopupView = this.searchLookUpEditMarcaView;
            this.searchLookUpEditMarca.Properties.ShowClearButton = false;
            this.searchLookUpEditMarca.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.searchLookUpEditMarca.Properties.ShowPopupShadow = false;
            this.searchLookUpEditMarca.Properties.ValueMember = "IdMarca";
            this.searchLookUpEditMarca.Size = new System.Drawing.Size(174, 20);
            this.searchLookUpEditMarca.TabIndex = 3;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(ServicioTecnico.Marca);
            // 
            // searchLookUpEditMarcaView
            // 
            this.searchLookUpEditMarcaView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMarca,
            this.colDescripcionMarca,
            this.colEstadoRegistro});
            this.searchLookUpEditMarcaView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditMarcaView.Name = "searchLookUpEditMarcaView";
            this.searchLookUpEditMarcaView.OptionsFind.AllowFindPanel = false;
            this.searchLookUpEditMarcaView.OptionsMenu.EnableColumnMenu = false;
            this.searchLookUpEditMarcaView.OptionsMenu.EnableFooterMenu = false;
            this.searchLookUpEditMarcaView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditMarcaView.OptionsView.ShowColumnHeaders = false;
            this.searchLookUpEditMarcaView.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEditMarcaView.OptionsView.ShowIndicator = false;
            // 
            // colIdMarca
            // 
            this.colIdMarca.FieldName = "IdMarca";
            this.colIdMarca.Name = "colIdMarca";
            // 
            // colDescripcionMarca
            // 
            this.colDescripcionMarca.FieldName = "Descripcion";
            this.colDescripcionMarca.Name = "colDescripcionMarca";
            this.colDescripcionMarca.Visible = true;
            this.colDescripcionMarca.VisibleIndex = 0;
            // 
            // colEstadoRegistro
            // 
            this.colEstadoRegistro.FieldName = "EstadoRegistro";
            this.colEstadoRegistro.Name = "colEstadoRegistro";
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(99, 6);
            this.textEditId.Name = "textEditId";
            this.textEditId.Properties.ReadOnly = true;
            this.textEditId.Size = new System.Drawing.Size(100, 20);
            this.textEditId.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Id :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Marca: ";
            // 
            // panelControlData
            // 
            this.panelControlData.Controls.Add(this.gridControlEquipos);
            this.panelControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlData.Location = new System.Drawing.Point(0, 208);
            this.panelControlData.Name = "panelControlData";
            this.panelControlData.Size = new System.Drawing.Size(872, 222);
            this.panelControlData.TabIndex = 2;
            // 
            // gridControlEquipos
            // 
            this.gridControlEquipos.DataSource = this.equipoBindingSource;
            this.gridControlEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEquipos.Location = new System.Drawing.Point(2, 2);
            this.gridControlEquipos.MainView = this.gridViewEquipos;
            this.gridControlEquipos.Name = "gridControlEquipos";
            this.gridControlEquipos.Size = new System.Drawing.Size(868, 218);
            this.gridControlEquipos.TabIndex = 0;
            this.gridControlEquipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEquipos});
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(ServicioTecnico.Equipo);
            // 
            // gridViewEquipos
            // 
            this.gridViewEquipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnDescripcion,
            this.gridColumnMarca,
            this.gridColumnFechaIngreso,
            this.gridColumnEstado});
            this.gridViewEquipos.GridControl = this.gridControlEquipos;
            this.gridViewEquipos.Name = "gridViewEquipos";
            this.gridViewEquipos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "IdEquipo";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // gridColumnDescripcion
            // 
            this.gridColumnDescripcion.Caption = "Descripción";
            this.gridColumnDescripcion.FieldName = "Descripcion";
            this.gridColumnDescripcion.Name = "gridColumnDescripcion";
            this.gridColumnDescripcion.Visible = true;
            this.gridColumnDescripcion.VisibleIndex = 1;
            // 
            // gridColumnMarca
            // 
            this.gridColumnMarca.Caption = "Marca";
            this.gridColumnMarca.FieldName = "Marca.Descripcion";
            this.gridColumnMarca.Name = "gridColumnMarca";
            this.gridColumnMarca.Visible = true;
            this.gridColumnMarca.VisibleIndex = 2;
            // 
            // gridColumnFechaIngreso
            // 
            this.gridColumnFechaIngreso.Caption = "Fecha de ingreso";
            this.gridColumnFechaIngreso.FieldName = "FechaIngreso";
            this.gridColumnFechaIngreso.Name = "gridColumnFechaIngreso";
            this.gridColumnFechaIngreso.Visible = true;
            this.gridColumnFechaIngreso.VisibleIndex = 3;
            // 
            // gridColumnEstado
            // 
            this.gridColumnEstado.Caption = "Estado";
            this.gridColumnEstado.FieldName = "Estado.Descripcion";
            this.gridColumnEstado.Name = "gridColumnEstado";
            this.gridColumnEstado.Visible = true;
            this.gridColumnEstado.VisibleIndex = 4;
            // 
            // ucMantenimientoEquipos
            // 
            this.ucMantenimientoEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucMantenimientoEquipos.Location = new System.Drawing.Point(0, 0);
            this.ucMantenimientoEquipos.Name = "ucMantenimientoEquipos";
            this.ucMantenimientoEquipos.Size = new System.Drawing.Size(872, 84);
            this.ucMantenimientoEquipos.TabIndex = 0;
            // 
            // xtraScrollableControlSoporte
            // 
            this.xtraScrollableControlSoporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControlSoporte.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControlSoporte.Name = "xtraScrollableControlSoporte";
            this.xtraScrollableControlSoporte.Size = new System.Drawing.Size(872, 430);
            this.xtraScrollableControlSoporte.TabIndex = 3;
            // 
            // FrmSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMinSize = new System.Drawing.Size(860, 420);
            this.ClientSize = new System.Drawing.Size(872, 430);
            this.Controls.Add(this.panelControlData);
            this.Controls.Add(this.panelControlProperties);
            this.Controls.Add(this.ucMantenimientoEquipos);
            this.Controls.Add(this.xtraScrollableControlSoporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSoporte";
            this.Text = "Soporte de pc\'s";
            this.Load += new System.EventHandler(this.FrmSoporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlProperties)).EndInit();
            this.panelControlProperties.ResumeLayout(false);
            this.panelControlProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSerieMainBoard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProcesador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProcesador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMarcaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlData)).EndInit();
            this.panelControlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UcMantenimiento ucMantenimientoEquipos;
        private DevExpress.XtraEditors.PanelControl panelControlProperties;
        private DevExpress.XtraEditors.PanelControl panelControlData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditMarcaView;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditProcesador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProcesador;
        private System.Windows.Forms.BindingSource procesadorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn colFabricante;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoProcesador;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEditSerieMainBoard;
        private DevExpress.XtraEditors.TextEdit textEditCliente;
        private DevExpress.XtraEditors.MemoEdit memoEditDescripcion;
        private DevExpress.XtraGrid.GridControl gridControlEquipos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEquipos;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMarca;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstado;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControlSoporte;
    }
}