import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        FileInputStream fichero =  new FileInputStream("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio3\\fichero.txt");
        FileOutputStream escribirFichero = new FileOutputStream( "C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio3\\fichero2.txt");

        try {

            String leerDecimal = new String("");

            int lectura = fichero.read();


            while (lectura != -1) {

                escribirFichero.write(lectura);
                lectura = fichero.read();


            }

            System.out.println(leerDecimal);


        } catch (Exception e) {
            System.out.println("Error");

            // Aunque haya un error en el try, el finally siempre se ejecuta
        } finally {
            try {
                if (fichero != null) fichero.close();
                if (escribirFichero != null) escribirFichero.close();
            } catch (Exception e) {
                e.printStackTrace();
            }
            ;
        }

    }
}