using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartLogBusiness.Controller.Interface
{
	public interface IControllerBase<T> 
	{
		void InserirController(T obj);
		void AlterarController(T obj);
		void DeletarController(T obj);
		List<T> ListasController(T obj);
		T GetObj(T obj);
	}
}
