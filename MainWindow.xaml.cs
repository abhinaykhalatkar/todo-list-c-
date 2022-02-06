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

namespace test
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

        private void addToListBox(string item)

        { 
            taskLBx.Items.Add(item); 
            taskTBx.Text = "";
            addBtn.IsEnabled = false;
        }

        private void taskTBx_KeyDown(object sender, KeyEventArgs e)
        {
            addBtn.IsEnabled = true;
            if (e.Key == Key.Enter)
            {
                addToListBox(taskTBx.Text);
                
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        { if(taskTBx.Text !="")
            addToListBox(taskTBx.Text);

        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!taskLBx.Items.IsEmpty)
            {
                taskLBx.Items.Remove(taskLBx.SelectedItem);

                deleteBtn.IsEnabled = false;
            }
            
        }
        private void taskLBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteBtn.IsEnabled = true;

        }
    }
}
