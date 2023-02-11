

CREATE PROCEDURE PF.AdicionarCliente(@Nome varchar(20), @Endere�o varchar(30), @N�_CC char(8), @G�nero char, @Email varchar(30), @Nome_Empresa varchar(10))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarCC(@N�_CC))
		IF(@count>=1)
			RAISERROR ('O n�_CC introduzido j� existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.CLIENTE(Nome, Endere�o, N�_CC, G�nero, Email, Nome_Empresa) VALUES (@Nome, @Endere�o, @N�_CC, @G�nero, @Email, @Nome_Empresa)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O cliente n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO



CREATE PROCEDURE PF.UpdateCliente (@Nome varchar(20), @Endere�o varchar(30), @N�_CC char(8), @G�nero char, @Email varchar(30), @Nome_Empresa varchar(10))
AS
	BEGIN
		DECLARE @erro VARCHAR(100)
		BEGIN TRY
			UPDATE PF.CLIENTE
					SET
					Endere�o=@Endere�o,
					N�_CC=@N�_CC,
					G�nero=@G�nero,
					Email=@Email,
					Nome_Empresa=@Nome_Empresa

					WHERE Nome=@Nome
			END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SELECT @erro = ERROR_MESSAGE();
			SET @erro = 'O cliente n�o foi atualizado, algum valor inserido incorretamente'
			RAISERROR (@erro, 16,1);
		END CATCH
	END
GO


CREATE PROCEDURE PF.AdicionarProduto(@C�digo char(9), @Nome varchar(20), @Pre�o float, @Taxa_de_IVA float, @N�_em_stock int, @Nome_Empresa varchar(10), @Tipo_Categoria varchar(20))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarCodigo(@C�digo))
		IF(@count>=1)
			RAISERROR ('O C�digo introduzido j� existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.PRODUTO(C�digo, Nome, Pre�o, Taxa_de_IVA, N�_em_stock, Nome_Empresa, Tipo_Categoria) VALUES (@C�digo, @Nome, @Pre�o, @Taxa_de_IVA, @N�_em_stock, @Nome_Empresa, @Tipo_Categoria)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O Produto n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

select * from PF.PRODUTO

CREATE PROCEDURE PF.AdicionarEncomenda(@N�mero int, @Data date, @Endere�o varchar(30), @Hora_Envio time(7), @Nome_Empresa varchar(10), @Nome_Cliente varchar(20))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarN�mero(@N�mero))
		IF(@count>=1)
			RAISERROR ('O N�mero introduzido j� existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.ENCOMENDA(N�mero,Data,Endere�o,Hora_Envio,Nome_Empresa,Nome_Cliente) VALUES (@N�mero,@Data,@Endere�o,@Hora_Envio,@Nome_Empresa,@Nome_Cliente)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'A encomenda n�o foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

CREATE PROCEDURE PF.AdicionarEnvio(@Hora time(7), @Destino varchar(30), @N�_de_encomendas int, @Nome_transportadora varchar(10))
AS
			BEGIN
			declare @erro varchar(100)
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.ENVIO(Hora, Destino, N�_de_encomendas, Nome_transportadora) VALUES (@Hora, @Destino, @N�_de_encomendas, @Nome_transportadora)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O envio n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
GO

CREATE PROCEDURE PF.AdicionarEncProd(@Codigo_Produto char(9), @N�mero_Encomenda int)
AS
			BEGIN
			declare @erro varchar(100)
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.possui(Codigo_Produto, N�mero_encomenda) VALUES (@Codigo_Produto, @N�mero_Encomenda)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O envio n�o foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
GO

CREATE PROCEDURE PF.AdicionarFornEmpre(@Nome_Fornecedor varchar(20), @Nome_Empresa varchar(10))
AS
			BEGIN
			declare @erro varchar(100)
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.fornece(Nome_Fornecedor, Nome_Empresa) VALUES (@Nome_Fornecedor, @Nome_Empresa)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'A encomenda n�o foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
GO