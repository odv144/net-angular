﻿using ProyectoClases.Clases;

#region Ejercicio 1 de la guia 2
/*
Ejercicios ObjEjercicio = new Ejercicios();
Console.WriteLine(ObjEjercicio.EvaluarNro());
ObjEjercicio.Par();
Console.WriteLine(ObjEjercicio.Ejercicio3());
Console.WriteLine(ObjEjercicio.Ejercicio4());
Console.WriteLine(ObjEjercicio.Ejercicio5());
ObjEjercicio.Ejercicio6();
ObjEjercicio.Ejercicio7();
ObjEjercicio.Ejercicio8();
Console.WriteLine(ObjEjercicio.Ejercicio9());
ObjEjercicio.Ejercicio10();
Console.WriteLine(ObjEjercicio.Ejercicio11());
Console.WriteLine(ObjEjercicio.Ejercicio12());
ObjEjercicio.Ejercicio13();
ObjEjercicio.Ejercicio14();
ObjEjercicio.Ejercicio15();
*/
#endregion

#region Ejercicio 2 de la guia 2
/*
var Obj = new Cuadrado();
Console.WriteLine("Ingrese el valor del lado del cuadrado a calcular");
Double.TryParse(Console.ReadLine(), out Double nro);
Console.WriteLine((Obj.Area(nro)).ToString());
*/
#endregion

#region Ejercicio 3 dde la guia 2
/*
Persona usuario = new Persona();
Console.WriteLine(usuario.NombreCompleto("Omar","Virili"));
*/
#endregion

#region Ejercicio 4 de la guia 2
/*
Persona usuario = new Persona();
usuario.setFechaNac(new DateTime(1984, 02, 28));
Console.WriteLine($"Edad del usuario: {usuario.getFechaNac()}");
*/
#endregion

#region Ejercicio 5 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo",5);
Console.WriteLine(coche.Encender());
Console.WriteLine(coche.Apagar());
*/
#endregion

#region Ejercicio 6 de la guia 2
/*
Mascota animal = new Mascota("Uma",0);
Console.WriteLine(animal.nombre);
Console.WriteLine(animal.tipo);
animal.alimentar();
Console.WriteLine(animal.energia);
animal.alimentar();
Console.WriteLine(animal.energia);
for(int i = 0; i < 10; i++)
{
    animal.alimentar();
    Console.WriteLine(animal.energia);
}
*/

#endregion

#region Ejercicio 7 de la guia 2
/*
Mascota animal = new Mascota("Uma", 0);
while(animal.energia<100)
{
    animal.alimentar();
    Console.WriteLine(animal.energia);
}

while (animal.energia>20)
{
    animal.correr();
    Console.WriteLine(animal.energia);
}
*/

#endregion

#region Ejercicio 8 de la guia 2
/*
Smartphone celu = new Smartphone("LG", "K50");
Console.WriteLine($"Marca: {celu.marca}, Modelo:{celu.modelo}");
celu.encender();
for(int i = 0; i < 10; i++)
{
celu.subirVolumen();

}
for (int i = 0; i < 10; i++)
{

celu.subirBrillo();
}
for (int i = 0; i < 10; i++)
{

celu.bajarVolumen();
}
for (int i = 0; i < 10; i++)
{

celu.bajarBrillo();
}
celu.mute();
celu.mute();
*/

#endregion

#region Ejercicio 9 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo",5);
coche.Conductor = new Persona("Omar Dario","Virili",new DateTime(1984, 02, 28));
coche.AsignarConductor();
coche.Encender();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.frenar();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.frenar();


Console.WriteLine($"Velocidad: {coche.getVelocidad()}");
Console.WriteLine($"Aceleracion: {coche.getAceleracion()}");

Console.WriteLine(coche.Apagar());

*/
#endregion

#region Ejercicio 10 de la guia 2
/*
DateTime naci = new DateTime(1984, 02, 28);
Smartphone celu = new Smartphone("Samsung", "J2");
Persona cliente = new Persona("Omar Dario","Virili",naci,celu);
cliente.MostrarDatos();
*/

#endregion

#region Ejercicio 11 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo",5);

coche.AsignarConductor();
Console.WriteLine(coche.Encender());
Console.WriteLine(coche.Apagar());
*/
#endregion

#region Ejercicio 12 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo",5);
//coche.Pasajeros = 2;
coche.AsignarPasajero(3);
*/

#endregion

#region Ejercicio 13 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo",5);
Mascota animal = (new Mascota("Tilin", Mascota.TipoAnimal.perro));

coche.AsignarConductor();
coche.AsignarPasajero(4);
Console.WriteLine("Cantidad de pasajeros actuales "+coche.Pasajeros);
animal.Tamanio = "chico"; //cualquier tamaño distinto a chico usa un lugar
Console.WriteLine(coche.LlevarMascota(animal));
//Tarea: Hacer el cambio de regazo de la mascota eh implementar lo del tamaño del animal
coche.CambiarLugarMascota(2);
Console.WriteLine($"La mascota esta en el regazo de: {coche.UbiMascota()}");
*/
#endregion

#region Ejercicio 14 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo", 5);
coche.AsignarConductor();
coche.AsignarPasajero(4);
coche.Encender();
coche.acelerar();
coche.acelerar();
coche.BajarPasajeros(2);
coche.frenar(); 
coche.BajarPasajeros(2);
coche.Apagar();
coche.BajarConductor();
*/
#endregion

#region Ejercicio 15 de la guia 2
/*
Estudiante student = new Estudiante();
student.AgregarLibro("El cerebro del Futuro", "Facundo Manes", 300, true);
student.AgregarLibro("El cerebro del Futuro2", "Facundo Manes", 200, false);
student.AgregarLibro("El cerebro del Futuro3", "Facundo Manes", 100, true);
student.AgregarLibro("El cerebro del Futuro4", "Facundo Manes", 500, false);
student.LibrosLeidos();
student.QuitarLibro(2);
student.LibrosLeidos();
Console.WriteLine("Cantidad de paginas leidas en total: "+ student.SumaLeido());
Console.WriteLine("Cantidad libros sin leer: " + student.SinLeer());
*/
#endregion