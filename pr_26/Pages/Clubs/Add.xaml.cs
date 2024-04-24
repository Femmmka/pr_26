﻿using System.Windows.Controls;

namespace pr_26.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        Main Main;
        Models.Clubs Club;
        public Add(Main Main, Models.Clubs Club=null)
        {
            InitializeComponent();
            this.Main = Main;
            if (Club != null)
            {
                this.Club = Club;
                this.Name.Text = Club.Name;
                this.Address.Text = Club.Address;
                this.WorkTime.Text = Club.WorkTime;
                BthAdd.Content = "Изменить";
            }
        }
        private void AddClub(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.Club == null)
            {
                Club = new Models.Clubs();
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
                this.Main.AllClub.Clubs.Add(this.Club);
            }
            else
            {
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
            }
            this.Main.AllClub.SaveChanges();
            MainWindow.init.OpenPages(new Pages.Clubs.Main());
        }
    }
}
