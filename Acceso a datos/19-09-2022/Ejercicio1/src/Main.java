import java.io.File;

public class Main {
    public static void main(String[] args) {

        //Carpeta1
        File fichero1 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\Directorio1");
        if (fichero1.exists()) {
            System.out.println("Ya existe " + fichero1.getName());
        } else {
            fichero1.mkdir();
        }

        //Fichero1 de la Carpeta1
        File archivo1 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\Directorio1\\fichero1.txt");
        if (archivo1.exists()) {
            System.out.println("Ya existe " + fichero1.getName());
        } else {
            try {
                archivo1.createNewFile();
            } catch (Exception e) {
                System.out.println("Error");
            }
        }
        //Fichero2 de la Carpeta1
        File archivo2 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\Directorio1\\fichero2.txt");
        if (archivo2.exists()) {
            System.out.println("Ya existe " + archivo2.getName());
        } else {
            try {
                archivo2.createNewFile();
            } catch (Exception e) {
                System.out.println("Error");
            }
        }

        //Carpeta2
        File fichero2 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\Directorio2");
        if (fichero2.exists()) {
            System.out.println("Ya existe " + fichero2.getName());
        } else {
            fichero2.mkdir();
        }

        //Fichero1 de la Carpeta2
        File archivo3 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\Directorio2\\fichero1.txt");
        if (archivo3.exists()) {
            System.out.println("Ya existe " + archivo3.getName());
        } else {
            try {
                archivo3.createNewFile();
            } catch (Exception e) {
                System.out.println("Error");
            }
        }
        
        //Fichero3
        File archivo4 = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio1\\fichero3.txt");
        if (archivo4.exists()) {
            System.out.println("Ya existe " + archivo4.getName());
        } else {
            try {
                archivo4.createNewFile();
            } catch (Exception e) {
                System.out.println("Error");
            }
        }

    }
}