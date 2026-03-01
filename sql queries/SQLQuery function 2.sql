CREATE FUNCTION fact(@n INT) RETURNS INT
AS
BEGIN
	Declare
	   @f int,
	   @i int
	BEGIN
		SET @f = 1
		SET @i = 1
		WHILE @i <= @n
		BEGIN
			SET @f= @f*@i
			SET @i = @i+1
		END
	END
	RETURN @f
END
GO

SELECT dbo.fact(10)
GO


CREATE FUNCTION NCR(@n INT , @r INT) RETURNS INT
AS
BEGIN
	DECLARE 
	@res INT
	BEGIN
		SELECT @res=dbo.fact(@n)/(dbo.fact(@n-@r)*dbo.fact(@r))
	END
	RETURN @res
END

SELECT dbo.NCR(6,2)
GO