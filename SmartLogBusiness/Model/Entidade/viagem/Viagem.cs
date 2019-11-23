﻿using System;
using SmartLogBusiness.Model.Entidade.pessoa;
using SmartLogBusiness.Model.Entidade.veiculo;

namespace SmartLogBusiness.Model.Entidade.viagem
{
	public class Viagem
	{
		public int CodViagem{get; private set;}
		public DateTime DataViagem { get; private set; }
		public DateTime DataViagemFinal { get; private set; }
		public string DistanciaKm { get; private set; }
		public decimal Valor { get; private set; }
		public Endereco Origem { get; private set; }
		public Endereco Destino { get; private set; }
		public string ComplementoOrigem { get; private set; }
		public string ComplementoDestino {get; private set;}
        public Motorista Motorista { get; private set; }
        public Cliente Cliente { get; private set; }
		public Funcionario Atendente { get; private set; }
        public StatusViagem Status { get; private set; }
		public Veiculo CodVeiculo { get; private set; }
        public Viagem(int codigo,DateTime dataVi, string distancia, decimal valor,Endereco origem, string compleOrig, Endereco destino, string compleDest, Cliente cliente, Veiculo codVei, Motorista motorista,  Funcionario atendente)
		{
			CodViagem = codigo;
			DataViagem = dataVi;
			DistanciaKm = distancia;
			Valor = valor;
            Origem = origem;
			ComplementoOrigem = compleOrig;
            Destino = destino;
			ComplementoDestino = compleDest;
			CodVeiculo = codVei;
            Motorista = motorista;
            Cliente = cliente;
			Atendente = atendente;
            Status = 0;
        }
		//Construtor para filtrar
		public Viagem(int codigo, DateTime dataVi, DateTime dataViFinal, string distancia, decimal valor, Endereco origem, string compleOrig, Endereco destino, string compleDest, Cliente cliente, Veiculo codVei, Motorista motorista, Funcionario atendente)
		{
			CodViagem = codigo;
			DataViagem = dataVi;
			DataViagemFinal = dataViFinal;
			DistanciaKm = distancia;
			Valor = valor;
			Origem = origem;
			ComplementoOrigem = compleOrig;
			Destino = destino;
			ComplementoDestino = compleDest;
			CodVeiculo = codVei;
			Motorista = motorista;
			Cliente = cliente;
			Atendente = atendente;
			Status = 0;
		}

	}
}
