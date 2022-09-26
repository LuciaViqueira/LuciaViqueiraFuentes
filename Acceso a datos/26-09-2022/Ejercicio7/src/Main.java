import java.io.*;
import java.util.ArrayList;
import java.util.Objects;

public class Main {
    public static void main(String[] args) {

        ArrayList<Persona> personas = new ArrayList<>();

        personas.add(new Persona("Lucia", "Viqueira", "09/09/2000"));
        personas.add(new Persona("Pablo", "Rodriguez", "17/07/2000"));
        personas.add(new Persona("Alejandra", "Regos", "03/07/2000"));
        personas.add(new Persona("Paula", "Sanchez", "12/11/2000"));

        //Escritua fichero


        File fic = new File("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\26-09-2022\\Ejercicio7\\escribir.txt");
        //Esta es la clase que apunta al fichero y se prepara para escribir
        FileOutputStream ficStream = null;
        //Le explica a la clase anterior como escribir sin explicar nada
        ObjectOutputStream ficObj = null;

        try{
            ficStream = new FileOutputStream(fic);
            ficObj = new ObjectOutputStream(ficStream);

            for(Persona persona: personas){
                //te va escribiendo cada persona del Array de Persona
                ficObj.writeObject(persona);
            }


        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try{
                if(ficStream !=null){
                    ficStream.close();

                }
                if(ficObj != null){
                    ficObj.close();
                }
            }catch (Exception e){
                e.printStackTrace();
            }
        }

        //Lectura de fichero

        FileInputStream fis = null;
        ObjectInputStream obis = null;

        try{
           fis = new FileInputStream ("C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\26-09-2022\\Ejercicio7\\escribir.txt");
           obis = new ObjectInputStream(fis);

           boolean continuar = true;
           while(continuar){
               try{
                   //Nos devuelve el objeto leido
                   Object obj = obis.readObject();
                   //El to String imprime todos los objetos
                   System.out.println(obj.toString());
               }catch (EOFException e){
                   continuar = false;
               }

           }

        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try {
                if(fis != null){
                    fis.close();
                }
                if(obis != null){
                    obis.close();
                }
            }catch (Exception e){
                e.printStackTrace();
            }

        }

    }
}