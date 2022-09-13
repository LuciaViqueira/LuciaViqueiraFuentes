package org.example;

import java.util.Scanner;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args )
    {
        Scanner teclado = new Scanner(System.in);
        int elfos;
        int enanos;
        int camas;

        System.out.println("Introduce el numero de elfos");
        elfos = teclado.nextInt();
        System.out.println("Introduce el numero de enanos");
        enanos = teclado.nextInt();
        System.out.println("Introduce el numero de camas para la posada");
        camas = teclado.nextInt();

        System.out.println(comprobarHabitaciones(elfos, enanos, camas));

    }
    public static int comprobarHabitaciones(int elfos, int enanos, int camas){

        int habitacionelfos = 0;
        int habitacionesenanos = 0;
        int habitaciontotal = 0;

        habitacionelfos = elfos/camas;
        habitacionesenanos = enanos/camas;

        habitaciontotal = habitacionelfos + habitacionesenanos;
        return habitaciontotal;

    }
}
