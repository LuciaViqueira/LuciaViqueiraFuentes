import java.io.*;
import java.nio.charset.StandardCharsets;

public class Main {
    public static void main(String[] args) {

        FileInputStream fis = null;
        FileOutputStream fos = null;
        InputStreamReader isr = null;
        OutputStreamWriter osw = null;

        try{

            String pathUTF8 = "C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\22-09-2022\\documentoUTF8.txt";
            String pathASCII = "C:\\Users\\FP\\Documents\\GitHub\\LuciaViqueiraFuentes\\Acceso a datos\\22-09-2022\\iso8859.txt";

            fis = new FileInputStream(pathUTF8);
            fos = new FileOutputStream(pathASCII);

            isr = new InputStreamReader(fis, StandardCharsets.UTF_8);
            osw = new OutputStreamWriter(fos, "ISO-8859-1");

            //para que lea el documento
            int data = isr.read();


            while(data != -1){
                //pasamos el int a char para que nos diga el caracter
                char caracter = (char) data;
                System.out.println(caracter);
                osw.write(caracter);
                data = isr.read();
            }


        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try{
                if(osw!=null) osw.close();
                if(fis!=null) fis.close();
                if(fos!=null) fos.close();
                if(isr!=null) isr.close();


            }catch (Exception e){
                e.printStackTrace();
            }
        }
    }
}