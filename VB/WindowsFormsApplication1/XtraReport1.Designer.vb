Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
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

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 150F
            Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
            Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Dpi = 100F
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(5F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2, Me.xrTableRow4, Me.xrTableRow3})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(428.3333F, 150F)
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8})
            Me.xrTableRow2.Dpi = 100F
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.StylePriority.UseBorders = False
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Dpi = 100F
            Me.xrTableCell7.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseFont = False
            Me.xrTableCell7.Text = "CategoryID"
            Me.xrTableCell7.Weight = 1.5125286900008392R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryID")})
            Me.xrTableCell8.Dpi = 100F
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.Weight = 2R
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell11, Me.xrTableCell12})
            Me.xrTableRow4.Dpi = 100F
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.StylePriority.UseBorders = False
            Me.xrTableRow4.Weight = 1R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Dpi = 100F
            Me.xrTableCell11.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StylePriority.UseFont = False
            Me.xrTableCell11.Text = "Category Name"
            Me.xrTableCell11.Weight = 1.5125286900008392R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrTableCell12.Dpi = 100F
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.StylePriority.UseBorders = False
            Me.xrTableCell12.Text = "xrTableCell12"
            Me.xrTableCell12.Weight = 2R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10})
            Me.xrTableRow3.Dpi = 100F
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.StylePriority.UseBorders = False
            Me.xrTableRow3.Weight = 1R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Dpi = 100F
            Me.xrTableCell9.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StylePriority.UseFont = False
            Me.xrTableCell9.Text = "Description"
            Me.xrTableCell9.Weight = 1.5125286900008392R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrTableCell10.Dpi = 100F
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Text = "xrTableCell10"
            Me.xrTableCell10.Weight = 2R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "NORTHWND_Connection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            columnExpression4.ColumnName = "ProductID"
            table2.Name = "Products"
            columnExpression4.Table = table2
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ProductName"
            columnExpression5.Table = table2
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "SupplierID"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "CategoryID"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "QuantityPerUnit"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "UnitPrice"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            selectQuery2.Columns.Add(column4)
            selectQuery2.Columns.Add(column5)
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Name = "Products"
            selectQuery2.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            masterDetailInfo1.Name = "FK_Products_Categories"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.Dpi = 100F
            Me.pageFooterBand1.HeightF = 28F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Dpi = 100F
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5F, 5F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(315F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Dpi = 100F
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(330F, 5F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(315F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' calculatedField1
            ' 
            Me.calculatedField1.DataMember = "Categories"
            Me.calculatedField1.Name = "calculatedField1"
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
            Me.DetailReport.DataMember = "Categories.FK_Products_Categories"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Dpi = 100F
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail1.Dpi = 100F
            Me.Detail1.HeightF = 25F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Dpi = 100F
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow1.Dpi = 100F
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.CategoryID")})
            Me.xrTableCell1.Dpi = 100F
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 2R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.ProductID")})
            Me.xrTableCell2.Dpi = 100F
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 2R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.ProductName")})
            Me.xrTableCell3.Dpi = 100F
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 2R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.QuantityPerUnit")})
            Me.xrTableCell4.Dpi = 100F
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 2R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.SupplierID")})
            Me.xrTableCell5.Dpi = 100F
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.Weight = 2R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.FK_Products_Categories.UnitPrice")})
            Me.xrTableCell6.Dpi = 100F
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Text = "xrTableCell6"
            Me.xrTableCell6.Weight = 2R
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.DetailReport})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedField1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "16.1"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private calculatedField1 As DevExpress.XtraReports.UI.CalculatedField
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
