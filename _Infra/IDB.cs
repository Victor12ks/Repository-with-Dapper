using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McardsBanco._Infra
{
    public interface IDB
    {
        IDbConnection getConnection();
    }
}
//O IDbConnection interface permite que uma classe herdada implementar uma classe de conexão,
//que representa uma sessão exclusiva com uma fonte de dados(por exemplo, uma conexão de rede para um servidor).
