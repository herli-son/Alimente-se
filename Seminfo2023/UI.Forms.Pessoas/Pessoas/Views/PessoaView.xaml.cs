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
using UI.Forms.Pessoas.Pessoas.ViewModels;

namespace UI.Forms.Pessoas.Pessoas.Views
{
    /// <summary>
    /// Interação lógica para PessoaView.xam
    /// </summary>
    public partial class PessoaView : Page
    {
        public PessoaView()
        {
            InitializeComponent();
            DataContext = new PessoaViewModel();
        }
    }
}
