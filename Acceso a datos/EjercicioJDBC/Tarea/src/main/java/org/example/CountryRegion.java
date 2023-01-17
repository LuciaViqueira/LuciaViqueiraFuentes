package org.example;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import java.util.ArrayList;

public class CountryRegion {

    private String name;
    private String code;
    private ArrayList<State> state;

    public CountryRegion() {
    }

    public CountryRegion(String name, String code, ArrayList<State> state) {
        this.name = name;
        this.code = code;
        this.state = state;
    }

    public String getName() {
        return name;
    }
    @XmlAttribute (name="Name")
    public void setName(String name) {
        this.name = name;
    }

    public String getCode() {
        return code;
    }
    @XmlAttribute (name="Code")
    public void setCode(String code) {
        this.code = code;
    }

    public ArrayList<State> getState() {
        return state;
    }
    @XmlElement (name = "State")
    public void setState(ArrayList<State> state) {
        this.state = state;
    }

    @Override
    public String toString() {
        return "CountryRegion{" +
                "name='" + name + '\'' +
                ", code='" + code + '\'' +
                ", state=" + state +
                '}';
    }
}
