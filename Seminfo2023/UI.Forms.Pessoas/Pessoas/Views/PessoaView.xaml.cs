using System.Windows.Controls;
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
