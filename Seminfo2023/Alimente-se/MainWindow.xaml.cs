using System.Windows;
using Mvvm.Base.Eventos;

namespace Alimente_se
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Nav.adicionarBotao("PERFIL", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.UserCircle);
            Nav.adicionarBotao("FAVORITOS", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.Star);
            Nav.adicionarBotao("LOJAS", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.ShoppingBasket);
            Nav.adicionarBotao("ITENS", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.List);
            Nav.adicionarBotao("AGENDA", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.Calendar);
            Nav.adicionarBotao("AJUDA", "Navegação", null, new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.QuestionCircle);
            Nav.adicionarBotao("TESTES", "Navegação", new Componentes.Testes(), new Command(Execute), FontAwesome.WPF.FontAwesomeIcon.Support);
            Fechar.command = new Command((o) => { Close(); });
        }
        void Execute(object obj)
        {
            Pages.Content = Nav.ObterVisaoAtiva();
        }
    }
}
