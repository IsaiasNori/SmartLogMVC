USE [SmartLog]
GO
/****** Object:  StoredProcedure [dbo].[pCidade]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pCliente]    Script Date: 23/11/2019 21:17:49 ******/
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
			C.Data_Cadastro [DATA DE CADASTRO],
						
			C.Telefone_Cliente TELEFONE,
			C.Email_Cliente	EMAIL		
		
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
END
GO
/****** Object:  StoredProcedure [dbo].[pEstado]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pFuncionario]    Script Date: 23/11/2019 21:17:49 ******/
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
	INSERT FUNCIONARIO (Nome_Funcionario,Data_Nascimento,Telefone_Funcionario,Email_Funcionario,CPF_Funcionario,Cod_Cargo,Cep,Logradouro,Numero,Bairro,Cod_Cidade,Cod_Estado)
	VALUES(@NomeFunc,@DataNasc,@TelFunc,@EmailFunc,@CpfFunc,@CodCargo,@Cep,@Logra,@Num,@Bairro,@CodCidade,@CodEstado)
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

		SELECT Cod_Matricula,
			   Nome_Funcionario FUNCIONÁRIO,
			   Telefone_Funcionario TELEFONE,
			   Email_Funcionario EMAIL,
			   CPF_Funcionario CPF,
			   C.Cargo CARGO
				
		FROM FUNCIONARIO f
			INNER JOIN TIPO_CARGO c ON
		    f.Cep = c.Cod_Cargo

		WHERE Nome_Funcionario LIKE '%' + @NomeFunc + '%' or
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
END

--exec pFuncionario @Operacao=GRID 
GO
/****** Object:  StoredProcedure [dbo].[pManutencao]    Script Date: 23/11/2019 21:17:49 ******/
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
@CodVeic int = null
AS
BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT MANUTENCAO VALUES(
		@DataEntrada ,
		@PrevSaida,
		@DescServico  ,
		@CodVeic )
	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE MANUTENCAO SET 
				Data_Entrada =	@DataEntrada ,
				Previsao_Saida = @PrevSaida,
				Descricao_Servico =	@DescServico,  
				Cod_Veiculo = @CodVeic 

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

		SELECT * FROM MANUTENCAO
		WHERE Data_Entrada BETWEEN @DataEntrada AND @DataEntradaFinal OR
			  Previsao_Saida BETWEEN @PrevSaida AND @PrevSaidaFinal OR
			  Descricao_Servico LIKE '%' + '@DescServico' + '%'
	END

	ELSE IF @Operacao = 'OBTE'
	BEGIN
			SELECT * FROM MANUTENCAO
			WHERE Cod_Manutencao = @CodManu
	END
END
GO
/****** Object:  StoredProcedure [dbo].[pMarca]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pMotorista]    Script Date: 23/11/2019 21:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pMotorista](
@Operacao varchar(4),
@CodMotorista int = NULL,
@Nome varchar(100) = NULL,
@DataNasc date = NULL,
@CnhCat char(2) = NULL,
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
		INSERT MOTORISTA VALUES(@Nome,@DataNasc,@CnhCat,@CnhNum,@CnhVenc,@Telefone,@Email,@Status,@Cep,@Logra,@Num,@Bairro,@CodCidade,@CodEstado)
	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN 
		UPDATE MOTORISTA SET 
								Nome_Motorista = @Nome,
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
		IF @Nome IS NULL
		BEGIN
		SET		
		@Nome = ''
		END

		IF  @CodMotorista IS NULL
		BEGIN
		SET
		@CodMotorista = ''
		END

		IF @CnhVenc IS NULL
		BEGIN
		SET
		@CnhVenc = ''
		END

		SELECT * FROM MOTORISTA
		
		WHERE Nome_Motorista LIKE '%' + '@Nome' + '%' OR
			  Cod_Motorista LIKE '%' + '@CodMotorista' + '%' OR
			  CNH_Vencimento BETWEEN @CnhVenc AND @CnhVencFinal
	END


	ELSE IF @Operacao = 'COMB'
	 BEGIN 
		SELECT Cod_Motorista,Nome_Motorista FROM MOTORISTA
	END
	ELSE IF @Operacao = 'OBTE'
	BEGIN
	SELECT * FROM MOTORISTA 
	WHERE Cod_Motorista = @CodMotorista
	END
END

GO
/****** Object:  StoredProcedure [dbo].[pStatusVeiculo]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pTipoCargo]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pTipoCliente]    Script Date: 23/11/2019 21:17:49 ******/
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
/****** Object:  StoredProcedure [dbo].[pVeiculo]    Script Date: 23/11/2019 21:17:49 ******/
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
@KmAtual varchar(10) = NULL,
@KmPrev varchar(10) = NULL,
@UltimaRev varchar(10) = NULL

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
								@UltimaRev)

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
								Ultima_Revisao = 	@UltimaRev
								
		WHERE Cod_Veiculo = @CodVei

	END

	IF @Operacao = 'DELE'
	BEGIN
			DELETE FROM VEICULO 
			WHERE Cod_Veiculo = @CodVei
	END

	ELSE IF @Operacao = 'COMB'
	BEGIN
		SELECT Cod_Veiculo,Modelo  FROM VEICULO
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

		SELECT * FROM VEICULO
		where Modelo Like  '%' + @Modelo + '%' AND
			  (@CodMarca = 0 OR    Cod_Marca  = @CodMarca)
	END
	ELSE IF @Operacao = 'OBTE'
	BEGIN
	SELECT * FROM VEICULO V INNER JOIN
	MARCA M ON M.Cod_Marca = V.Cod_Marca
	WHERE Cod_Veiculo = @CodVei 
	END

END

--exec pVeiculo @Operacao = 'GRID', @Modelo = '', @CodMarca = null
GO
/****** Object:  StoredProcedure [dbo].[pViagem]    Script Date: 23/11/2019 21:17:49 ******/
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
@CepOr varchar(10) = NULL,
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
@CodAte int = NULL

AS

BEGIN
	IF @Operacao = 'INSE'
	BEGIN
		INSERT VIAGEM VALUES(
								@DataVi ,
								@DistanciaKm ,
								@Valor ,
								@CepOr ,
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
								@CodMot)


	END

	ELSE IF @Operacao = 'ALTE'
	BEGIN
			UPDATE VIAGEM SET
						Data_Viagem =		@DataVi ,
						Distancia_Km =		@DistanciaKm ,
						Valor =				@Valor ,
						Cep_Origem =		@CepOr ,
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
						Cod_Motorista =		@CodMot 

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
		IF @CodMot IS NULL
		SET @CodMot = ''
		END
		BEGIN
		IF @CodCli IS NULL
		SET @CodCli = ''
		END
		SELECT V.Cod_Viagem,
			   V.Data_Viagem [DATA DA VIAGEM],
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
		         V.Cod_Veiculo = V.Cod_Veiculo 
		INNER JOIN CIDADE CO ON 
		          V.Cod_CidadeOrigem = CO.Cod_Cidade 
		INNER JOIN CIDADE CD ON 
		         V.Cod_CidadeDestino = CD.Cod_Cidade
		INNER JOIN ESTADO EO ON 
				V.Cod_UFOrigem = EO.Cod_Estado
		INNER JOIN ESTADO ED ON
				V.Cod_UFDestino = ED.Cod_Estado

		WHERE Data_Viagem  BETWEEN @DataVi AND @DataViFinal OR
			 v.Cod_Motorista = @CodMot OR
			 v.Cod_Cliente = @CodCli
	END

	ELSE IF @Operacao = 'OBTE'
		SELECT  * FROM VIAGEM
		WHERE Cod_Viagem = @CodVi

END
GO
