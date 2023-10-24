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
            Visoes = new Dictionary<string, object>();
        }
        public string BotaoSelecionado { get => Nav.Children.OfType<BotaoNavegacao>().FirstOrDefault(x => x.Checado).Texto.Text; }
        public Dictionary<string, object> Visoes { get; set; }
        public void adicionarBotao(string titulo, string grupo, object tela, ICommand comando, FontAwesome.WPF.FontAwesomeIcon iconeVinculado)
        {
            BotaoNavegacao botao = new BotaoNavegacao();
            botao.Checado = Nav.Children.Count == 1;
            botao.Texto.Text = titulo;
            botao.Command = comando;
            botao.Grupo = grupo;
            botao.Icone.IconeVinculado = iconeVinculado;
            Nav.Children.Add(botao);
            if (!Visoes.ContainsKey(titulo))
                Visoes.Add(titulo, tela);
        }
        public object ObterVisaoAtiva()
        {
            if (!Visoes.ContainsKey(BotaoSelecionado)) return null;
            return Visoes[BotaoSelecionado];
        }
    }
}
