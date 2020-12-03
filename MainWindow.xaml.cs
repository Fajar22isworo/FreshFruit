using FreshFruit;
using FreshFruit.Contrroller;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller joni;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            joni = new Seller("joni", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public object ListBoxBucket { get; private set; }

        public void onFailed(string massage)
        {
            MessageBox.Show(massage, "Warning");
        }

        public void onSucceed(string massage)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void On(object sender, RoutedEventArgs e)
        {

        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit Anggur = new Fruit("Anggur");
            joni.addFruit(Anggur);

        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit Apel = new Fruit("Apel");
            joni.addFruit(Apel);
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            joni.addFruit(Pisang);
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit Jeruk = new Fruit("Jeruk");
            joni.addFruit(Jeruk);
        }
       
    }
}
