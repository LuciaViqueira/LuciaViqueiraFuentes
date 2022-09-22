import java.io.RandomAccessFile;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        ArrayList<Alumnos>alumnos = new ArrayList<>();

        alumnos.add(new Alumnos("Lucia     ", 22, 10));
        alumnos.add(new Alumnos("Pablo     ", 22, 7));
        alumnos.add(new Alumnos("Marcos    ", 31, 7.5));
        alumnos.add(new Alumnos("Nestor    ", 20, 6));

        RandomAccessFile raf = null;

        try{
            raf = new RandomAccessFile("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\22-09-2022\\Ejercicio6\\documento.txt" , "rw");


            //alumnos es el array que recorremos, Alumnos es de donde lo lee, alumno es una variabel por la cual pasan los datos del alumno
            for(Alumnos alumno:alumnos){
                raf.writeChars(alumno.nombre);
                raf.writeInt(alumno.edad);
                raf.writeDouble(alumno.media);
            }
            //Como mi nombre ocupa 10 caracteres mas la edad mas el double da 32 osea que vamos al segundo nombre ya que el primero empieza en 0
            raf.seek(32);

            String nombre ="";
            for (int i=0; i<10; i++){
                nombre+=raf.readChar();
            }
            
            raf.readInt();
            raf.readDouble();


        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try{

            }catch (Exception e){
                e.printStackTrace();
            }
        }

    }
}