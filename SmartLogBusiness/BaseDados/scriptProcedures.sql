USE [SmartLog]
GO
/****** Object:  StoredProcedure [dbo].[pCidade]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pCidade]
@Operacao varchar(4),
@CodCidade int = NULL,
@NomeCidade varchar(100) = NULL,
@CodEstado int = NULL
AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
			 SELECT * FROM CIDADE 
			WHERE Cod_Estado = @CodEstado
		END
END
GO
/****** Object:  StoredProcedure [dbo].[pCliente]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC pCliente @Operacao = 'GRID' 


---EXEC pCliente @Operacao = 'INSE', @NomeCli = 'THAYS', @DataNasc = '2019-07-03', @TelCli = '11950553070',@Emailcli = 'thays@g.com',
	--@RgCli = '534595741',@CpfCnpj  = '202010200000134', @CodTipoCli = 2
--EXEC pCliente @Operacao = 'DELE' ,@CodCli = 2
CREATE PROCEDURE [dbo].[pCliente]

@Operacao varchar(4),
@CodCli int = null,
@NomeCli varchar(100) = null,
@DataNasc date = null,
@TelCli varchar(14)= null,
@EmailCli varchar(40) = null,
@CpfCnpj varchar(20) = null,
@CodTipoCli int = null,
@Cep varchar(10) = NULL,
@Logra varchar(100) = NULL,
@Num int = NULL,
@Bairro varchar(50) = NULL,
@CodCidade int = NULL,
@CodEstado int = NULL

AS

BEGIN

	IF @Operacao = 'INSE' 
	BEGIN
		INSERT CLIENTE VALUES(GETDATE(),@NomeCli,@DataNasc,@TelCli,@EmailCli,@CpfCnpj,@CodTipoCli,@Cep,@Logra,@Num,@Bairro,@CodCidade,@CodEstado)
		SELECT @@IDENTITY AS CODCLI;
	END

	ELSE IF @Operacao  = 'ALTE' 
	BEGIN
		UPDATE CLIENTE 
		SET Nome_Cliente = @NomeCli, 
			Data_Nascimento =  @DataNasc,
			Telefone_Cliente = @TelCli,
			Email_Cliente = @EmailCli,
			CPF_CNPJ = @CpfCnpj,
			Cod_TipoCliente = @CodTipoCli,
			Cep = @Cep,
			Logradouro = @Logra,
			Numero = @Num,
			Bairro=@Bairro,
			Cod_Cidade=@CodCidade,
			Cod_Estado=@CodEstado

		WHERE Cod_Cliente = @CodCli
	END
	ELSE IF @Operacao = 'DELE'
	BEGIN

		IF EXISTS(SELECT 
					1 
				 FROM
					Viagem 
				WHERE 
					Cod_Cliente = @CodCli)
			BEGIN
				DELETE 
					Viagem
				WHERE
					Cod_Cliente = @CodCli
					
			END

		DELETE FROM CLIENTE 
		WHERE Cod_Cliente = @CodCli
	END
	ELSE IF @Operacao = 'GRID'
	BEGIN
		IF @NomeCli IS NULL 
		BEGIN
		SET @NomeCli = ''
		END
			IF @CpfCnpj IS NULL 
		BEGIN
		SET @CpfCnpj = ''
		END
	
		SELECT 
			C.Cod_Cliente,
			C.Nome_Cliente CLIENTE,
			C.CPF_CNPJ [CPF/CNPJ],
			T.Descricao TIPO,
			C.Telefone_Cliente TELEFONE,
			C.Email_Cliente	EMAIL		,
			C.Data_Cadastro [DATA DE CADASTRO]
		
		FROM CLIENTE C
		INNER JOIN TIPO_CLIENTE T 
		ON T.Cod_TipoCliente = C.Cod_TipoCliente
		WHERE Nome_Cliente  LIKE '%' + @NomeCli + '%' AND 
			  CPF_CNPJ LIKE '%' + @CpfCnpj + '%' 
	END

	ELSE IF @Operacao = 'OBTE'
	BEGIN
			SELECT * FROM CLIENTE 
			WHERE  Cod_Cliente = @CodCli

	END
	ELSE IF @Operacao = 'COMB'
	BEGIN
		SELECT Cod_Cliente, Nome_Cliente FROM CLIENTE
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pEstado]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pEstado]
@Operacao varchar(4),
@CodEstado int = NULL,
@UfEstado varchar(100) = NULL

AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
			SELECT Cod_Estado,
			       UF_Estado 
			FROM ESTADO 
		END
END
GO
/****** Object:  StoredProcedure [dbo].[pFuncionario]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pFuncionario]
@Operacao varchar(4),
@CodMatricula int = null,
@NomeFunc varchar(100) = null,
@DataNasc date = null,
@TelFunc varchar(14) = null,
@EmailFunc varchar(40) = null,
@CpfFunc varchar(20) = null,
@CodCargo int = null,
@Senha varchar(100)=null,
@Cep varchar(10) = NULL,
@Logra varchar(100) = NULL,
@Num int = NULL,
@Bairro varchar(50) = NULL,
@CodCidade int = NULL,
@CodEstado int = NULL


AS
BEGIN

	IF @Operacao = 'INSE'
BEGIN
	INSERT FUNCIONARIO (Nome_Funcionario,Data_Nascimento,Telefone_Funcionario,Email_Funcionario,CPF_Funcionario,Cod_Cargo,Cep,Logradouro,Numero,Bairro,Cod_Cidade,Cod_Estado,Senha)
	
	VALUES(@NomeFunc,@DataNasc,@TelFunc,@EmailFunc,@CpfFunc,@CodCargo,@Cep,@Logra,@Num,@Bairro,@CodCidade,@CodEstado,@CpfFunc)
END

ELSE IF @Operacao = 'DELE'
BEGIN
	DELETE FROM FUNCIONARIO
	WHERE Cod_Matricula = @CodMatricula
END

ELSE IF @Operacao ='ALTE'
BEGIN
	UPDATE FUNCIONARIO SET
							
							Nome_Funcionario	 =	@NomeFunc,
							Data_Nascimento		 =	@DataNasc,
							Telefone_Funcionario =  @TelFunc,
							Email_Funcionario	 =  @EmailFunc,
							CPF_Funcionario		 =  @CpfFunc,
							Cod_Cargo			 =	@CodCargo,
							Cep					 =	@Cep,
							Logradouro			 =	@Logra,
							Numero				 =	@Num,
							Bairro				 =	@Bairro,
							Cod_Cidade			 =	@CodCidade,
							Cod_Estado			 =	@CodEstado
						
	WHERE Cod_Matricula = @CodMatricula
END

ELSE IF @Operacao = 'GRID'
	BEGIN
			IF @NomeFunc IS NULL 
		BEGIN
		SET @NomeFunc = ''
		END
			IF @CpfFunc IS NULL 
		BEGIN
		SET @CpfFunc= ''
		END

		SELECT func.Cod_Matricula,
			   func.Nome_Funcionario [FUNCIONÁRIO],
			   func.Telefone_Funcionario TELEFONE,
			   func.Email_Funcionario EMAIL,
			   func.CPF_Funcionario CPF,
			   cargo.Cargo CARGO
			  -- cid.Nome_Cidade CIDADE,
		--	   uf.UF_Estado ESTADO
				
		FROM FUNCIONARIO func
			LEFT JOIN TIPO_CARGO cargo ON
		    func.Cod_Cargo = cargo.Cod_Cargo
			INNER JOIN CIDADE cid ON
			func.Cod_Cidade = cid.Cod_Cidade
			INNER JOIN ESTADO uf ON
			func.Cod_Estado = uf.Cod_Estado

		WHERE ( Nome_Funcionario LIKE '%' + @NomeFunc + '%' AND Nome_Funcionario != 'Administrador') AND
			  CPF_Funcionario LIKE '%' + @CpfFunc + '%'	
			
		 
	END
ELSE IF @Operacao = 'OBTE'
	BEGIN
		SELECT * FROM FUNCIONARIO
		WHERE Cod_Matricula = @CodMatricula
	END
	ELSE IF @Operacao = 'LOGA'
		BEGIN
		SELECT * FROM FUNCIONARIO
		WHERE Email_Funcionario = @EmailFunc AND Senha = @Senha
		END

	ELSE IF @Operacao = 'COMB'
		BEGIN
			SELECT Cod_Matricula, Nome_Funcionario FROM FUNCIONARIO
			WHERE Nome_Funcionario != 'Administrador'
		END
	ELSE IF @Operacao = 'SENH'
	BEGIN
		UPDATE
			FUNCIONARIO
		SET
			Senha = @Senha
		WHERE 
			Cod_Matricula = @CodMatricula
		
	END
	ELSE IF @Operacao = 'VERI'
	BEGIN
		SELECT 
			* 
		FROM
			FUNCIONARIO
		WHERE 
			Email_Funcionario = @EmailFunc AND
			CPF_Funcionario = @CpfFunc AND
			Data_Nascimento = @DataNasc
		
	END
END




GO
/****** Object:  StoredProcedure [dbo].[pManutencao]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pManutencao]
@Operacao varchar(4),
@CodManu int = null,
@DataEntrada date = null,
@DataEntradaFinal date = null,
@PrevSaida date = null,
@PrevSaidaFinal date = null,
@DescServico varchar(100) = null,
@CodVeic int = null,
@codStatusManutencao INT = NULL
AS
BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT MANUTENCAO VALUES(
		@DataEntrada ,
		@PrevSaida,
		@DescServico  ,
		@CodVeic,
		@codStatusManutencao)
	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE MANUTENCAO SET 
				Data_Entrada =	@DataEntrada ,
				Previsao_Saida = @PrevSaida,
				Descricao_Servico =	@DescServico,  
				Cod_Veiculo = @CodVeic ,
				cod_Status_Manutencao = @codStatusManutencao

			WHERE Cod_Manutencao = @CodManu
	END

	ELSE IF @Operacao = 'DELE'
	BEGIN
			DELETE FROM MANUTENCAO
			WHERE Cod_Manutencao = @CodManu
	END

	ELSE IF  @Operacao = 'CONV'
	BEGIN
			SELECT * FROM MANUTENCAO
			WHERE Cod_Veiculo = @CodVeic
	END

	ELSE IF @Operacao = 'GRID'
	BEGIN
		IF @DataEntrada IS NULL
		BEGIN
		SET @DataEntrada = ''
		END
		IF @PrevSaida IS NULL
		BEGIN
		SET @PrevSaida = ''
		END
		IF @DataEntrada IS NULL
		BEGIN
		SET @DescServico = ''
		END

		SELECT  M.Cod_Manutencao,
				V.Modelo [VEÍCULO],
			    M.Descricao_Servico SERVIÇO,
				M.Data_Entrada [DATA DE ENTRADA],
				M.Previsao_Saida [PREVISÃO DE SAÍDA],
				CASE 
					WHEN cod_Status_Manutencao = 1  THEN 'Aberto'
					WHEN cod_Status_Manutencao = 2  THEN 'Finalizado'
				END as Status
		FROM MANUTENCAO M
		INNER JOIN VEICULO V ON
		V.Cod_Veiculo = M.Cod_Veiculo
		
		WHERE (@DataEntrada = '' OR  Data_Entrada BETWEEN @DataEntrada AND @DataEntradaFinal ) AND
			  (@PrevSaida = '' OR Previsao_Saida BETWEEN @PrevSaida AND @PrevSaidaFinal ) AND
			  Descricao_Servico LIKE '%' + @DescServico + '%'
	END

	ELSE IF @Operacao = 'OBTE'
	BEGIN
			SELECT * FROM MANUTENCAO
			WHERE Cod_Manutencao = @CodManu
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pMarca]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pMarca]
@Operacao varchar(4),
@CodMarca int = NULL,
@Descricao varchar(20) = NULL

AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
		  SELECT * FROM MARCA
		END

	ELSE IF @Operacao = 'INSE'
	BEGIN
		INSERT MARCA	VALUES (@Descricao)
	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
		UPDATE Marca SET Descricao = @Descricao
			WHERE Cod_Marca = @CodMarca
	END

	ELSE IF @Operacao = 'DELE'
	BEGIN
			DELETE FROM MARCA
			WHERE Cod_Marca = @CodMarca
	END
END

GO
/****** Object:  StoredProcedure [dbo].[pMotorista]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pMotorista](
@Operacao varchar(4),
@CodMotorista int = NULL,
@NomeMotorista varchar(100) = NULL,
@DataNasc date = NULL,
@CnhCat int = NULL,
@CnhNum varchar(11) = NULL,
@CnhVenc date = NULL,
@CnhVencFinal date = null,
@Telefone varchar(14)= NULL,
@Email varchar(40)= NULL,
@Status int= NULL,
@Cep varchar(10)= NULL,
@Logra varchar(100)= NULL,
@Num varchar(10)= NULL,
@Bairro varchar(40)= NULL,
@CodCidade int= NULL,
@CodEstado int= NULL)
AS
BEGIN

	IF @Operacao  = 'INSE'
	BEGIN
		INSERT MOTORISTA VALUES(@NomeMotorista,@DataNasc,@CnhCat,@CnhNum,@CnhVenc,@Telefone,@Email,@Status,@Cep,@Logra,@Num,@Bairro,@CodCidade,@CodEstado)
	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN 
		UPDATE MOTORISTA SET 
								Nome_Motorista = @NomeMotorista,
								Data_Nascimento = @DataNasc,
								CNH_Categoria = @CnhCat,
								CNH_Numero = @CnhNum,
								CNH_Vencimento = @CnhVenc,
								Telefone_Motorista=@Telefone,
								Email_Motorista=@Email,
								Status_Motorista=@Status,
								Cep=@Cep,
								Logradouro=@Logra,
								Numero=@Num,
								Bairro=@Bairro,
								Cod_Cidade=@CodCidade,
								Cod_Estado=@CodEstado
		WHERE Cod_Motorista = @CodMotorista
	END


	ELSE IF @Operacao = 'DELE'
	BEGIN
		DELETE FROM MOTORISTA
		WHERE Cod_Motorista = @CodMotorista

	END

	ELSE IF @Operacao = 'GRID'
	BEGIN
		IF @NomeMotorista IS NULL
			BEGIN
			SET		
			@NomeMotorista = ''
			END

			IF @CnhCat IS NULL
			BEGIN
			SET
			@CnhCat = ''
			END

		

			SELECT	 Cod_Motorista,
					 Nome_Motorista MOTORISTA,
					 CASE
					  WHEN Status_Motorista = 1 THEN 'Ativo'
					  WHEN Status_Motorista = 2 THEN 'inativo'
					  ELSE 'NENHUM'
			  		 END AS STATUS,
					 CASE 
					  WHEN CNH_Categoria  = 1 THEN 'A' 
					  WHEN CNH_Categoria  = 2 THEN 'B' 
					  WHEN CNH_Categoria  = 3 THEN 'C'
					  WHEN CNH_Categoria  = 4 THEN 'D'
					  WHEN CNH_Categoria  = 5 THEN 'E'
					  WHEN CNH_Categoria  = 6 THEN 'AB'
					  WHEN CNH_Categoria  = 7 THEN 'AC'
					  WHEN CNH_Categoria  = 8 THEN 'AD'
					  WHEN CNH_Categoria  = 9 THEN 'AE'
			 		  ELSE 'NENHUM' 
					 END AS [CATEGORIA],
					CNH_Vencimento [VALIDADE CNH],
					CNH_Numero [Nº CNH],
					Telefone_Motorista TELEFONE,
					Email_Motorista EMAIL


			FROM MOTORISTA
		
			WHERE Nome_Motorista LIKE '%' + @NomeMotorista + '%' AND
			 -- (@CnhCat IS NULL OR CNH_Categoria = @CnhCat)  	AND
				 (@CnhVenc IS NULL OR  CNH_Vencimento BETWEEN @CnhVenc AND @CnhVencFinal)
	END

	ELSE IF @Operacao = 'COMB'
		 BEGIN 
			SELECT Cod_Motorista,Nome_Motorista FROM MOTORISTA
			WHERE  Status_Motorista = 1   
		END
	ELSE IF @Operacao = 'OBTE'
		BEGIN
			SELECT * FROM MOTORISTA 
			WHERE Cod_Motorista = @CodMotorista
		END
END

GO
/****** Object:  StoredProcedure [dbo].[pStatusVeiculo]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pStatusVeiculo]
@Operacao varchar(4),
@CodStatus int = NULL,
@Descricao varchar(15) = NULL

AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
	    SELECT * FROM STATUS_VEICULO
		END
END 
GO
/****** Object:  StoredProcedure [dbo].[pTipoCargo]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pTipoCargo]
@Operacao varchar(4),
@CodCargo int = NULL,
@Cargo varchar(20) = NULL

AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
		  SELECT * FROM TIPO_CARGO
		END 


	ELSE IF @Operacao = 'INSE'
	BEGIN
		INSERT TIPO_CARGO 	VALUES (@Cargo)
	END


	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE TIPO_CARGO SET Cargo = @Cargo
			WHERE Cod_Cargo = @CodCargo
	END


	ELSE IF @Operacao = 'DELE'
	BEGIN
			DELETE FROM TIPO_CARGO 
			WHERE Cod_Cargo = @CodCargo
	END
END

GO
/****** Object:  StoredProcedure [dbo].[pTipoCliente]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pTipoCliente]
@Operacao varchar(4),
@CodTipCli int = NULL,
@Descricao varchar(15) = NULL

AS
BEGIN
		IF @Operacao = 'COMB'
		BEGIN
	    SELECT * FROM TIPO_CLIENTE
		END
END 
GO
/****** Object:  StoredProcedure [dbo].[pVeiculo]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pVeiculo]
@Operacao varchar(4),
@CodVei int = null,
@CodMarca int = NULL,
@Modelo varchar(20) = NULL,
@Renavam varchar(11) = NULL,
@CodStatus int  = NULL,
@DataAq date  = NULL,
@AnoFab char(4) = NULL,
@KmInicial varchar(10) = NULL,
@KmAtual varchar(10) = NULL,
@KmPrev varchar(10) = NULL,
@UltimaRev varchar(10) = NULL,
@Placa varchar(7) =null

AS

BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT VEICULO VALUES(
								@CodMarca,
								@Modelo,
								@Renavam ,
								@CodStatus ,
								@DataAq,
								@AnoFab,
								@KmAtual,
								@KmPrev,
								@UltimaRev,
								@KmInicial,
								@Placa)

	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE VEICULO SET
								Cod_Marca =			 @CodMarca,
								Modelo = 			@Modelo,
								Renavam =			@Renavam ,
								Cod_Status =		@CodStatus ,
								Data_Aquisicao =	@DataAq,
								Ano_Fabricacao =	@AnoFab,	
								KM_Atual =			@KmAtual,
								KM_Prevencao =		@KmPrev,
								Ultima_Revisao = 	@UltimaRev,
								Km_Inicial	   =	@KmInicial,
								Placa			=   @Placa
								
		WHERE Cod_Veiculo = @CodVei

	END

	IF @Operacao = 'DELE'
	BEGIN

			IF  EXISTS(SELECT 1 
					   FROM MANUTENCAO m 
					   where m.Cod_Veiculo = @CodVei)
			BEGIN
				DELETE MANUTENCAO 
				where Cod_Veiculo = @CodVei
			END

			IF EXISTS(SELECT 1 
			          FROM VIAGEM 
					  WHERE Cod_Veiculo = @CodVei)
			BEGIN
				DELETE 
					VIAGEM 
				WHERE 
					Cod_Veiculo = @CodVei
			END





			DELETE FROM VEICULO 
			WHERE Cod_Veiculo = @CodVei
	END

	ELSE IF @Operacao = 'COMB'
	BEGIN
		SELECT Cod_Veiculo,Modelo  FROM VEICULO
		WHERE Cod_Status = 1
	END
	--OPERAÇÃO PARA CARREGAR COMBO PARA MANUTENÇÃO.
	ELSE IF @Operacao='MANU'
		BEGIN
			SELECT Cod_Veiculo,Modelo FROM VEICULO
		END
	ELSE IF @Operacao = 'GRID'
		BEGIN

			IF @Modelo IS NULL
			BEGIN
			SET @Modelo = ''
			END
			IF @CodMarca IS NULL
			BEGIN
			SET @CodMarca = 0
			END

			SELECT Cod_Veiculo,
				   m.Descricao MARCA,
				   v.Modelo MODELO,
				   S.Descricao_Status [STATUS],
				   v.KM_Atual [KM ATUAL],
				   V.KM_Prevencao [MANUTENÇÃO PREVENTIVA (KM)],
				   V.Ultima_Revisao [ULTIMA REVISÃO EM]

			FROM VEICULO v
			LEFT JOIN MARCA m ON
			m.Cod_Marca	=	v.Cod_Marca 
			LEFT JOIN STATUS_VEICULO s ON
			s.Cod_Status = v.Cod_Status

			where Modelo Like  '%' + @Modelo + '%' AND
				  (@CodMarca = 0 OR    v.Cod_Marca  = @CodMarca)
		END
	ELSE IF @Operacao = 'OBTE'
	BEGIN
	SELECT * FROM VEICULO V INNER JOIN
	MARCA M ON M.Cod_Marca = V.Cod_Marca
	WHERE Cod_Veiculo = @CodVei 
	END

END

GO
/****** Object:  StoredProcedure [dbo].[pViagem]    Script Date: 09/12/2019 03:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pViagem]
@Operacao varchar(4),
@CodVi int = NULL,
@DataVi date = NULL,
@DataViFinal date =null,
@DistanciaKm varchar(10) = NULL,
@Valor decimal(18,2) = NULL,
@CepOrig varchar(10) = NULL,
@LograOrig varchar(100) = NULL,
@NumOrig int = NULL,
@CompleOrig varchar(100) = NULL,
@BairroOrig varchar(50) = NULL,
@CidadeOrig varchar(50) = NULL,
@UfOrig char(2) = NULL,
@CepDest varchar(10) = NULL,
@LograDest varchar(100) = NULL,
@NumDest int = NULL,
@CompleDest varchar(100) = NULL,
@BairroDest varchar(50) = NULL,
@CidadeDest varchar(50) = NULL,
@UfDest char(2) = NULL,
@CodCli int = NULL,
@CodVei int = NULL,
@CodMot int = NULL,
@CodAte int = NULL,
@Status int = NULL
AS

BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT VIAGEM VALUES(
								@DataVi ,
								@DistanciaKm ,
								@Valor ,
								@CepOrig ,
								@LograOrig ,
								@NumOrig ,
								@CompleOrig,
								@BairroOrig ,
								@CidadeOrig ,
								@UfOrig ,
								@CepDest ,
								@LograDest ,
								@NumDest ,
								@CompleDest,
								@BairroDest ,
								@CidadeDest,
								@UfDest ,
								@CodCli ,
								@CodVei,
								@CodAte,
								@CodMot,
								@Status)


	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE VIAGEM SET
						Data_Viagem =		@DataVi ,
						Distancia_Km =		@DistanciaKm ,
						Valor =				@Valor ,
						Cep_Origem =		@CepOrig ,
						Lograd_Origem =		@LograOrig ,
						Numero_Origem =		@NumOrig ,
						Complemento_Origem =@CompleOrig,
						Bairro_Origem =		@BairroOrig ,
						Cod_CidadeOrigem =	@CidadeOrig ,
						Cod_UFOrigem =		@UfOrig ,
						Cep_Destino = 		@CepDest ,
						Lograd_Destino =	@LograDest ,
						Numero_Destino =	@NumDest ,
						Complemento_Destino =@CompleDest,
						Bairro_Destino =	@BairroDest ,
						Cod_CidadeDestino =	@CidadeDest,
						Cod_UFDestino =		@UfDest ,
						Cod_Cliente =		@CodCli ,
						Cod_Veiculo =		@CodVei,
						Cod_Atendente =		@CodAte ,
						Cod_Motorista =		@CodMot,
						[Status]	  =		@Status

		WHERE Cod_Viagem = @CodVi

	END


	ELSE IF @Operacao = 'DELE'
	BEGIN
			DELETE FROM VIAGEM 
			WHERE  Cod_Viagem = @CodVi
	END


	ELSE IF @Operacao = 'GRID'
	BEGIN

		BEGIN
		IF @DataVi IS NULL
		SET @DataVi = ''
		END
		BEGIN
		IF @CodMot = 0
		SET @CodMot =  null
		END
		BEGIN
		IF @CodCli = 0
		SET @CodCli = null
		END

		SELECT V.Cod_Viagem,
			   V.Data_Viagem [DATA DA VIAGEM],

			   CASE
			   WHEN [Status] = 1 THEN 'Pendente'
			   WHEN [Status] = 2 THEN 'Em Trânsito'
			   WHEN [Status] = 3 THEN 'Finalizada'
			   ELSE ''
			   END AS [STATUS],

			   M.Nome_Motorista MOTORISTA,
			   CLI.Nome_Cliente CLIENTE,
			   V.Distancia_Km [DISTANCIA EM KM],
			   V.Valor VALOR,
			   CO.Nome_Cidade [ORIGEM: CIDADE],
			   EO.UF_Estado [ORIGEM: UF],
			   CD.Nome_Cidade[DESTINO: CIDADE],
			   ED.UF_Estado [DESTINO: UF]

		FROM VIAGEM V 
		INNER JOIN MOTORISTA M ON 
		         V.Cod_Motorista = M.Cod_Motorista 
		INNER JOIN CLIENTE CLI ON
				 V.Cod_Cliente = CLI.Cod_Cliente
		INNER JOIN VEICULO VEI ON 
		         VEI.Cod_Veiculo = V.Cod_Veiculo 
		INNER JOIN CIDADE CO ON 
		          V.Cod_CidadeOrigem = CO.Cod_Cidade 
		INNER JOIN CIDADE CD ON 
		         V.Cod_CidadeDestino = CD.Cod_Cidade
		INNER JOIN ESTADO EO ON 
				V.Cod_UFOrigem = EO.Cod_Estado
		INNER JOIN ESTADO ED ON
				V.Cod_UFDestino = ED.Cod_Estado

		WHERE (@DataVi ='' OR Data_Viagem BETWEEN @DataVi AND @DataViFinal) AND
		 (@CodMot IS null  OR  V.Cod_Motorista = @CodMot) AND
			(@CodCli IS  NULL OR  V.Cod_Cliente = @CodCli)
	END

	ELSE IF @Operacao = 'OBTE'
		SELECT  * FROM VIAGEM
		WHERE Cod_Viagem = @CodVi

END

GO
