Partial Public Class FrmPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem6 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipSeparatorItem7 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem8 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.rcPrincipal = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiInventario = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCompras = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiFacturacion = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTesoreria = New DevExpress.XtraBars.BarButtonItem()
        Me.icImagenes = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rpComercial = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgInventario = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgCompras = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgFacturacion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgTesorería = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.rcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rcPrincipal
        '
        Me.rcPrincipal.ExpandCollapseItem.Id = 0
        Me.rcPrincipal.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rcPrincipal.ExpandCollapseItem, Me.bbiInventario, Me.bbiCompras, Me.bbiFacturacion, Me.bbiTesoreria})
        Me.rcPrincipal.LargeImages = Me.icImagenes
        Me.rcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.rcPrincipal.MaxItemId = 5
        Me.rcPrincipal.Name = "rcPrincipal"
        Me.rcPrincipal.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpComercial})
        Me.rcPrincipal.Size = New System.Drawing.Size(1353, 158)
        '
        'bbiInventario
        '
        Me.bbiInventario.Caption = "Ctrl. Inventario"
        Me.bbiInventario.Id = 1
        Me.bbiInventario.ImageOptions.LargeImageIndex = 3
        Me.bbiInventario.LargeWidth = 125
        Me.bbiInventario.Name = "bbiInventario"
        ToolTipTitleItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolTipTitleItem1.Appearance.ForeColor = System.Drawing.Color.Navy
        ToolTipTitleItem1.Appearance.Options.UseFont = True
        ToolTipTitleItem1.Appearance.Options.UseForeColor = True
        ToolTipTitleItem1.ImageOptions.Image = Global.ErpGuaca.My.Resources.Resources.info_32x32
        ToolTipTitleItem1.Text = "<b><size>Módulo de Control de Inventario</size></p>"
        ToolTipItem1.Text = "Desde este múduloi controlan los siguientes procesos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Creación de catálogos de " &
    "categorías, subcategorías," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "items, marcas, artículos, unidades de medida, copros" &
    " etc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem2)
        Me.bbiInventario.SuperTip = SuperToolTip1
        '
        'bbiCompras
        '
        Me.bbiCompras.Caption = "Ctrl. Compras"
        Me.bbiCompras.Id = 2
        Me.bbiCompras.ImageOptions.LargeImageIndex = 5
        Me.bbiCompras.LargeWidth = 125
        Me.bbiCompras.Name = "bbiCompras"
        ToolTipTitleItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolTipTitleItem2.Appearance.ForeColor = System.Drawing.Color.Navy
        ToolTipTitleItem2.Appearance.Options.UseFont = True
        ToolTipTitleItem2.Appearance.Options.UseForeColor = True
        ToolTipTitleItem2.ImageOptions.Image = Global.ErpGuaca.My.Resources.Resources.info_32x321
        ToolTipTitleItem2.Text = "<b>Módulo de Control de Compras</b>"
        ToolTipItem2.Text = "Desde este módulo se controlan los siguientes procesos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Números de parte xarícu" &
    "lo, proveedor, lead time x articulos," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x item generico, x proveedor etc."
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem4)
        Me.bbiCompras.SuperTip = SuperToolTip2
        '
        'bbiFacturacion
        '
        Me.bbiFacturacion.Caption = "Ctrl. Ventas"
        Me.bbiFacturacion.Id = 3
        Me.bbiFacturacion.ImageOptions.LargeImageIndex = 13
        Me.bbiFacturacion.LargeWidth = 125
        Me.bbiFacturacion.Name = "bbiFacturacion"
        ToolTipTitleItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolTipTitleItem3.Appearance.ForeColor = System.Drawing.Color.Navy
        ToolTipTitleItem3.Appearance.Options.UseFont = True
        ToolTipTitleItem3.Appearance.Options.UseForeColor = True
        ToolTipTitleItem3.ImageOptions.Image = Global.ErpGuaca.My.Resources.Resources.info_32x322
        ToolTipTitleItem3.Text = "<b>Módulo de Control de Ventas</b>"
        ToolTipItem3.Text = "Desde este módulo se controlan los siguientes procesos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Generación de ventas, c" &
    "otizaciones de clientes, préstamos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a bodega, pedidos a sucursales, etc."
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem6)
        Me.bbiFacturacion.SuperTip = SuperToolTip3
        '
        'bbiTesoreria
        '
        Me.bbiTesoreria.Caption = "Ctrl. Tesorería"
        Me.bbiTesoreria.Id = 4
        Me.bbiTesoreria.ImageOptions.LargeImageIndex = 15
        Me.bbiTesoreria.LargeWidth = 125
        Me.bbiTesoreria.Name = "bbiTesoreria"
        ToolTipTitleItem4.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ToolTipTitleItem4.Appearance.ForeColor = System.Drawing.Color.Navy
        ToolTipTitleItem4.Appearance.Options.UseFont = True
        ToolTipTitleItem4.Appearance.Options.UseForeColor = True
        ToolTipTitleItem4.ImageOptions.Image = Global.ErpGuaca.My.Resources.Resources.info_32x323
        ToolTipTitleItem4.Text = "<b>Módulo de Control de Tesorería</b>"
        ToolTipItem4.Text = "Desde este módulo se controlan lossiguienes  procesos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cobro de documentos, ing" &
    "reso de deposítiso de clientes," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cierres diarios de cajas, reportes de cajas, et" &
    "c"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem7)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem8)
        Me.bbiTesoreria.SuperTip = SuperToolTip4
        '
        'icImagenes
        '
        Me.icImagenes.ImageSize = New System.Drawing.Size(32, 32)
        Me.icImagenes.ImageStream = CType(resources.GetObject("icImagenes.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icImagenes.Images.SetKeyName(0, "Inventario04.png")
        Me.icImagenes.Images.SetKeyName(1, "Inventario03.png")
        Me.icImagenes.Images.SetKeyName(2, "Inventario02.png")
        Me.icImagenes.Images.SetKeyName(3, "Inventario01.png")
        Me.icImagenes.Images.SetKeyName(4, "Compras04.png")
        Me.icImagenes.Images.SetKeyName(5, "Compras03.png")
        Me.icImagenes.Images.SetKeyName(6, "Compras02.png")
        Me.icImagenes.Images.SetKeyName(7, "Compras01.png")
        Me.icImagenes.Images.SetKeyName(8, "Ventas07.png")
        Me.icImagenes.Images.SetKeyName(9, "Ventas06.png")
        Me.icImagenes.Images.SetKeyName(10, "Ventas04.png")
        Me.icImagenes.Images.SetKeyName(11, "Ventas03.png")
        Me.icImagenes.Images.SetKeyName(12, "Ventas02.png")
        Me.icImagenes.Images.SetKeyName(13, "Ventas01.png")
        Me.icImagenes.Images.SetKeyName(14, "Cajas08.png")
        Me.icImagenes.Images.SetKeyName(15, "Cajas07.png")
        Me.icImagenes.Images.SetKeyName(16, "Cajas06.png")
        Me.icImagenes.Images.SetKeyName(17, "Cajas05.png")
        Me.icImagenes.Images.SetKeyName(18, "Cajas04.png")
        Me.icImagenes.Images.SetKeyName(19, "Cajas03.png")
        Me.icImagenes.Images.SetKeyName(20, "Cajas02.png")
        Me.icImagenes.Images.SetKeyName(21, "Cajas01.png")
        '
        'rpComercial
        '
        Me.rpComercial.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgInventario, Me.rpgCompras, Me.rpgFacturacion, Me.rpgTesorería})
        Me.rpComercial.Name = "rpComercial"
        Me.rpComercial.Text = "Comercial"
        '
        'rpgInventario
        '
        Me.rpgInventario.AllowTextClipping = False
        Me.rpgInventario.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[True]
        Me.rpgInventario.ItemLinks.Add(Me.bbiInventario)
        Me.rpgInventario.Name = "rpgInventario"
        Me.rpgInventario.Text = "Inventario"
        '
        'rpgCompras
        '
        Me.rpgCompras.ItemLinks.Add(Me.bbiCompras)
        Me.rpgCompras.Name = "rpgCompras"
        Me.rpgCompras.Text = "Compras"
        '
        'rpgFacturacion
        '
        Me.rpgFacturacion.ItemLinks.Add(Me.bbiFacturacion)
        Me.rpgFacturacion.Name = "rpgFacturacion"
        Me.rpgFacturacion.Text = "Facturación"
        '
        'rpgTesorería
        '
        Me.rpgTesorería.ItemLinks.Add(Me.bbiTesoreria)
        Me.rpgTesorería.Name = "rpgTesorería"
        Me.rpgTesorería.Text = "Tesorería"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 762)
        Me.Controls.Add(Me.rcPrincipal)
        Me.Name = "FrmPrincipal"
        Me.Ribbon = Me.rcPrincipal
        Me.Text = "Erp-Guaca"
        CType(Me.rcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents rcPrincipal As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rpComercial As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents rpgInventario As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiInventario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents icImagenes As DevExpress.Utils.ImageCollection
    Friend WithEvents bbiCompras As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCompras As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiFacturacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgFacturacion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgTesorería As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiTesoreria As DevExpress.XtraBars.BarButtonItem
End Class
