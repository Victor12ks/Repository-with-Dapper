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
    public class EquipamentoRepositorio : IRepositorio<Equipamento>
    {
        IDB _db;
        public EquipamentoRepositorio(IDB db)
        {
            _db = db;
        }

        public void Alterar(Equipamento item)
        {
            string SQL = "UPDATE Equipamento SET Tipo = @Tipo, Modelo = @Modelo, Id_Marca = @Id_Marca WHERE Id_Equipamento = @Id_Equipamento";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, item);
            }
        }

        public Equipamento buscarPorID(int Id_Equipamento)
        {
            using (var db = _db.getConnection())
            {
                return db.QueryFirstOrDefault<Equipamento>("Select * From Equipamento Where Id_Equipamento = @Id_Equipamento", new { Id_Equipamento });
            }
        }

        public void Deletar(Equipamento item)
        {
            string SQL = "Delete FROM Equipamento" +
                " WHERE Id_Equipamento = @Id";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, new { id = item.Id_Equipamento });
            }
        }

        public void Inserir(Equipamento item)
        {
            string SQL = "INSERT INTO Equipamento (Tipo,Modelo,Id_Marca) VALUES (@Tipo,@Modelo,@Id_Marca)";
            using (var db = _db.getConnection())
            {
                db.Execute(SQL, item);
            }
        }

        public IEnumerable<Equipamento> Listar()
        {
            using (var db = _db.getConnection())
            {
                return db.Query<Equipamento>("SELECT * FROM Equipamento");
            }
        }
    }
}