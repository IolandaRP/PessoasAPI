using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Modelos
{
    public class Pessoa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("cpf")]
        public string cpf { get; set; }

        [BsonElement("nome")]
        public string nome { get; set; }

        [BsonElement("dataNascimento")]
        public string dataNascimento { get; set; }

        [BsonElement("sexo")]
        public string sexo { get; set; }


        [BsonElement("endereco")]
        public Endereco endereco { get; set; }


        [BsonElement("contato")]
        public Contato contato { get; set; }

    }
}
