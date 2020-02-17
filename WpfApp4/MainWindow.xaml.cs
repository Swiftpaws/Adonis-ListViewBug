using System.Collections.ObjectModel;
using System.Linq;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public ObservableCollection<TestItem> Items = new ObservableCollection<TestItem>();

        public MainWindow()
        {
            InitializeComponent();

            lvTest.ItemsSource = Items;
            lvTest1.ItemsSource = Items;
            lvTest2.ItemsSource = Items;

            foreach (var v in Enumerable.Range(1, 50))
            {
                Items.Add(new TestItem("Test " + v));
            }
        }
    }
}