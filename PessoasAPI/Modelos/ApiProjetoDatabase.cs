using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Modelos
{
    public class ApiProjetoDatabase : IApiProjetoDatabase
    {
        public string ConexaoString { get; set; }

        public string NomeBanco { get; set; }

        public string ColecaoPessoas { get; set; } = null!;
    }


    public interface IApiProjetoDatabase
    {
        string ConexaoString { get; set; }
        string NomeBanco { get; set; }
        string ColecaoPessoas { get; set; }
    }
}

