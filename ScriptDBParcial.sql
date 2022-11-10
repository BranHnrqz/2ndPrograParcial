Create Database RegistroNotas
use RegistroNotas

Create Table Estudiantes
(
id int primary key NOT NULL,
nombre varchar (50),
Apellido varchar (50),
Carrera varchar (50),
Asignatura varchar (50),
Promedio1 float NOT NULL,
Promedio2 float NOT NULL,
Promedio3 float NOT NULL,
PromedioFinal float NOT NULL,
)

insert into Estudiantes (id, nombre, Apellido, Carrera, Asignatura , Promedio1, Promedio2, Promedio3, PromedioFinal)
Values (1, 'Brandon', 'Henriquez' , 'Ingenieria' , 'Programacion 2' , 10 , 10 , 10 , 10)
