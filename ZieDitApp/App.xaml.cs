using ZieDitApp.MVVM.Models;
using ZieDitApp.Repositories;

namespace ZieDitApp
{
    public partial class App : Application
    {
        public static BaseRepository<AppUser>? AppUserRepo { get; private set; }
        public static BaseRepository<Activity>? ActivityRepo { get; private set; }
        public static BaseRepository<Event>? EventRepo { get; private set; }
        public App(BaseRepository<AppUser> appUserRepo, BaseRepository<Activity> activityRepo, BaseRepository<Event> eventRepo)
        {
            InitializeComponent();
            AppUserRepo = appUserRepo;
            ActivityRepo = activityRepo;
            EventRepo = eventRepo;

            AppUser Organizer = new AppUser() {firstName="Organisator", lastName="Orga", email = "organizer@gmail.com", password = "1234", role = "organizer" };
            appUserRepo.SaveEntity(Organizer);
            MainPage = new AppShell();
        }
    }
}