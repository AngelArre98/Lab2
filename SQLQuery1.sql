create table video ( Idvideo int primary key,
titulo varchar(100),
repro int,
url varchar(100))

----------------
create procedure sp_video_insertar

@Idvideo int, @titulo varchar(100), @repro int, @url varchar(100)
as
begin
insert into video values (@Idvideo,@titulo,@repro,@url)
end

exec sp_video_insertar 1,'video 1' ,1,'youtube.com'

-------
create procedure sp_eliminar
@IdVideo int
as
begin
delete from video where Idvideo = @IdVideo
end
----
create procedure sp_edit
@Idvideo int, @titulo varchar(100), @repro int, @url varchar(100)
as
begin

update video set Idvideo = @Idvideo, titulo = @titulo, repro = @repro, url = @url where Idvideo = @Idvideo
end
----

create procedure sp_mostrar
as
begin
Select*from video;
end

exec sp_mostrar
-------------------


select * from video



