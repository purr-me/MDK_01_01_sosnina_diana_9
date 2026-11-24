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
using WpfApp1.Classes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private WarriorLight lightWarrior = new WarriorLight(100);
        private WarriorHeavy heavyWarrior = new WarriorHeavy(100);

        public MainWindow()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            lHealthLight.Content = $"Здоровье: {lightWarrior.Health}";
            lHealthHeavy.Content = $"Здоровье: {heavyWarrior.Health}";
        }

        private void LightWarrior_Click(object sender, MouseButtonEventArgs e)
        {
            lightWarrior.TakeDamage(20);
            Update();
        }

        private void HeavyWarrior_Click(object sender, MouseButtonEventArgs e)
        {
            heavyWarrior.TakeDamage(20);
            Update();
        }
    }
}
