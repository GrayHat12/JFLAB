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
using System.Windows.Shapes;

namespace JFLAB
{
    public partial class FiniteAutomaton : Window
    {
        private MainWindow parent;
        public FiniteAutomaton(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.parent.Visibility = Visibility.Visible;
        }

    }
}
