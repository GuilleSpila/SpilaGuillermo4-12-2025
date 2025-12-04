using examenProg;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                if (!db.Canchas.Any())
                {
                    db.Canchas.AddRange(
                        new Cancha { Nombre = "Cancha Futbol1", Tipo = TipoCancha.Futbol, Activa = true },
                        new Cancha { Nombre = "Cancha Tenis1", Tipo = TipoCancha.Tenis, Activa = true },
                        new Cancha { Nombre = "Cancha Padel1", Tipo = TipoCancha.Padel, Activa = true }
                    );
                }
                if (!db.Socios.Any())
                {
                    db.Socios.AddRange(
                        new Socio { Nombre = "Socio Ejemplo", Documento = "00000000", CorreoElectronico = "ejemplo@correo.com" }
                    );
                }
                db.SaveChanges();
            }
            Application.Run(new Form1());
        }
    }
}