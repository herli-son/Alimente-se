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
    /// Interação lógica para Icon.xam
    /// </summary>
    public partial class Icon : UserControl
    {
        public Icon()
        {
            InitializeComponent();
        }
        public virtual void construir(FontAwesome.WPF.FontAwesomeIcon icone, int tamanho)
        {
            IconeVinculado = icone;
            this.Width = tamanho;
            this.Height = tamanho;
        }
        public virtual FontAwesome.WPF.FontAwesomeIcon IconeVinculado
        {
            get
            {
                return Icone.Icon;
            }
            set
            {
                Icone.Icon = value;
            }
        }
    }
}
