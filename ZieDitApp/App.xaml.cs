using ZieDitApp.MVVM.Models;
using ZieDitApp.Repositories;

namespace ZieDitApp
{
    public partial class App : Application
    {
        public static BaseRepository<AppUser>? AppUserRepo { get; private set; }
        public App(BaseRepository<AppUser> appUserRepo)
        {
            InitializeComponent();
            AppUserRepo = appUserRepo;
            AppUser Organizer = new AppUser() {firstName="Organisator", lastName="Orga", email = "organizer@gmail.com", password = "1234", role = "organizer" };
            appUserRepo.SaveEntity(Organizer);
            MainPage = new AppShell();
        }
    }
}