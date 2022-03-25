using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Servises;


namespace Lab3
{
    static class Program
    {
        private static IContainer _container;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterTypes();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_container.Resolve<MainForm>());
        }
        private static void RegisterTypes()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Sinusoid>().As<IGraphics>();
            builder.RegisterType<MainForm>();
            _container = builder.Build();
        }
    }
}
