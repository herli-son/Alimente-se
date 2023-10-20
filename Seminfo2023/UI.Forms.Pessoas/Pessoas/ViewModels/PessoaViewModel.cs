using Mvvm.Base.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI.Forms.Pessoas.Pessoas.Models;

namespace UI.Forms.Pessoas.Pessoas.ViewModels
{
    public class PessoaViewModel : ListaViewModel<PessoaModel>
    {
        public ICommand Buscar {  get; set; }
        public PessoaViewModel()
        {
            Buscar = RegistrarCommand(ObterPropriedades, PodeObterPropriedade);
        }
        public void ObterPropriedades(object obj)
        {
            var lista = new PessoaModel().ObterDados();
            Itens = new ObservableCollection<PessoaModel>(lista);
            NotifyPropertyChanged("Itens");
        }
        public bool PodeObterPropriedade(object obj)
        {
            return true;
        }
    }
}
