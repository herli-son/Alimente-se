using Injecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UI.Forms.Pessoas
{
    public class PessoasFactory : IFactoryMultiImplementacao
    {
        private static Type[] factoryTypes;
        private void CarregarTiposAssemblyCorrente()
        {
            if (factoryTypes != null) return;

            factoryTypes = (from assembly in new Assembly[] { Assembly.GetExecutingAssembly() }
                            where !assembly.IsDynamic
                            from type in assembly.GetTypes()
                            where !type.IsAbstract
                            where !type.IsGenericTypeDefinition
                            select type).ToArray();
        }
        public string AssemblyName => Assembly.GetExecutingAssembly().FullName;

        public T CriarInstanciaObjeto<T>(Type tipo, params object[] parametros) where T : class
        {
            if(tipo == null) return null;

            if(parametros == null) return Activator.CreateInstance(tipo) as T;
            else return Activator.CreateInstance(tipo, parametros) as T;
        }
        public Type[] ObterTipoImplementacao<T>(string classeEspecifica = "") where T : class
        {
            CarregarTiposAssemblyCorrente();

            var tipos = factoryTypes.Where(x=> typeof(T).IsAssignableFrom(x)).ToArray();

            if(tipos != null && tipos.Length > 0 && !string.IsNullOrEmpty(classeEspecifica))
                tipos = tipos.Where(x=> x.FullName.ToLower().EndsWith(classeEspecifica.ToLower())).ToArray();

            return tipos;
        }
        public bool InterfaceImplementada<T>()
        {
            CarregarTiposAssemblyCorrente();
            return factoryTypes.ToList().Exists(x => typeof(T).IsAssignableFrom(x));
        }
    }
}
