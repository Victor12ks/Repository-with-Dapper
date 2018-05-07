using Dapper;
using McardsBanco._Infra;
using McardsBanco._Repositorio.Core;
using McardsBanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McardsBanco._Repositorio
{
    public class MarcaRepositorio : IRepositorio<Marca>
    {
        IDB _db;
        public MarcaRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(Marca item)
        {
            string SQL = "UPDATE Marca SET Descricao = @Descricao WHERE Id_Marca = @Id_Marca";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, item);
            }
        }

        public Marca buscarPorID(int Id)
        {
            using (var db = _db.getConnection())
            {
                return db.QueryFirstOrDefault<Marca>("Select * From Marca Where Id_Marca=@Id_Marca", new { Id });
            }
        }

        public void Deletar(Marca item)
        {
            string SQL = "Delete FROM Marca WHERE Id_Marca = @Id_Marca";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, new { id = item.Id_Marca });
            }
        }

        public void Inserir(Marca item)
        {
            string SQL = "INSERT INTO Marca (Descricao) VALUES (@Descricao)";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, item);
            }
        }

        public IEnumerable<Marca> Listar()
        {
            using (var db = _db.getConnection())
            {
                return db.Query<Marca>("SELECT * FROM Marca");
            }
        }
    }
}