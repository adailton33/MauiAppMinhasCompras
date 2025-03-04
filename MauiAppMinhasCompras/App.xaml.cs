using MauiAppMinhasCompras.Helpers;
using System.Security.Cryptography.X509Certificates;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        private static SQLiteDataBaseHelper _db;

        public static SQLiteDataBaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQLiteDataBaseHelper(path);
                }
                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
