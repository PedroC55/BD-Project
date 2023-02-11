
CREATE FUNCTION PF.VerificarCC(@N�_CC char(8)) RETURNS INT
AS
	BEGIN
		DECLARE @count	INT
		SELECT @count=COUNT(1) FROM PF.CLIENTE WHERE N�_CC=@N�_CC
		RETURN @COUNT
	END
GO


CREATE FUNCTION PF.VerificarCodigo(@C�digo char(9)) RETURNS INT
AS
	BEGIN
		DECLARE @count	INT
		SELECT @count=COUNT(1) FROM PF.PRODUTO WHERE C�digo=@C�digo
		RETURN @COUNT
	END
GO

select * from PF.PRODUTO

CREATE FUNCTION PF.VerificarN�mero(@N�mero int) RETURNS INT
AS
	BEGIN
		DECLARE @count	INT
		SELECT @count=COUNT(1) FROM PF.ENCOMENDA WHERE N�mero=@N�mero
		RETURN @COUNT
	END
GO