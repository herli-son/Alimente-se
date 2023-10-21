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
    /// Interação lógica para BotaoNavegacao.xam
    /// </summary>
    public partial class BotaoNavegacao : UserControl
    {
        public ICommand command { get { return Botao.Command; } set { Botao.Command = value; }} 
        public bool? Checado { get { return Botao.IsChecked; } set { Botao.IsChecked = value; } }
        public BotaoNavegacao()
        {
            InitializeComponent();
        }
    }
}
