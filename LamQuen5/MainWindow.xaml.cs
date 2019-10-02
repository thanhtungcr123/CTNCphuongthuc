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

namespace LamQuen5
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

        private void BtnChia_Click(object sender, RoutedEventArgs e)
        {
            
            double a = double.Parse(gia_tri_1.Text);
            double b = double.Parse(gia_tri_2.Text);
            double chia = 0;
            if (b == 0)
            {
                MessageBox.Show("<_>");
            }
            else
            {
                chia = a / b;
                ket_qua.Text = gia_tri_1.Text + "/" + gia_tri_2.Text;
                ket_qua.Text = string.Format("{0:0.0}", chia);
            }
        }

        private void BtnNhan_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(gia_tri_1.Text);
            double b = double.Parse(gia_tri_2.Text);
            double nhan = 0;
            nhan = a * b;
            ket_qua.Text = gia_tri_1.Text + "*" + gia_tri_2;
            ket_qua.Text = nhan.ToString();
        }

        private void __1_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(gia_tri_1.Text);
            double b = double.Parse(gia_tri_2.Text);
            double hieu = 0;
            hieu = a - b;
            ket_qua.Text = gia_tri_1.Text + "-" + gia_tri_2.Text;
            ket_qua.Text = hieu.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(gia_tri_1.Text);
            double b = double.Parse(gia_tri_2.Text);
            double tong = 0;
            tong = a + b;
            ket_qua.Text = gia_tri_1.Text + "+" + gia_tri_2.Text;
            ket_qua.Text = tong.ToString();
        }

        private void Cancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
