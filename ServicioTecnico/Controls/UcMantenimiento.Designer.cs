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
            this.panelControlFill = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControlMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemBorrar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).BeginInit();
            this.panelControlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlFill
            // 
            this.panelControlFill.Controls.Add(this.ribbonControlMantenimiento);
            this.panelControlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlFill.Location = new System.Drawing.Point(0, 0);
            this.panelControlFill.Name = "panelControlFill";
            this.panelControlFill.Size = new System.Drawing.Size(457, 78);
            this.panelControlFill.TabIndex = 0;
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
            this.barButtonItemBorrar});
            this.ribbonControlMantenimiento.Location = new System.Drawing.Point(2, 2);
            this.ribbonControlMantenimiento.MaxItemId = 6;
            this.ribbonControlMantenimiento.Name = "ribbonControlMantenimiento";
            this.ribbonControlMantenimiento.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMantenimiento});
            this.ribbonControlMantenimiento.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControlMantenimiento.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControlMantenimiento.ShowToolbarCustomizeItem = false;
            this.ribbonControlMantenimiento.Size = new System.Drawing.Size(453, 77);
            this.ribbonControlMantenimiento.Toolbar.ShowCustomizeItem = false;
            this.ribbonControlMantenimiento.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemNuevo
            // 
            this.barButtonItemNuevo.Caption = "Nuevo";
            this.barButtonItemNuevo.Id = 1;
            this.barButtonItemNuevo.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.additem_16x16;
            this.barButtonItemNuevo.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.additem_32x32;
            this.barButtonItemNuevo.Name = "barButtonItemNuevo";
            // 
            // barButtonItemEditar
            // 
            this.barButtonItemEditar.Caption = "Editar";
            this.barButtonItemEditar.Id = 2;
            this.barButtonItemEditar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.pictureshapeoutlinecolor_16x16;
            this.barButtonItemEditar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.barButtonItemEditar.Name = "barButtonItemEditar";
            // 
            // barButtonItemCancelar
            // 
            this.barButtonItemCancelar.Caption = "Cancelar";
            this.barButtonItemCancelar.Id = 3;
            this.barButtonItemCancelar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.reset_16x16;
            this.barButtonItemCancelar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.reset_32x32;
            this.barButtonItemCancelar.Name = "barButtonItemCancelar";
            // 
            // barButtonItemGuardar
            // 
            this.barButtonItemGuardar.Caption = "Guardar";
            this.barButtonItemGuardar.Id = 4;
            this.barButtonItemGuardar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.save_16x16;
            this.barButtonItemGuardar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.save_32x32;
            this.barButtonItemGuardar.Name = "barButtonItemGuardar";
            // 
            // barButtonItemBorrar
            // 
            this.barButtonItemBorrar.Caption = "Borrar";
            this.barButtonItemBorrar.Id = 5;
            this.barButtonItemBorrar.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.trash_16x16;
            this.barButtonItemBorrar.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.trash_32x32;
            this.barButtonItemBorrar.Name = "barButtonItemBorrar";
            // 
            // ribbonPageMantenimiento
            // 
            this.ribbonPageMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMantenimiento});
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
            // UcMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlFill);
            this.Name = "UcMantenimiento";
            this.Size = new System.Drawing.Size(457, 78);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlFill)).EndInit();
            this.panelControlFill.ResumeLayout(false);
            this.panelControlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlMantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlFill;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMantenimiento;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNuevo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEditar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCancelar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGuardar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBorrar;
    }
}
