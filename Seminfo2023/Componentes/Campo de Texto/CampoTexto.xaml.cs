using Mvvm.Base.ViewModelBase;
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
    /// Interação lógica para CampoTexto.xam
    /// </summary>
    public partial class CampoTexto : UserControl
    {
        public CampoTexto()
        {
            InitializeComponent();
        }
        public void CampoInformacao(string placeholder = "Teste Console",  string texto = "", bool somenteLeitura = false)
        {
            //ucTxb.Tag = placeholder;
            //ucTxb.Text = texto;
            //ucTxb.TextWrapping = TextWrapping.NoWrap;
            //ucTxb.IsReadOnly = somenteLeitura;
        }
        public void CampoDescricao(string placeholder = "Teste Console", string texto = "", bool somenteLeitura = false)
        {
            //ucTxb.Tag = placeholder;
            //ucTxb.Text = texto;
            //ucTxb.TextWrapping = TextWrapping.Wrap;
            //ucTxb.IsReadOnly = somenteLeitura;
        }
    }
}
