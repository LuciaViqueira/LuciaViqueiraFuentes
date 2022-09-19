import java.io.FileInputStream;

public class Main {
    public static void main(String[] args) {
        FileInputStream fichero = null;

        try {
            fichero = new FileInputStream("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio2\\fichero.txt");

            String leerDecimal = new String("");
            String leerHexadecimal = new String("");
            String leerCaracteres = new String("");

            int lectura = fichero.read();

            while (lectura != -1) {
                //Lee el texto y lo pasa a numeros decimales
                leerDecimal = leerDecimal + lectura + "-";
                //Lee el texto y lo pasa a numeros hexadecimal
                leerHexadecimal = leerHexadecimal + Integer.toHexString(lectura) + "-";
                //Lee el texto y te va diciendo caracter a caracter
                leerCaracteres = leerCaracteres + (char) lectura + "-";

                lectura = fichero.read();

            }

            System.out.println(leerDecimal);
            System.out.println(leerHexadecimal);
            System.out.println(leerCaracteres);

        } catch (Exception e) {
            System.out.println("Error");

          // Aunque haya un error en el try, el finally siempre se ejecuta
        } finally {
            try {
                if(fichero !=null) fichero.close();
            }catch (Exception e){
                e.printStackTrace();
            };
        }

    }
}