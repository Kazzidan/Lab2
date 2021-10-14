using System.Windows;
using Lab1.ViewModel;
namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmailPerson.xaml
    /// </summary>
    public partial class WindowEmailPerson : Window
    {
        public WindowEmailPerson()
        {
            InitializeComponent();
            EmailPersonVievModel vmEmailPerson = new EmailPersonVievModel();
            lvEmailPerson.ItemsSource = vmEmailPerson.ListEmailPerson;
        }
    }
}
