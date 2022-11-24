using FirebirdSql.Data.FirebirdClient;
using System.Collections.ObjectModel;
using System.Data;

namespace TesteBancoFirebird
{
  public partial class Form1 : Form
  {
    FbRemoteEvent events;
    
    public Form1()
    {
      InitializeComponent();
      MontaGrid();
      FirebirdEvents();
    }
    private void MontaGrid()
    {
      using (var conn = Conexao.getInstancia().getConexaoFb())
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

    private void FirebirdEvents()
    {

      //var nomeEvento = new Collection<string>();
      //nomeEvento.Add("NOVO_ATENDIMENTO");
      events = events ?? new FbRemoteEvent(Conexao.StringConexao);

      events.RemoteEventCounts += (sender, e) => AvisoEvento(sender, e); ;
      events.RemoteEventError += (sender, e) => MessageBox.Show($"ERROR: {e.Error}");
     // events.QueueEvents(new string[] { "NOVO_ATENDIMENTO" });
    }

    private void AvisoEvento(object sender, FbRemoteEventCountsEventArgs e)
    {
      Invoke(new Action(() =>
      {
        if (e.Name == "NOVO_ATENDIMENTO")
          lblMensagem.Text = e.ToString();

      }));
      
    }


  }
}