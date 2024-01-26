using ZieDitApp.MVVM.Models;
using ZieDitApp.Repositories;

namespace ZieDitApp
{
    public partial class App : Application
    {
        public static BaseRepository<AppUser>? AppUserRepo { get; private set; }
        public static BaseRepository<Activity>? ActivityRepo { get; private set; }
        public static BaseRepository<Event>? EventRepo { get; private set; }

        public static BaseRepository<EventAppUser>? EventAppUserRepo { get; private set; }
        public App(BaseRepository<AppUser> appUserRepo, BaseRepository<Activity> activityRepo, BaseRepository<Event> eventRepo, BaseRepository<EventAppUser> eventAppUserRepo)
        {
            InitializeComponent();
            AppUserRepo = appUserRepo;
            ActivityRepo = activityRepo;
            EventRepo = eventRepo;
            EventAppUserRepo = eventAppUserRepo;

            AppUser Organizer = new AppUser() {firstName="Organisator", lastName="Orga", email = "organizer@gmail.com", password = "1234", role = "organizer" };
            List<AppUser> organizers = App.AppUserRepo.GetEntities().Where(a => a.role == "organizer").ToList();

            if(organizers.Count < 1 ) 
            {
                appUserRepo.SaveEntity(Organizer);
            }
            
            MainPage = new AppShell();
        }
    }
}