namespace ServicioTecnico
{
    partial class FrmMain
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerSplash = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ServicioTecnico.SplashScreenMain), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.applicationMenuMain = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.barSubItemSistema = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemConfiguracion = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItemForms = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barButtonItemSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemRegistrar = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemEquipo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGarantia = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemInventario = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemConsultar = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemAyuda = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemAboutMe = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedViewMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.splashScreenManagerWait = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ServicioTecnico.FrmWaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManagerSplash
            // 
            splashScreenManagerSplash.ClosingDelay = 500;
            // 
            // applicationMenuMain
            // 
            this.applicationMenuMain.Name = "applicationMenuMain";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemSistema,
            this.barButtonItemConfiguracion,
            this.barMdiChildrenListItemForms,
            this.barButtonItemSalir,
            this.barSubItemRegistrar,
            this.barButtonItemEquipo,
            this.barButtonItemGarantia,
            this.barButtonItemInventario,
            this.barSubItemConsultar,
            this.barSubItemAyuda,
            this.barButtonItemAboutMe});
            this.barManagerMain.MainMenu = this.barMain;
            this.barManagerMain.MaxItemId = 11;
            // 
            // barMain
            // 
            this.barMain.BarName = "BarMain";
            this.barMain.CanDockStyle = ((DevExpress.XtraBars.BarCanDockStyle)(((((DevExpress.XtraBars.BarCanDockStyle.Left | DevExpress.XtraBars.BarCanDockStyle.Top) 
            | DevExpress.XtraBars.BarCanDockStyle.Right) 
            | DevExpress.XtraBars.BarCanDockStyle.Bottom) 
            | DevExpress.XtraBars.BarCanDockStyle.Standalone)));
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.FloatLocation = new System.Drawing.Point(76, 191);
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemSistema),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemRegistrar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemConsultar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItemAyuda)});
            this.barMain.OptionsBar.AllowQuickCustomization = false;
            this.barMain.OptionsBar.DisableClose = true;
            this.barMain.OptionsBar.DisableCustomization = true;
            this.barMain.OptionsBar.DrawBorder = false;
            this.barMain.OptionsBar.DrawDragBorder = false;
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Menu principal";
            // 
            // barSubItemSistema
            // 
            this.barSubItemSistema.Caption = "Sistema";
            this.barSubItemSistema.Id = 0;
            this.barSubItemSistema.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemConfiguracion),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItemForms),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSalir)});
            this.barSubItemSistema.Name = "barSubItemSistema";
            // 
            // barButtonItemConfiguracion
            // 
            this.barButtonItemConfiguracion.Caption = "Configuración";
            this.barButtonItemConfiguracion.Id = 1;
            this.barButtonItemConfiguracion.Name = "barButtonItemConfiguracion";
            // 
            // barMdiChildrenListItemForms
            // 
            this.barMdiChildrenListItemForms.Caption = "Formularios";
            this.barMdiChildrenListItemForms.Id = 2;
            this.barMdiChildrenListItemForms.Name = "barMdiChildrenListItemForms";
            // 
            // barButtonItemSalir
            // 
            this.barButtonItemSalir.Caption = "Salir";
            this.barButtonItemSalir.Id = 3;
            this.barButtonItemSalir.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.close_16x16;
            this.barButtonItemSalir.ImageOptions.LargeImage = global::ServicioTecnico.Properties.Resources.close_32x322;
            this.barButtonItemSalir.Name = "barButtonItemSalir";
            this.barButtonItemSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSalir_ItemClick);
            // 
            // barSubItemRegistrar
            // 
            this.barSubItemRegistrar.Caption = "Registrar";
            this.barSubItemRegistrar.Id = 4;
            this.barSubItemRegistrar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEquipo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemGarantia),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemInventario)});
            this.barSubItemRegistrar.Name = "barSubItemRegistrar";
            // 
            // barButtonItemEquipo
            // 
            this.barButtonItemEquipo.Caption = "Equipo";
            this.barButtonItemEquipo.Id = 5;
            this.barButtonItemEquipo.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.servermode_32x32;
            this.barButtonItemEquipo.Name = "barButtonItemEquipo";
            this.barButtonItemEquipo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEquipo_ItemClick);
            // 
            // barButtonItemGarantia
            // 
            this.barButtonItemGarantia.Caption = "Garantía";
            this.barButtonItemGarantia.Id = 6;
            this.barButtonItemGarantia.ImageOptions.Image = global::ServicioTecnico.Properties.Resources.formatwraptext_32x32;
            this.barButtonItemGarantia.Name = "barButtonItemGarantia";
            this.barButtonItemGarantia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGarantia_ItemClick);
            // 
            // barButtonItemInventario
            // 
            this.barButtonItemInventario.Caption = "Inventario";
            this.barButtonItemInventario.Id = 7;
            this.barButtonItemInventario.Name = "barButtonItemInventario";
            this.barButtonItemInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemInventario_ItemClick);
            // 
            // barSubItemConsultar
            // 
            this.barSubItemConsultar.Caption = "Consultar";
            this.barSubItemConsultar.Id = 8;
            this.barSubItemConsultar.Name = "barSubItemConsultar";
            // 
            // barSubItemAyuda
            // 
            this.barSubItemAyuda.Caption = "Ayuda";
            this.barSubItemAyuda.Id = 9;
            this.barSubItemAyuda.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAboutMe)});
            this.barSubItemAyuda.Name = "barSubItemAyuda";
            // 
            // barButtonItemAboutMe
            // 
            this.barButtonItemAboutMe.Caption = "Acerca del producto";
            this.barButtonItemAboutMe.Id = 10;
            this.barButtonItemAboutMe.Name = "barButtonItemAboutMe";
            this.barButtonItemAboutMe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAboutMe_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerMain;
            this.barDockControlTop.Size = new System.Drawing.Size(874, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 436);
            this.barDockControlBottom.Manager = this.barManagerMain;
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManagerMain;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 414);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 22);
            this.barDockControlRight.Manager = this.barManagerMain;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 414);
            // 
            // documentManagerMain
            // 
            this.documentManagerMain.MdiParent = this;
            this.documentManagerMain.MenuManager = this.barManagerMain;
            this.documentManagerMain.View = this.tabbedViewMain;
            this.documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedViewMain});
            // 
            // splashScreenManagerWait
            // 
            this.splashScreenManagerWait.ClosingDelay = 500;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 436);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(888, 469);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de servicio técnico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenuMain;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.BarSubItem barSubItemSistema;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItemConfiguracion;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItemForms;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSalir;
        private DevExpress.XtraBars.BarSubItem barSubItemRegistrar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEquipo;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGarantia;
        private DevExpress.XtraBars.BarButtonItem barButtonItemInventario;
        private DevExpress.XtraBars.BarSubItem barSubItemConsultar;
        private DevExpress.XtraBars.BarSubItem barSubItemAyuda;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAboutMe;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerMain;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedViewMain;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerWait;
    }
}