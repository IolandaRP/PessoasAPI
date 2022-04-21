using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Modelos
{
    public class Contato
    {
        [BsonElement("celular")]
        public string celular { get; set; }

        [BsonElement("email")]
        public string email { get; set; }


    }
}
