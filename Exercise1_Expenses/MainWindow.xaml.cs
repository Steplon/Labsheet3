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

namespace Exercise1_Expenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Expenses> expenses = new ObservableCollection<Expenses>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            expenses.Add(new Expenses("Travel", 100m, DateTime.Parse("04/09/2018")));
            expenses.Add(new Expenses("Fuel", 19.32m, DateTime.Parse("09/12/2018")));
            expenses.Add(new Expenses("Stationary", 10.04m, DateTime.Parse("24/12/2018")));

            DisplayExpenses();
        }

        private void BtnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            expenses.Add(new Expenses("Food", 294.44m, DateTime.Parse("09/09/2018")));
            DisplayExpenses();
        }

        private void BtnRemoveExpense_Click(object sender, RoutedEventArgs e)
        {
            expenses.RemoveAt(expenses.Count-1);
            DisplayExpenses();
        }


        private decimal GetTotalExpenses()
        {
            decimal total = 0;

            foreach (Expenses e in expenses)
            {
                total += e.Cost;
            }

            return total;
        }

        private void DisplayExpenses()
        {
            txblTotalExpenses.Text = $"Total Expenses: {Convert.ToDecimal(GetTotalExpenses()):C}";
            lbxExpenses.ItemsSource = expenses;

        }
    }
}
