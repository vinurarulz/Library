using System;
using System.Collections.Generic;
using System.Linq;
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
using DAO;

namespace LibraryMgtSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Save();
            SearchAll();
        }

        private void Save()
        {
            try
            {
                var emp = new EmployeeData();
                bool result = emp.SaveEmployee(txtFName.Text, txtLName.Text, txtTel.Text);
                if (result)
                {
                    MessageBox.Show("Save Successfull");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SearchAll();
        }

        private void SearchAll()
        {
            var emp = new EmployeeData();
            dataGrid.ItemsSource = emp.Search();
        }
    }
}
