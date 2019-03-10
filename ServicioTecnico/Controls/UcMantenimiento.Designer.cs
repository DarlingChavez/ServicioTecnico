namespace ServicioTecnico
{
    partial class UcMantenimiento
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPageMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBorrar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroupRefresh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditHasta = new DevExpress.XtraEditors.DateEdit();
            this.ribbonControlMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDesde = new DevExpress.XtraEditors.DateEdit();
            this.simpleButtonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlFill = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).BeginInit();
            this.panelControlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ribbonPageMantenimiento
            // 
            this.ribbonPageMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMantenimiento,
            this.ribbonPageGroupRefresh});
            this.ribbonPageMantenimiento.Name = "ribbonPageMantenimiento";
            this.ribbonPageMantenimiento.Text = "Mantenimiento";
            // 
            // ribbonPageGroupMantenimiento
            // 
            this.ribbonPageGroupMantenimiento.ItemLinks.Add(this.barButtonItemNuevo);
            this.ribbonPageGroupMantenimiento.ItemLinks.Add(this.barButtonItemEditar);
            this.ribbonPageGroupMantenimiento.ItemLinks.Add(this.barButtonItemCancelar);
            this.ribbonPageGroupMantenimiento.ItemLinks.Add(this.barButtonItemGuardar);
            this.ribbonPageGroupMantenimiento.ItemLinks.Add(this.barButtonItemBorrar);
            this.ribbonPageGroupMantenimiento.Name = "ribbonPageGroupMantenimiento";
            // 
            // barButtonItemNuevo
            // 
            this.barButtonItemNuevo.Caption = "Nuevo";
            this.barButtonItemNuevo.Id = 1;
            this.barButtonItemNuevo.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.additem_16x16;
            this.barButtonItemNuevo.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.additem_32x32;
            this.barButtonItemNuevo.Name = "barButtonItemNuevo";
            this.barButtonItemNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNuevo_ItemClick);
            // 
            // barButtonItemEditar
            // 
            this.barButtonItemEditar.Caption = "Editar";
            this.barButtonItemEditar.Enabled = false;
            this.barButtonItemEditar.Id = 2;
            this.barButtonItemEditar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.snapmodifytablecellstyle_16x16;
            this.barButtonItemEditar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.snapmodifytablecellstyle_32x32;
            this.barButtonItemEditar.Name = "barButtonItemEditar";
            this.barButtonItemEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEditar_ItemClick);
            // 
            // barButtonItemCancelar
            // 
            this.barButtonItemCancelar.Caption = "Cancelar";
            this.barButtonItemCancelar.Enabled = false;
            this.barButtonItemCancelar.Id = 3;
            this.barButtonItemCancelar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.reset_16x16;
            this.barButtonItemCancelar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.reset_32x32;
            this.barButtonItemCancelar.Name = "barButtonItemCancelar";
            this.barButtonItemCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCancelar_ItemClick);
            // 
            // barButtonItemGuardar
            // 
            this.barButtonItemGuardar.Caption = "Guardar";
            this.barButtonItemGuardar.Enabled = false;
            this.barButtonItemGuardar.Id = 4;
            this.barButtonItemGuardar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.save_16x16;
            this.barButtonItemGuardar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.save_32x32;
            this.barButtonItemGuardar.Name = "barButtonItemGuardar";
            this.barButtonItemGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGuardar_ItemClick);
            // 
            // barButtonItemBorrar
            // 
            this.barButtonItemBorrar.Caption = "Borrar";
            this.barButtonItemBorrar.Enabled = false;
            this.barButtonItemBorrar.Id = 5;
            this.barButtonItemBorrar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.trash_16x16;
            this.barButtonItemBorrar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.trash_32x32;
            this.barButtonItemBorrar.Name = "barButtonItemBorrar";
            this.barButtonItemBorrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBorrar_ItemClick);
            // 
            // ribbonPageGroupRefresh
            // 
            this.ribbonPageGroupRefresh.ItemLinks.Add(this.barButtonItemRefresh);
            this.ribbonPageGroupRefresh.Name = "ribbonPageGroupRefresh";
            this.ribbonPageGroupRefresh.Text = "ribbonPageGroup1";
            // 
            // barButtonItemRefresh
            // 
            this.barButtonItemRefresh.Caption = "Re-cargar";
            this.barButtonItemRefresh.Id = 6;
            this.barButtonItemRefresh.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.refresh_16x16;
            this.barButtonItemRefresh.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.refresh_32x32;
            this.barButtonItemRefresh.Name = "barButtonItemRefresh";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemSearchControl1;
            this.barEditItem1.Id = 9;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemDateEdit1;
            this.barEditItem2.Id = 11;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Location = new System.Drawing.Point(387, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Desde:";
            // 
            // dateEditHasta
            // 
            this.dateEditHasta.EditValue = null;
            this.dateEditHasta.Location = new System.Drawing.Point(520, 35);
            this.dateEditHasta.MenuManager = this.ribbonControlMantenimiento;
            this.dateEditHasta.Name = "dateEditHasta";
            this.dateEditHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditHasta.Size = new System.Drawing.Size(127, 20);
            this.dateEditHasta.TabIndex = 2;
            // 
            // ribbonControlMantenimiento
            // 
            this.ribbonControlMantenimiento.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControlMantenimiento.ExpandCollapseItem.Id = 0;
            this.ribbonControlMantenimiento.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlMantenimiento.ExpandCollapseItem,
            this.barButtonItemNuevo,
            this.barButtonItemEditar,
            this.barButtonItemCancelar,
            this.barButtonItemGuardar,
            this.barButtonItemBorrar,
            this.barButtonItemRefresh,
            this.barEditItem1,
            this.barSubItem1,
            this.barEditItem2});
            this.ribbonControlMantenimiento.Location = new System.Drawing.Point(2, 2);
            this.ribbonControlMantenimiento.MaxItemId = 13;
            this.ribbonControlMantenimiento.Name = "ribbonControlMantenimiento";
            this.ribbonControlMantenimiento.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMantenimiento});
            this.ribbonControlMantenimiento.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControlMantenimiento.ShowCategoryInCaption = false;
            this.ribbonControlMantenimiento.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControlMantenimiento.ShowQatLocationSelector = false;
            this.ribbonControlMantenimiento.ShowToolbarCustomizeItem = false;
            this.ribbonControlMantenimiento.Size = new System.Drawing.Size(969, 77);
            this.ribbonControlMantenimiento.Toolbar.ShowCustomizeItem = false;
            this.ribbonControlMantenimiento.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Location = new System.Drawing.Point(520, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Hasta:";
            // 
            // dateEditDesde
            // 
            this.dateEditDesde.EditValue = null;
            this.dateEditDesde.Location = new System.Drawing.Point(387, 35);
            this.dateEditDesde.MenuManager = this.ribbonControlMantenimiento;
            this.dateEditDesde.Name = "dateEditDesde";
            this.dateEditDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDesde.Size = new System.Drawing.Size(127, 20);
            this.dateEditDesde.TabIndex = 1;
            // 
            // simpleButtonSearch
            // 
            this.simpleButtonSearch.Appearance.Image = global::ServicioTecnico.Properties.Resources.busqueda;
            this.simpleButtonSearch.Appearance.Options.UseImage = true;
            this.simpleButtonSearch.Appearance.Options.UseTextOptions = true;
            this.simpleButtonSearch.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButtonSearch.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.busqueda;
            this.simpleButtonSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButtonSearch.Location = new System.Drawing.Point(653, 16);
            this.simpleButtonSearch.Name = "simpleButtonSearch";
            this.simpleButtonSearch.Size = new System.Drawing.Size(69, 43);
            this.simpleButtonSearch.TabIndex = 5;
            this.simpleButtonSearch.Click += new System.EventHandler(this.simpleButtonSearch_Click);
            // 
            // panelControlFill
            // 
            this.panelControlFill.Controls.Add(this.simpleButtonExit);
            this.panelControlFill.Controls.Add(this.simpleButtonSearch);
            this.panelControlFill.Controls.Add(this.dateEditDesde);
            this.panelControlFill.Controls.Add(this.labelControl2);
            this.panelControlFill.Controls.Add(this.dateEditHasta);
            this.panelControlFill.Controls.Add(this.labelControl1);
            this.panelControlFill.Controls.Add(this.ribbonControlMantenimiento);
            this.panelControlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFill.Location = new System.Drawing.Point(0, 0);
            this.panelControlFill.Name = "panelControlFill";
            this.panelControlFill.Size = new System.Drawing.Size(973, 79);
            this.panelControlFill.TabIndex = 0;
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonExit.Appearance.Image = global::ServicioTecnico.Properties.Resources.close_32x321;
            this.simpleButtonExit.Appearance.Options.UseImage = true;
            this.simpleButtonExit.Appearance.Options.UseTextOptions = true;
            this.simpleButtonExit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButtonExit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButtonExit.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.close_32x32;
            this.simpleButtonExit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonExit.Location = new System.Drawing.Point(895, 16);
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(55, 43);
            this.simpleButtonExit.TabIndex = 9;
            this.simpleButtonExit.Click += new System.EventHandler(this.simpleButtonExit_Click);
            // 
            // UcMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlFill);
            this.Name = "UcMantenimiento";
            this.Size = new System.Drawing.Size(973, 79);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).EndInit();
            this.panelControlFill.ResumeLayout(false);
            this.panelControlFill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMantenimiento;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNuevo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancelar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGuardar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBorrar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEditHasta;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMantenimiento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEditDesde;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSearch;
        private DevExpress.XtraEditors.PanelControl panelControlFill;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}
