create DataBase Peliculas;
go

use Peliculas;
go

create table Categoria
(
	CategoriaId int primary key identity(1,1),
	Descripcion varchar(50)
);
go