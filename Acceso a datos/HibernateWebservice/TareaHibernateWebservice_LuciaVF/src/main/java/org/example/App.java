package org.example;

import com.google.gson.Gson;
import com.google.gson.JsonArray;
import com.google.gson.JsonObject;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.cfg.Configuration;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.URL;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * Hello world!
 *
 */
public class App 
{

    public static void main( String[] args )
    {

        HttpURLConnection connection = null;
        OutputStreamWriter wr = null;
        String line = null;

        try {
            // LLamar a API
            URL serverAddress = new URL("https://api.disneyapi.dev/characters");
            connection = (HttpURLConnection)serverAddress.openConnection();
            connection.setRequestMethod("GET");
            connection.setDoOutput(true);
            connection.setReadTimeout(10000);
            connection.connect();

            // Leer resultados API
            BufferedReader rd  = new BufferedReader(new InputStreamReader(connection.getInputStream()));
            StringBuilder sb = new StringBuilder();

            while ((line = rd.readLine()) != null)
            {
                sb.append(line);
            }

            // Formatear resultados API
            JsonObject objetoJson = new Gson().fromJson(sb.toString(), JsonObject.class);
            JsonArray resultados = objetoJson.get("data").getAsJsonArray();


            for (int i = 0; i< resultados.size(); i++){
                Character objetoCharacter = new Character(resultados.get(i).getAsJsonObject().get("_id").getAsInt(), resultados.get(i).getAsJsonObject().get("name").getAsString());
               // System.out.println(objetoCharacter);
                crearTablaCharacter(objetoCharacter);
                JsonArray resultadosTv = resultados.get(i).getAsJsonObject().get("tvShows").getAsJsonArray();
                for (int j=0;j< resultadosTv.size(); j++){
                    Tvshow objetoTv = new Tvshow(resultadosTv.get(j).getAsString(), objetoCharacter.getId());
                    crearTablaTvShow(objetoTv);

                }
            }


        } catch (MalformedURLException e) {
            e.printStackTrace();
        } catch (ProtocolException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally
        {
            connection.disconnect();
        }

    }
    public static void crearTablaCharacter(Character objetoCharacter){
        Session session = HibernateUtil.getSessionFactory().getCurrentSession();

        Transaction transaction = session.beginTransaction();
        session.save(objetoCharacter);
        transaction.commit();

        session.close();

    }
    public static void crearTablaTvShow(Tvshow objetoTv){

        Session session = HibernateUtil.getSessionFactory().getCurrentSession();

        Transaction transaction = session.beginTransaction();
        session.save(objetoTv);
        transaction.commit();

        session.close();
    }
}
