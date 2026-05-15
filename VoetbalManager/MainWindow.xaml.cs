using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VoetbalManager.Models;

namespace VoetbalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Team> _teams;
            List<Stadium> _stadiums;
            Dictionary<DateTime, List<Match>> _matchCalendar;

            _teams = Data.LoadMockDataTeam();
            _stadiums = Data.LoadMockDataStadium();
            _matchCalendar = Data.LoadMockDataPlanner(_teams, _stadiums);

            foreach (Team team in _teams)
            {
                teamsComboBox.Items.Add(team);
            }

            teamsComboBox.SelectedIndex = 0;
        }

        

        private void OnAddTeamButtonClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teamNameTextBox.Text))
                {
                MessageBox.Show("Geef de naam van je team in.");
                return;
            }
            
            Team team = new Team(teamNameTextBox.Text);

            teamsComboBox.Items.Add(team);
            teamsComboBox.SelectedIndex = (teamsComboBox.Items.Count) -1 ;
            teamNameTextBox.Clear();
        }

        private void OnTeamSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            footballersListBox.Items.Clear();
            
            Team selectedTeam = (Team)teamsComboBox.SelectedItem;

            if (selectedTeam == null)
            {
                return;
            }
            

            foreach (Footballer fb in selectedTeam.Footballers)
            {
                footballersListBox.Items.Add(fb);
            }

            footballersListBox.SelectedIndex = 0;

            Footballer selectedFootballer = (Footballer)footballersListBox.SelectedItem;

            teaminfoTextBlock.Text = selectedTeam.TeamInformation();
           

            LoadPlayerInfo(selectedFootballer);  
        }

        private void LoadPlayerInfo(Footballer selectedFootballer)
        {
            if (selectedFootballer == null)
            {
                return;
            }

            playerinfoTextBox.Text = selectedFootballer.GetInformation();            
        }

        private void OnFootballersListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedTeam = (Team)teamsComboBox.SelectedItem;

            Footballer selectedFootballer = (Footballer)footballersListBox.SelectedItem;

            LoadPlayerInfo(selectedFootballer);
        }

        private void OnAddPlayerButtonClicked(object sender, RoutedEventArgs e)
        {
            Team selectedTeam = (Team)teamsComboBox.SelectedItem;
            string firstName = "";
            string lastName = "";
            string position = "";
            int jerseyNumber = 0;
            int numberOfGoals = 0;

            if (!string.IsNullOrWhiteSpace(firstNameTextbox.Text))
            {
                firstName = firstNameTextbox.Text;
            }
            else
            {
                MessageBox.Show("Vul een voornaam in!");
            }
            if (!string.IsNullOrWhiteSpace(lastNameTextbox.Text))
            {
                lastName = lastNameTextbox.Text;
            }
            else
            {
                MessageBox.Show("Vul een achternaam in!");
            }
            if (!string.IsNullOrWhiteSpace(positionTextbox.Text))
            {
                position = positionTextbox.Text;
            }
            else
            {
                MessageBox.Show("Vul een positie in!");
            }
            if (!int.TryParse(jerseyNumberTextbox.Text, out jerseyNumber))
            {
                MessageBox.Show("Vul een geheel getal in.");
            }
            if (!int.TryParse(numberOfGoalsTextbox.Text, out numberOfGoals))
            {
                MessageBox.Show("Vul een geheel getal in.");
            }            
            
           
            bool isCaptain = isCaptainCheckBox.IsChecked == true;

            try
            {

                Footballer newFootballer = new Footballer(firstName, lastName, jerseyNumber, position, numberOfGoals);

                selectedTeam.AddPlayer(newFootballer, isCaptain);

                footballersListBox.Items.Add(newFootballer);

                teaminfoTextBlock.Text = selectedTeam.TeamInformation();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void OnRemovePlayerButtonClicked(object sender, RoutedEventArgs e)
        {
            Footballer playerToRemove = (Footballer)footballersListBox.SelectedItem;                      

            Team selectedTeam = (Team)teamsComboBox.SelectedItem;

            selectedTeam.RemoveFootballer(playerToRemove);

            footballersListBox.Items.Remove(playerToRemove);

            teaminfoTextBlock.Text = selectedTeam.TeamInformation();
        }
    }
}