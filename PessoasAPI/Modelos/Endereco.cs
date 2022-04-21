using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Modelos
{
    public class Endereco
    {

        [BsonElement("rua")]
        public string rua { get; set; }

        [BsonElement("numero")]
        public string numero { get; set; }

        [BsonElement("cidade")]
        public string cidade { get; set; }

        [BsonElement("estado")]
        public string estado { get; set; }

    }
}
