using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MSTR.MSTRWS;

namespace MSTR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSTRWS.MSTRWS ws_Microstrategy = new MSTR.MSTRWS.MSTRWS();
            ws_Microstrategy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            MWSConnectInfo cInfo = new MWSConnectInfo();
            cInfo.Login = "ALMAGESTO";
            cInfo.Password = "Hipatia de Alejandría";
            cInfo.ProjectName = "DAE Integración";
            cInfo.ProjectSource = "FRATERNO";
            //string iServer_session = ws_Microstrategy.TestService("FRATERNO", "DAE Integración", "ALMAGESTO", "Hipatia de Alejandría");
            txt_SessionInfo.Text = ws_Microstrategy.Connect(cInfo);
            MWSResultsWindow report_Window = new MWSResultsWindow();
            report_Window.MaxRows = 1000;
            MWSExecuteInfo resultado = ws_Microstrategy.ExecuteReport(cInfo,
                                                                        "Transacciones por día",
                                                                        "09C8AE4946813975AFB19C9E4E2EB70B",
                                                                        String.Empty,
                                                                        EnumMWSExecutionFlags.MWSUseDefaultPrompts,
                                                                        report_Window, String.Empty,
                                                                        EnumMWSResultFlags.MWSReturnAsHTML, new MWSExecutionSettings());
            txt_SessionInfo.Text = resultado.ResultHTML;
            //MWSExecuteInfo resultado = ws_Microstrategy.SimpleExecuteReport(cInfo,
            //                                                            "Transacciones por día",
            //                                                            String.Empty,
            //                                                            String.Empty);
            //rtxt_HTML.Text = resultado.ResultHTML;
            wb_Resultado.Navigate("about:blank");
            wb_Resultado.Document.Write(resultado.ResultHTML);
            //txt_SessionInfo.Text = ws_Microstrategy.Disconnect(cInfo);

        }
    }
}