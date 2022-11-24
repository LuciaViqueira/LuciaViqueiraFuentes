package org.example;

import com.mongodb.client.MongoCollection;
import com.mongodb.client.model.Filters;
import org.bson.Document;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class EmpleadoCRUD {

    private static Document empleadoADoc (Empleado empleado){
        Document documento = null;
        if(empleado != null){
            documento = new Document();
            documento.put("nombre", empleado.getNombre());
            documento.put("edad", empleado.getEdad());
            documento.put("contrato fijo", empleado.isContratoFijo());
            documento.put("alta", empleado.getAlta());
            documento.put("sueldo", empleado.getSueldo());
        }
        return documento;
    }

    private static Empleado docAEmpleado (Document documento){
        Empleado empleado = null;

        if(documento != null){
            empleado = new Empleado();
            empleado.setNombre(documento.getString("nombre"));
            empleado.setEdad(documento.getInteger("edad"));
            empleado.setContratoFijo(documento.getBoolean("contrato fijo"));
            empleado.setAlta(documento.getString("alta"));
            empleado.setSueldo(documento.getDouble("sueldo"));
        }
        return empleado;
    }
    //Operaciones

    public static Empleado consultarEmpleado(MongoCollection<Document> mongodb, String nombre) {
        Document documento = mongodb.find(Filters.eq("nombre", nombre)).first();
        return docAEmpleado(documento);
    }

    public static List<Empleado> listaEmpleados(MongoCollection<Document> mongodb) {

        List<Empleado> empleados = new ArrayList<>();

        List<Document> documentos = mongodb.find().into(new ArrayList<Document>());

        Empleado empleado;

        for (Document documento : documentos) {
            empleado = docAEmpleado(documento);
            empleados.add(empleado);

        }
        return empleados;
    }
    static void insertarEmpleado(MongoCollection<Document> colMongo, Empleado empleado){
        Document documento = empleadoADoc(empleado);

        try{
            if(consultarEmpleado(colMongo, empleado.getNombre())==null){
                colMongo.insertOne(documento);
            }else{
                System.out.println("ERROR: No se pudo instertar " + empleado.getNombre() + " ya existe");
            }
        }catch (Exception e){
            e.printStackTrace();
        }
    }

    public static void actualizarEmpleado(MongoCollection<Document> colMongo, Empleado empleado){
        Document documento = empleadoADoc(empleado);
        try {
            colMongo.replaceOne(Filters.eq("nombre", empleado.getNombre()), documento);
        }catch (Exception e){
            e.printStackTrace();
        }
    }
    public static void eliminarEmpleado(MongoCollection<Document> colMongo, String nombre){
        try{
            colMongo.deleteOne(Filters.eq("nombre", nombre));
        }catch (Exception e){
            e.printStackTrace();
        }
    }

}
