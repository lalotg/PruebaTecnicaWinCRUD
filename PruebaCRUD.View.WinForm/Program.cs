using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebaCRUD.View.WinForm
{
    static class Program
    {
        [STAThread]
        static async Task Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //HttpClientMiTelcelHelper helper = new HttpClientMiTelcelHelper();
            //await helper.ConsultaNumeros();
        }
    }
}
