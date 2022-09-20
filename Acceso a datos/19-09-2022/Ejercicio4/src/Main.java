import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        FileReader fnotas = null;
        BufferedReader bnotas = null;
        try {

            fnotas = new FileReader("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\19-09-2022\\Ejercicio4\\notas.txt");
            //Lee el documento que le indicas en FileReader
            bnotas = new BufferedReader(fnotas);
            //Se usa para concatenar el texto
            StringBuilder leerFichero = new StringBuilder();
            //Lee el contenido que hay dentro del documento
            String contenido = bnotas.readLine();
            String todasLasNotas = new String();
            while (contenido != null) {
                //Concatenamos
                todasLasNotas = todasLasNotas + contenido;
                contenido = bnotas.readLine();

                //Crea un array de strings y para hacer la media usamos el split para que sepa hasta
                //donde va una nota en este caso hasta que encuentre un |
                String []notas = todasLasNotas.toString().split("[|]");
                double media = 0.0;

                for (String nota:notas){
                    media+=Double.parseDouble(nota);
                }

                media = media/notas.length;

                System.out.println(media);
            }
        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try{
                if(fnotas != null)fnotas.close();
                if(bnotas != null) bnotas.close();
            }catch (Exception e){
                e.printStackTrace();
            }
        }


    }
}