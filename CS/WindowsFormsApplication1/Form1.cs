using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            report.Parameters.Add(new DevExpress.XtraReports.Parameters.Parameter() { Name = "CatID", Type = typeof(Int32), Value = 2, Description = "CategoryID" });

            SqlDataSource ds = report.DataSource as SqlDataSource;
            SelectQuery sq = ds.Queries[0] as SelectQuery;

            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "p1";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.CatID]");
            sq.Parameters.Add(queryParameter1);
            sq.FilterString = "CategoryID = ?p1";

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

    }

}
