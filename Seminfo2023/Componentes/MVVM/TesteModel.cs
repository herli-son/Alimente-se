using System;
using System.Collections.Generic;

namespace Componentes.MVVM
{
    public class TesteModel
    {
        public string Propriedade1 {  get; set; }
        public bool Propriedade2 { get; set; }
        public int Propriedade3 { get; set; }
        public DateTime Propriedade4 { get; set; }
        public TesteModel()
        {
            
        }

        public TesteModel(string propriedade1, bool proopriedade2, int propriedade3, DateTime propriedade4)
        {
            Propriedade1 = propriedade1;
            Propriedade2 = proopriedade2;
            Propriedade3 = propriedade3;
            Propriedade4 = propriedade4;
        }

        public List<TesteModel> ObterDados()
        {
            List<TesteModel> testeModels = new List<TesteModel>() { 
                new TesteModel("Propriedade1",false,1,DateTime.Now),
                new TesteModel("Propriedade2",true, 2,DateTime.Now),
                new TesteModel("Propriedade3",false,3,DateTime.Now),
                new TesteModel("Propriedade4",true, 4,DateTime.Now)
            };
            return testeModels;
        }
    }
}
