using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoP2PrecoCombustivel
{
    public partial class Default : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            dadosPlanilha();
        }

        protected void GVViagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void dadosPlanilha()
        {
            var xls = new XLWorkbook(@"C:\Users\gabri\Desktop\Nova pasta\Nova pasta\ProjP2\DadosCombustivel.xlsx");
            var planilha = xls.Worksheets.First(w => w.Name == "LER");
            var totalLinhas = planilha.Rows().Count();
            // primeira linha é o cabecalho
            for (int l = 2; l <= totalLinhas; l++)
            {
                var estado = planilha.Cell($"A{l}").Value.ToString();
                var valorEtanol = planilha.Cell($"B{l}").Value.ToString();
                var valorGasolina = planilha.Cell($"C{l}").Value.ToString();
                LblMsg.Text = estado;
                inserirDados(estado, valorEtanol, valorGasolina);
            }
           
        }

        protected void inserirDados(string estado, string valorE, string valorG)
        {
            TB_ESTADO_COMBUSTIVEL valorCombustivelEstado = new TB_ESTADO_COMBUSTIVEL()
            {
                nomeEstado = estado,
                valorEtanol = decimal.Parse(valorE),
                valorGasolina = decimal.Parse(valorG)
            };

            db_valor_combustivelEntities3 contextCombustivel = new db_valor_combustivelEntities3();
            contextCombustivel.TB_ESTADO_COMBUSTIVEL.Add(valorCombustivelEstado);
            contextCombustivel.SaveChanges();
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}