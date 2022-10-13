using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Sys
{
    public partial class PrintReceipt : Form
    {
        private List<InvoiceProductVM> _List;
        private string _Total, _Cash, _Change, _OpNo, _Date, _CashierName,_Discount,_PM;
        public PrintReceipt(List<InvoiceProductVM> List,string Total,string Cash,string Change,string OpNo,string Date,string CashierName,string Discount,string PM)
        {
            InitializeComponent();
            _Total = Total;
            _Cash = Cash;
            _Change = Change;
            _OpNo = OpNo;
            _Date = Date;
            _CashierName = CashierName;
            _List = List;
            _Discount = Discount;
            _PM = PM;
        }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("InvoiceDetails", _List);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_Date),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_Total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCashierName",_CashierName),
                new Microsoft.Reporting.WinForms.ReportParameter("pOperationNo",_OpNo),
                new Microsoft.Reporting.WinForms.ReportParameter("pPaymentMethod",_PM),
                new Microsoft.Reporting.WinForms.ReportParameter("pDIscount",_Discount)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
          
        }
    }
}
