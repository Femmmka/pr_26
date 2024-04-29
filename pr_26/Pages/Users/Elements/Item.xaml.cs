using System.Linq;
using System.Windows.Controls;
using pr_26.Classes;

namespace pr_26.Pages.Users.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {

        public ClubsContext AllClub = new ClubsContext();
        Main Main;
        Models.Users User;

        public Item(Models.Users User, Main Main)
        {
            InitializeComponent();
            this.FIO.Text = User.FIO;
            this.RentStart.Text = User.RentStart.ToString("yyyy-MM-dd");
            this.RentTime.Text = User.RentStart.ToString("HH:mm");
            this.Duration.Text = User.Duration.ToString();
            this.AllClub.Text = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
            this.Main = Main;
            this.User = User;
        }
        private void EditUser(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Users.Add(this.Main, this.User));
        private void DeleteUser(object sender,System.Windows.RoutedEventArgs e)
        {
            Main.AllUsers.Users.Remove(User);
            Main.AllUsers.SaveChanges();
            Main.Parent.Children.Remove(this);
        }

        //Шаг26
    }
}
