package org.example;

import javax.xml.bind.annotation.XmlElement;
import java.util.ArrayList;

public class State {

    private ArrayList<City> city;

    public State() {
    }

    public State(ArrayList<City> city) {
        this.city = city;
    }

    public ArrayList<City> getCity() {
        return city;
    }
    @XmlElement (name = "City")
    public void setCity(ArrayList<City> city) {
        this.city = city;
    }

    @Override
    public String toString() {
        return "State{" +
                "city=" + city +
                '}';
    }
}
