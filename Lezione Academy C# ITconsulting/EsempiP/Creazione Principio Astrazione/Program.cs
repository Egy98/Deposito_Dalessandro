﻿// Classe astratta
public abstract class Veicolo
{
public abstract void Avvia();
}

// Classe concreta che eredita dalla classe astratta
public class Auto : Veicolo
{
public override void Avvia()
{
Console.WriteLine("L'auto si accende.");
}
}

// Interfaccia
public interface IVeicoloElettrico
{
void Ricarica();
}

// Classe che implementa l'interfaccia
public class ScooterElettrico : IVeicoloElettrico
{
public void Ricarica()
{
Console.WriteLine("Scooter in carica.");
}
}

public class Programma
{
public static void Main()
{
Veicolo miaAuto = new Auto();
miaAuto.Avvia();

IVeicoloElettrico mioScooter = new ScooterElettrico();
mioScooter.Ricarica();
}
}