using Componentes.Sevices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Componentes.MVVM
{
    public class TesteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public TesteViewModel()
        {
            Executar = new ReleyCommand(ObterPropriedades, PodeObterPropriedade);
        }
        public ObservableCollection <TesteModel> Itens { get; set; }
        public ICommand Executar { get; set; }

        public void ObterPropriedades(object obj)
        {
            var lista = new TesteModel().ObterDados();
            Itens = new ObservableCollection<TesteModel>(lista);
            NotifyPropertyChanged("Itens");
        }
        public bool PodeObterPropriedade(object obj)
        {
            return false;
        }
    }
}
