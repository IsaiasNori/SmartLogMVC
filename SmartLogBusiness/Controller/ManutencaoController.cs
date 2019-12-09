using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL;
using SmartLogBusiness.Model.Entidade.veiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class ManutencaoController : IControllerBase<Manutencao>
	{
		ManutencaoDAO dao = new ManutencaoDAO();
		public void AlterarController(Manutencao obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código da manutenção.");
				}
				dao.AlterarManutencaoDAO(obj.Codigo, obj.DataEntrada, obj.DataPrevistaSaida, obj.DescricaoServico, Convert.ToInt32(obj.CodVeiculo),obj.StatusManutencao);

                if(obj.StatusManutencao == Model.Enums.EnumStatusManutencao.Finalizado)
                {
                    VeiculoController veicCtrl = new VeiculoController();
                    Veiculo ve = veicCtrl.GetObj(new Veiculo(obj.CodVeiculo));
                    ve.DataUltimaRevisão = System.DateTime.Now;
                    ve.Status = enumStatusVeiculo.Disponivel;

                    veicCtrl.AlterarController(ve);
                }
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void DeletarController(Manutencao obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Informar o código da manutenção para efetuar a exclusão do registro.");
				}
				dao.DeletarManutencaoDAO(obj.Codigo);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public DataTable GetDataTable(Manutencao obj)
		{
			try
			{
				return dao.GridManutencaoDAO(obj.DataEntrada,obj.DataPrevistaSaida,obj.DescricaoServico,obj.DataentradaFinal,obj.DataPrevSaidaFinal);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public Manutencao GetObj(Manutencao obj)
		{
			try
			{
				DataTable table = dao.CarregarManutencaoDAO(obj.Codigo);

                if(table == null && table.Rows.Count == 0)
                {
                    return null;
                }

				Manutencao manu = new Manutencao(Convert.ToInt32(table.Rows[0]["Cod_Manutencao"]), Convert.ToDateTime(table.Rows[0]["Data_Entrada"]),
												Convert.ToDateTime(table.Rows[0]["Previsao_Saida"]),table.Rows[0]["Descricao_Servico"].ToString(),
												Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
                                                (Model.Enums.EnumStatusManutencao)table.Rows[0]["cod_Status_Manutencao"]);

				return manu;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Manutencao obj)
		{
			try
			{
				dao.InserirManutencaoDAO(obj.DataEntrada, obj.DataPrevistaSaida, obj.DescricaoServico, Convert.ToInt32(obj.CodVeiculo),obj.StatusManutencao);

               
                    VeiculoController veicCtrl = new VeiculoController();
                    Veiculo ve = veicCtrl.GetObj(new Veiculo(obj.CodVeiculo));
                  
                    ve.Status = enumStatusVeiculo.Manutencao;

                    veicCtrl.AlterarController(ve);
                


            }
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public List<Manutencao> ListasController(Manutencao obj)
		{
			try
			{
				DataTable table = dao.GridManutencaoDAO(obj.DataEntrada,obj.DataPrevistaSaida,obj.DescricaoServico,obj.DataentradaFinal,obj.DataPrevSaidaFinal);
				List<Manutencao> lista = new List<Manutencao>();
				if (table == null)
				{
					throw new Exception("Não foi possível localizar registro.");
				}
				foreach(DataRow item in table.Rows)
				{
					Manutencao manu = new Manutencao(Convert.ToInt32(table.Rows[0]["Cod_Manutencao"]), Convert.ToDateTime(table.Rows[0]["Data_Entrada"]), 
													Convert.ToDateTime(table.Rows[0]["Previsao_Saida"]), table.Rows[0]["Descricao_Servico"].ToString(),
													Convert.ToInt32(table.Rows[0]["Cod_Veiculo"]),
                                                     (Model.Enums.EnumStatusManutencao)table.Rows[0]["cod_Status_Manutencao"]);
                    lista.Add(manu);
				}
				return lista;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
