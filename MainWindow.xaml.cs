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

namespace JFLAB
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Batch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SetEmptyString_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UndoAmount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ColorPaletteChooser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FAutomaton_Click(object sender, RoutedEventArgs e)
        {
            FiniteAutomaton window = new FiniteAutomaton(this);
            this.Visibility = Visibility.Collapsed;
            window.ShowDialog();
        }

        private void MealyM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MooreM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PAutomaton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TMachine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MTTMachine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TMachineBB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grammar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LSystem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RExpression_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RPLemma_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CFPLemma_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
