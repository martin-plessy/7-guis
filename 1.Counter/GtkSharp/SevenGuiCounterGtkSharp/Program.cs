using System;
using Gtk;

namespace SevenGuiCounterGtkSharp
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.GtkNamespace.GtkNamespace", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new CounterWindow();
            app.AddWindow(win);

            win.ShowAll();
            Application.Run();
        }
    }
}
