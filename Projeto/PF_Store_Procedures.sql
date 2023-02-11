

CREATE PROCEDURE PF.AdicionarCliente(@Nome varchar(20), @Endereço varchar(30), @Nº_CC char(8), @Género char, @Email varchar(30), @Nome_Empresa varchar(10))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarCC(@Nº_CC))
		IF(@count>=1)
			RAISERROR ('O nº_CC introduzido já existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.CLIENTE(Nome, Endereço, Nº_CC, Género, Email, Nome_Empresa) VALUES (@Nome, @Endereço, @Nº_CC, @Género, @Email, @Nome_Empresa)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O cliente não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO



CREATE PROCEDURE PF.UpdateCliente (@Nome varchar(20), @Endereço varchar(30), @Nº_CC char(8), @Género char, @Email varchar(30), @Nome_Empresa varchar(10))
AS
	BEGIN
		DECLARE @erro VARCHAR(100)
		BEGIN TRY
			UPDATE PF.CLIENTE
					SET
					Endereço=@Endereço,
					Nº_CC=@Nº_CC,
					Género=@Género,
					Email=@Email,
					Nome_Empresa=@Nome_Empresa

					WHERE Nome=@Nome
			END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SELECT @erro = ERROR_MESSAGE();
			SET @erro = 'O cliente não foi atualizado, algum valor inserido incorretamente'
			RAISERROR (@erro, 16,1);
		END CATCH
	END
GO


CREATE PROCEDURE PF.AdicionarProduto(@Código char(9), @Nome varchar(20), @Preço float, @Taxa_de_IVA float, @Nº_em_stock int, @Nome_Empresa varchar(10), @Tipo_Categoria varchar(20))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarCodigo(@Código))
		IF(@count>=1)
			RAISERROR ('O Código introduzido já existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.PRODUTO(Código, Nome, Preço, Taxa_de_IVA, Nº_em_stock, Nome_Empresa, Tipo_Categoria) VALUES (@Código, @Nome, @Preço, @Taxa_de_IVA, @Nº_em_stock, @Nome_Empresa, @Tipo_Categoria)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O Produto não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

select * from PF.PRODUTO

CREATE PROCEDURE PF.AdicionarEncomenda(@Número int, @Data date, @Endereço varchar(30), @Hora_Envio time(7), @Nome_Empresa varchar(10), @Nome_Cliente varchar(20))
AS
	BEGIN
		DECLARE @count INT;
		DECLARE @erro VARCHAR(100)
		SET @count = (SELECT PF.VerificarNúmero(@Número))
		IF(@count>=1)
			RAISERROR ('O Número introduzido já existe!', 16,1);
		ELSE 
			BEGIN
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.ENCOMENDA(Número,Data,Endereço,Hora_Envio,Nome_Empresa,Nome_Cliente) VALUES (@Número,@Data,@Endereço,@Hora_Envio,@Nome_Empresa,@Nome_Cliente)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'A encomenda não foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
	END
GO

CREATE PROCEDURE PF.AdicionarEnvio(@Hora time(7), @Destino varchar(30), @Nº_de_encomendas int, @Nome_transportadora varchar(10))
AS
			BEGIN
			declare @erro varchar(100)
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.ENVIO(Hora, Destino, Nº_de_encomendas, Nome_transportadora) VALUES (@Hora, @Destino, @Nº_de_encomendas, @Nome_transportadora)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O envio não foi inserido, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
GO

CREATE PROCEDURE PF.AdicionarEncProd(@Codigo_Produto char(9), @Número_Encomenda int)
AS
			BEGIN
			declare @erro varchar(100)
				BEGIN TRY
					BEGIN TRAN
						INSERT INTO PF.possui(Codigo_Produto, Número_encomenda) VALUES (@Codigo_Produto, @Número_Encomenda)
					COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN
					SELECT @erro = ERROR_MESSAGE();
					SET @erro = 'O envio não foi inserido, algum valor inserido incorretamente'
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
					SET @erro = 'A encomenda não foi inserida, algum valor inserido incorretamente'
					RAISERROR (@erro, 16,1);
				END CATCH
			END
GO