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
using UI.Forms.Pessoas.Pessoas.Views;
using Mvvm.Base.Eventos;
using System.CodeDom.Compiler;

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
            Nav.adicionarBotao("PERFIL", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.UserCircle);
            Nav.adicionarBotao("FAVORITOS", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.Star);
            Nav.adicionarBotao("LOJAS", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.ShoppingBasket);
            Nav.adicionarBotao("ITENS", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.List);
            Nav.adicionarBotao("AGENDA", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.Calendar);
            Nav.adicionarBotao("AJUDA", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.QuestionCircle);
            Nav.adicionarBotao("LOGOUT", new Command(Execute, CanExecute), FontAwesome.WPF.FontAwesomeIcon.ArrowCircleLeft);
            Pages.comandoFechar(new Command(Close, CanClose));
        }
        void Close(object obj)
        {
            Close();
        }
        bool CanClose(object obj)
        {
            return true;
        }
        void Execute(object obj)
        {
        }
        bool CanExecute(object obj)
        {
            return true;
        }
    }
}
