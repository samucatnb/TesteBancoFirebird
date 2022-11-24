using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBancoFirebird
{
  public class Conexao
  {
    private static readonly Conexao _conexao = new Conexao();

    private Conexao()
    {

    }


    private string StringConexao
    {
      //get => @"DataSource=localhost; Database=C:\Program Files (x86)\Firebird\Firebird_2_5\examples\empbuild\EMPLOYEE.FDB; username= SYSDBA; password = masterkey";
      get => @"Database=localhost/3050:C:\FB_BANCOS\BANCO_MQFS.fdb; username= SYSDBA; password = masterkey";
    }

    public static Conexao getInstancia()
    {
      return _conexao;
    }

    public FbConnection getConexaoFb()
    {
      return new FbConnection(StringConexao);
    }

  }
}
