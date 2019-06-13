using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic;
using Microsoft.Reporting.WinForms;
using Clinic;

namespace Clinic
{
    class C
    {
        public static List<Tuple<int, string>> Dentist = new List<Tuple<int, string>>();
        public static DataTable tblAll = new DataTable();



        public static void runReportRocheta(string select, frmRosheta p, DataTable table = null)
        {
            //عشان اقوله لو الجدول فاضى هديله البيانات من عندى 
            try
            {
                if (table == null)
                {
                    table = DB.GetData(select);
                }
                ReportDataSource rds = new ReportDataSource("DataSet1", table);

                p.reportViewer1.LocalReport.DataSources.Clear();
                p.reportViewer1.LocalReport.DataSources.Add(rds);
                p.reportViewer1.LocalReport.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void runPerportPatient_history(string select, patient_history p, DataTable table = null)
        {
            //عشان اقوله لو الجدول فاضى هديله البيانات من عندى 
            try
            {
                if (table == null)
                {
                    table = DB.GetData(select);
                }
                ReportDataSource rds = new ReportDataSource("DataSet1", table);

                p.report_patient_history.LocalReport.DataSources.Clear();
                p.report_patient_history.LocalReport.DataSources.Add(rds);
                p.report_patient_history.LocalReport.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RunReportstaff(string select, frmReportStaff p, DataTable table = null)
        {
            //عشان اقوله لو الجدول فاضى هديله البيانات من عندى 
            try
            {
                if (table == null)
                {
                    table = DB.GetData(select);
                }
                ReportDataSource rds = new ReportDataSource("DataSet1", table);
           
                p.reportStaff.LocalReport.DataSources.Clear();
                p.reportStaff.LocalReport.DataSources.Add(rds);
                p.reportStaff.LocalReport.Refresh();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //patient
        public static void RunReportpatient(string select,frmReportPatient p, DataTable table = null )
        {
           //عشان اقوله لو الجدول فاضى هديله البيانات من عندى 
           try
           {
                if (table == null)
                {
                    table = DB.GetData(select);
                }
                ReportDataSource rds = new ReportDataSource("DataSet1", table);
                
                p.reportPatient.LocalReport.DataSources.Clear();
                p.reportPatient.LocalReport.DataSources.Add(rds);
               p.reportPatient.LocalReport.Refresh();
           
           }
           catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }



       
    }
}

