CREATE FUNCTION fnEvenOdd(@n INT ) RETURNS VARCHAR(30)
AS
BEGIN
	DECLARE 
	   @res VARCHAR(30)
	   if @n%2 = 0
	   BEGIN
			SET @res = 'Even number'
	   END
	   ELSE 
	   BEGIN
			SET @res='Odd number'
	   END
	   RETURN @res
END


SELECT dbo.fnEvenOdd(234)
GO

