-- create database Universidad3;
CREATE TABLE alumnos (
    AlumnoID INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    FechaNacimiento VARCHAR(10),
    Correo VARCHAR(100)
);

INSERT INTO alumnos (AlumnoID, Nombre, Apellido, FechaNacimiento, Correo)
VALUES 
(100001, 'Juan', 'Pérez', '2000-01-15', 'juan.perez@example.com'),
(100002, 'María', 'González', '1999-03-22', 'maria.gonzalez@example.com'),
(100003, 'Luis', 'Martínez', '2001-07-10', 'luis.martinez@example.com'),
(100004, 'Ana', 'López', '2002-11-05', 'ana.lopez@example.com'),
(100005, 'Carlos', 'Rodríguez', '2000-06-18', 'carlos.rodriguez@example.com'),
(100006, 'Laura', 'Hernández', '1998-12-24', 'laura.hernandez@example.com'),
(100007, 'José', 'Sánchez', '2001-08-09', 'jose.sanchez@example.com'),
(100008, 'Elena', 'Ramírez', '2000-04-30', 'elena.ramirez@example.com'),
(100009, 'Miguel', 'Torres', '1999-09-17', 'miguel.torres@example.com'),
(100010, 'Sara', 'Flores', '2002-05-13', 'sara.flores@example.com'),
(100011, 'David', 'García', '2001-02-25', 'david.garcia@example.com'),
(100012, 'Lucía', 'Vázquez', '1998-07-01', 'lucia.vazquez@example.com'),
(100013, 'Pablo', 'Morales', '2000-10-20', 'pablo.morales@example.com'),
(100014, 'Isabel', 'Reyes', '2001-03-11', 'isabel.reyes@example.com'),
(100015, 'Andrés', 'Ortega', '1999-11-28', 'andres.ortega@example.com');


