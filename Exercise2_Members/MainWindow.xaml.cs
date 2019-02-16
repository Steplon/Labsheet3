using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Exercise2_Members
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Member> members = new ObservableCollection<Member>();

        ObservableCollection<string> memberTypes = new ObservableCollection<string>(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            memberTypes.Add("Full");
            memberTypes.Add("Off Peak");
            memberTypes.Add("OAP");
            memberTypes.Add("Student");


            members.Add(new Member("Sally Witmore", "Full", "01/03/2016"));
            members.Add(new Member("Tom Hardy", "OAP", "01/03/2016"));
            members.Add(new Member("Mel D", "Student", "01/03/2016"));

            DisplayUpdate();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = tbxName.Text;
            string type = cbxMemberType.Text;
            string date = dpDateJoined.Text;
            members.Add(new Member(name,type,date));

            DisplayUpdate();
        }

        private void DisplayUpdate()
        {
            lbxMembers.ItemsSource = members;
            cbxMemberType.ItemsSource = memberTypes;

            int numMmbers = 0;
            foreach (Member m in members)
            {
                numMmbers++;
            }
            txblTotalMembers.Text = $"Total Member: {numMmbers}";
        }
    }
}
