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

namespace Componentes
{
    /// <summary>
    /// Interação lógica para BotaoFechar.xam
    /// </summary>
    public partial class BotaoFechar : UserControl
    {
        public BotaoFechar()
        {
            InitializeComponent();
        }
        public ICommand command { get => Fechar.Command; set => Fechar.Command = value; }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            command?.Execute(null);
        }

        private void CloseApp_MouseEnter(object sender, MouseEventArgs e)
        {
            Icone.Cor = Brushes.Red;
            Fechar.Background = Brushes.Transparent;
        }

        private void CloseApp_MouseLeave(object sender, MouseEventArgs e)
        {
            Icone.Cor = Brushes.Black;
            Fechar.Background = Brushes.Transparent;
        }
    }
}
