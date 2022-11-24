using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace TesteBancoFirebird
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      MontaGrid();
    }
    private void MontaGrid()
    {
      using(var conn = Conexao.getInstancia().getConexaoFb())
      {
        using (var fbCmd = new FbCommand("select * from atendimento", conn))
        {
          conn.Open();
          FbDataAdapter fbDa = new FbDataAdapter(fbCmd);
          DataTable dtAtendimento = new DataTable();
          fbDa.Fill(dtAtendimento);
          dataGridView1.DataSource = dtAtendimento;

        }
      }
    }

  }
}