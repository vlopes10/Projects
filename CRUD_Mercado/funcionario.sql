/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT TOP 1000 [ID_FUN]
      ,[NOME]
      ,[CARGO]
      ,[IDADE]
      ,[ENDERECO]
      ,[EMAIL]
      ,[CPF]
      ,[TELEFONE]
      ,[UF]
      ,[CEP]
      ,[CIDADE]
  FROM [66873].[Douglas].[FUNCIO]
  
  insert into Douglas.FUNCIO(ID_FUN,NOME,CARGO,IDADE,ENDERECO,EMAIL,CPF,TELEFONE,UF,CEP,CIDADE) values(1,'Eduarda Rosa','Gerente',22,'Rua Tu','dudarosa32@yahoo.com.br',14568756423,52446987,'Maranhão')