Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess.Sql

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim report As New XtraReport1()
            report.Parameters.Add(New DevExpress.XtraReports.Parameters.Parameter() With {.Name = "CatID", .Type = GetType(Int32), .Value = 2, .Description = "CategoryID"})

            Dim ds As SqlDataSource = TryCast(report.DataSource, SqlDataSource)
            Dim tq As TableQuery = TryCast(ds.Queries(0), TableQuery)


            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            queryParameter1.Name = "p1"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.CatID]")
            tq.Parameters.Add(queryParameter1)
            tq.FilterString = "CategoryID = ?p1"

            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

    End Class

End Namespace
