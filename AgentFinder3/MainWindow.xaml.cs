using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgentFinder3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Agents agentsList;

        public MainWindow()
        {
            InitializeComponent();
            //agentsList = new Agents();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (AgentListBox.SelectedIndex > 0)
                AgentListBox.SelectedIndex--;
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            if (AgentListBox.SelectedIndex < AgentListBox.Items.Count)
                AgentListBox.SelectedIndex++;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //agentsList.AddAgent();
            Agents agents = (Agents) this.DataContext;
            agents.Add(new Agent());
            AgentListBox.SelectedIndex = AgentListBox.Items.Count - 1;
            IdBox.Focus();
        }
    }
}
