/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [UsuarioId]
      ,[Usuario]
      ,[Clave]
  FROM [CAFETERIA].[dbo].[Login]




select usuario, clave from login where usuario = 'alex' and clave = '123'

exec insertar 500,'Susana','789'
exec listausuario

alter procedure Gerenciausuarios
@opcion int,
@id       int = 0,
@usuario  nvarchar(10) ='',
@clave	  varchar(50)= ''
 as 
 
 if @opcion = 1   -- insert
   begin
       insert into login values (@id, @usuario, @clave)
   end
   else if @opcion = 2 -- borrar
   begin 
       delete login where usuarioid=@id
   end
    else if @opcion = 3 -- Modificar
   begin 
       update  login set Usuario=@usuario, Clave=@clave where usuarioid=@id
   end

     if @opcion = 4 -- consulta con filtro
   begin
     select usuarioid, usuario, clave from login where usuarioid=@id
	 end
    if @opcion = 5 -- consulta general 5
   begin
     select usuarioid, usuario, clave from login 
   end

  Exec Gerenciausuarios 5,400



   
