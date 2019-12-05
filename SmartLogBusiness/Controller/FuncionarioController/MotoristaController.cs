using SmartLogBusiness.Controller.Interface;
using SmartLogBusiness.DAL.FuncionarioDAL;
using SmartLogBusiness.Model.Entidade;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller
{
	public class MotoristaController : IControllerBase<Motorista>
	{
		MotoristaDAO dao = new MotoristaDAO();
		public void AlterarController(Motorista obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o código para alterar registro.");
				}
				dao.AlterarMotoristaDAO(obj.Codigo, obj.Nome, obj.DataNasc, obj.CnhCat, obj.CnhNumero.ToString(), obj.CnhVencimento, obj.Telefone, obj.Email, Convert.ToInt32(obj.Status),
										obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero, obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeletarController(Motorista obj)
		{
			try
			{
				if (obj.Codigo == 0)
				{
					throw new Exception("Necessário informar o código para excluir registro.");
				}
				dao.DeletarMotoristaDAO(obj.Codigo);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable ComboMotorista()
		{
			try
			{
				return dao.CarregarComboMotoristaDAO();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public DataTable GetDataTable(Motorista obj)
		{
			try
			{
				return dao.FiltrarMotoristaDAO(obj.Nome, obj.CnhVencimento, obj.CnhVencFinal);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public Motorista GetObj(Motorista obj)
		{
			try
			{
				DataTable table = dao.CarregarMotoristaDAO(obj.Codigo);
				if (table != null)
				{
					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Numero"]),
												table.Rows[0]["Bairro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Cod_Cidade"]),
												Convert.ToInt32(table.Rows[0]["Cod_Estado"]));

					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]),
												   table.Rows[0]["Nome_Motorista"].ToString(),
												   Convert.ToDateTime(table.Rows[0]["Data_Nascimento"]),
												   table.Rows[0]["Telefone_Motorista"].ToString(),
												   table.Rows[0]["Email_Motorista"].ToString(),
												   (EnumStatusMotorista)(table.Rows[0]["Status_Motorista"]), end,
												   (EnumCnhCategoriaMotorista)table.Rows[0]["CNH_Categoria"],
												   table.Rows[0]["CNH_Numero"].ToString(),
												   Convert.ToDateTime(table.Rows[0]["CNH_Vencimento"]));

					return moto;
				}
				else
				{
					throw new Exception("Motorista não localizado.");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void InserirController(Motorista obj)
		{
			try
			{
				dao.InserirMotoristaDAO(obj.Nome, obj.DataNasc, obj.CnhCat, obj.CnhNumero.ToString(), obj.CnhVencimento, obj.Telefone, obj.Email, Convert.ToInt32(obj.Status), obj.Endereco.Cep, obj.Endereco.Logradouro, obj.Endereco.Numero,
										obj.Endereco.Bairro, obj.Endereco.CodCidade, obj.Endereco.CodEstado);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public List<Motorista> ListasController(Motorista obj)
		{
			try
			{
				DataTable table = dao.FiltrarMotoristaDAO(obj.Nome, obj.CnhVencimento, obj.CnhVencFinal);
				List<Motorista> lista = new List<Motorista>();

				if (table == null)
				{
					throw new Exception("Funcionário não localizado.");
				}

				foreach (DataRow item in table.Rows)
				{
					Endereco end = new Endereco(table.Rows[0]["Cep"].ToString(),
												table.Rows[0]["Logradouro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Numero"]),
												table.Rows[0]["Bairro"].ToString(),
												Convert.ToInt32(table.Rows[0]["Cod_Cidade"]),
												Convert.ToInt32(table.Rows[0]["Cod_Estado"]));

					Motorista moto = new Motorista(Convert.ToInt32(table.Rows[0]["Cod_Motorista"]),
												   table.Rows[0]["Nome_Motorista"].ToString(),
												   Convert.ToDateTime(table.Rows[0]["Data_Nascimento"]),
												   table.Rows[0]["Telefone_Motorista"].ToString(),
												   table.Rows[0]["Email_Motorista"].ToString(),
												   (EnumStatusMotorista)(table.Rows[0]["Status_Motorista"]), end,
												   (EnumCnhCategoriaMotorista)table.Rows[0]["CNH_Categoria"],
												   table.Rows[0]["CNH_Numero"].ToString(),
												   Convert.ToDateTime(table.Rows[0]["CNH_Vencimento"]));

					lista.Add(moto);
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
