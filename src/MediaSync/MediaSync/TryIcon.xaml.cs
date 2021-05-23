using Microsoft.Extensions.Logging;
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

namespace MediaSync {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TryIcon : Window {
        ILogger<TryIcon> logs;
        public TryIcon(ILogger<TryIcon> logs) {
            this.logs = logs;
            logs.LogInformation("Working?");
            InitializeComponent();
        }
    }
}
