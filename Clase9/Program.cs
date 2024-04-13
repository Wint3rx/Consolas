using Clase9.ClaseHija;

Nintendo nintendo = new Nintendo();
nintendo.aniolanzamiento = 2017;
nintendo.esportable = true;
nintendo.marca = "Switch";
Console.WriteLine(nintendo.mostrardetallenintendo());

//instancia de ps1
Playstation playstation = new Playstation();
playstation.marca = "Playstation 1";
playstation.aniolanzamiento = 1994;
playstation.modelocontrolador = "DualSence";
Console.WriteLine($"{playstation.mostrardetallesplay()}");

Xbox xbox = new Xbox();
xbox.marca = "Xbox One Series X";
xbox.aniolanzamiento = 2020;
xbox.compatibilidadpc = true;
Console.WriteLine($"{xbox.Mostrarcompatibilidad()}");

SegaDreamCast segaDreamCast = new SegaDreamCast();
segaDreamCast.marca = "SegaDreamCast";
segaDreamCast.aniolanzamiento = 1990;
segaDreamCast.pantallaenjoystick =  true;
Console.WriteLine($"{segaDreamCast.MostrarPantalla()}");