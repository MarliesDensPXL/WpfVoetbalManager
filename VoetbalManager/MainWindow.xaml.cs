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
            Team team = new Team("Kayserispor");
            team.AddPlayer(new Footballer("Murat", "Akin", "midfielder", 2, 3), false);
            team.AddPlayer(new Footballer("Igor", "Akinfejev", "goalkeeper", 4, 0), false);
            team.AddPlayer(new Footballer("Kerem", "Aktürkoglu", "attacker", 5, 10), true);
            team.AddPlayer(new Footballer("Chuba", "Akpom", "defender", 3,  1), false);

            teamsComboBox.Items.Add(team);
            teamsComboBox.SelectedIndex = 0;
        }

        private void OnAddTeamButtonClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teamNameTextBox.Text))
                {
                return;
            }
            
            Team team = new Team(teamNameTextBox.Text);

            teamsComboBox.Items.Add(team);
            teamsComboBox.SelectedIndex = (teamsComboBox.Items.Count) -1 ;
            teamNameTextBox.Clear();
        }

        private void OnTeamSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedTeam = (Team)teamsComboBox.SelectedItem;

            if (selectedTeam == null)
            {
                return;
            }
            foreach (Footballer fb in selectedTeam.Footballers)
            {
                footballersListBox.Items.Add(fb);
            }

            footballersListBox.SelectedItem = 0;
        }
    }
}