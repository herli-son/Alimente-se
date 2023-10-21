using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Componentes
{
    /// <summary>
    /// Interação lógica para Navegacao.xam
    /// </summary>
    public partial class Navegacao : UserControl
    {
        public Navegacao()
        {
            InitializeComponent();
        }

        public virtual void adicionarBotao(string Titulo,ICommand comando, FontAwesome.WPF.FontAwesomeIcon iconeVinculado)
        {
            BotaoNavegacao botao = new BotaoNavegacao();
            botao.Checado = Nav.Children.Count == 1;
            botao.Texto.Text = Titulo;
            botao.command = comando;
            botao.Icone.IconeVinculado = iconeVinculado;
            Nav.Children.Add(botao);
        }
    }
}
