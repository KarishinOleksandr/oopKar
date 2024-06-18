using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba17
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск сервера в окремому потоці
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();

            Application.Run(new Form1());
        }

        static void StartServer()
        {
            ServerObject server = new ServerObject();
            server.Listen();
        }
    }
}
