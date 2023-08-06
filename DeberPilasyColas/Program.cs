using DeberPilasyColas;


Stack<Alumno> alumnos = new Stack<Alumno>();
alumnos.Push(new Alumno
{ 
    Id = 1, 
    Name = "Ana Maria", 
    LastName = "Caceres", 
    Edad = 23,
    FechaRegistro = "20 Febrero 2023"
});
alumnos.Push(new Alumno
{
    Id= 2,
    Name = "Maria",
    LastName = "Lazo",
    Edad = 19,
    FechaRegistro = "01 Marzo 2023"
});
alumnos.Push(new Alumno
{
    Id = 3,
    Name = "Jackeline",
    LastName = "Criollo",
    Edad = 25,
    FechaRegistro = "25 Marzo 2023"
});
alumnos.Push(new Alumno
{
    Id = 4,
    Name = "Maikel",
    LastName = "Sanchez",
    Edad = 22,
    FechaRegistro = "20 Mayo 2023"
});
Console.WriteLine("=============== LISTA DE ALUMNOS REGITRADOS =================");
Console.WriteLine("\nLa cantidad de alumnos que estan aplicando son: " + alumnos.Count); // Esta funcion muestra cuantos elementos estan en la pila
Console.WriteLine("\nEl ultimo alumno ingresad0 es: " +alumnos.Peek().Name +" "+ alumnos.Peek().LastName); //Se muestra el nombre y apellido del alumno que se registro al ultimo
Console.WriteLine("\nLa fecha de ingreso es: " + alumnos.Peek().FechaRegistro); // Se muestra la fecha de ingreso
Console.WriteLine("\nSu numero de ID es: " + alumnos.Peek().Id); // Se muestra el ID del alumno
Console.WriteLine("\nEl estudiante: " +alumnos.Peek().Name + " " +alumnos.Peek().LastName  + " a sido APROBADO");
Console.WriteLine("\nEl estudiante: " + alumnos.Pop().Name +" ha sido eliminado de la lista de espera"); // Lee y elimina 
Console.WriteLine("\nEl siguiente estudiante es: " + alumnos.Peek().Name +" " +alumnos.Peek().LastName +" en la lista de espera, con ID numero: " +alumnos.Peek().Id);
Console.WriteLine("\nEl estudiante: " + alumnos.Pop().Name +" ha sido aprobado y ya no se encuentra en lista de espera");
Console.WriteLine("\nLa cantidad de alumnos en espera son: " +alumnos.Count);