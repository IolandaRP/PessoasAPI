using MongoDB.Driver;
using PessoasAPI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasAPI.Servicos
{
    public class PessoasService
    {
        private readonly IMongoCollection<Pessoa> _pessoas;

        public PessoasService(IApiProjetoDatabase configuracoes)
        {
            var client = new MongoClient(configuracoes.ConexaoString);
            var database = client.GetDatabase(configuracoes.NomeBanco);

            _pessoas = database.GetCollection<Pessoa>(configuracoes.ColecaoPessoas);
        }

        public List<Pessoa> Get() =>
            _pessoas.Find(pessoa => true).ToList();

        public Pessoa Get(string id) =>
            _pessoas.Find<Pessoa>(pessoa => pessoa.id == id).FirstOrDefault();

        public Pessoa Create(Pessoa pessoa)
        {
            _pessoas.InsertOne(pessoa);
            return pessoa;
        }

        public void Update(string id, Pessoa _pessoa) =>
            _pessoas.ReplaceOne(pessoa => pessoa.id == id, _pessoa);

        public void Remove(Pessoa _pessoa) =>
            _pessoas.DeleteOne(pessoa => pessoa.id == _pessoa.id);

        public void Remove(string id) =>
            _pessoas.DeleteOne(pessoa => pessoa.id == id);
    }




}

