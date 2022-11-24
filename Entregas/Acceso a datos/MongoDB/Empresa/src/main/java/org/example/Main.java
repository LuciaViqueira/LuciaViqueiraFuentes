package org.example;

import com.mongodb.MongoClient;
import com.mongodb.client.MongoCollection;
import com.mongodb.client.MongoDatabase;
import org.bson.Document;

import java.util.List;

import static org.example.EmpleadoCRUD.*;


public class Main {
    public static void main(String[] args) {

        MongoClient cliente = null;


        try {
            cliente = new MongoClient("localhost", 27017);
            MongoDatabase conexion = cliente.getDatabase("empresa");
            MongoCollection<Document> colMongo = conexion.getCollection("empleados");

            //Insertar
            Empleado empleado1 = new Empleado("Lucía", 22, false, "2016-06-01", 2000.00);
            insertarEmpleado(colMongo, empleado1);

            Empleado empleado2 = new Empleado("Laura", 30, true, "2003-09-01", 920.00);
            insertarEmpleado(colMongo, empleado2);

            //Listar
            List<Empleado> empleados = listaEmpleados(colMongo);
            System.out.println("Lista de empleados");
            for(Empleado empleado:empleados){
                System.out.println(empleado.toString());
            }

            //Actuilizar
            empleado2.setEdad(21);
            actualizarEmpleado(colMongo, empleado2);

            //Consultar para comprobar que se hizo correctamente la actualización
            Empleado empleadoConsultado = consultarEmpleado(colMongo, "Laura");
            System.out.println("Empleado consultado" + empleadoConsultado.toString());

            //Eliminar
            eliminarEmpleado(colMongo, "Laura");

            //Listar todos los empleados
            empleados = listaEmpleados(colMongo);
            System.out.println("Lista empleados");
            for (Empleado empleado: empleados) {
                System.out.println(empleado.toString());
            }
        }catch (Exception e){
            e.printStackTrace();
        }finally {
            if(cliente !=null){
                cliente.close();
            }
        }

    }
}