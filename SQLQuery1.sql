create table video ( Idvideo int primary key,
titulo varchar(100),
repro int,
url varchar(100))


create procedure sp_video_insertar

@Idvideo int, @titulo varchar(100), @repro int, @url varchar(100)
as
begin
insert into video values (@Idvideo,@titulo,@repro,@url)
end

exec sp_video_insertar 1,'video 1' ,1,'youtube.com'

select * from video

