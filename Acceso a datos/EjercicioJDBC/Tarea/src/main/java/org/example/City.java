package org.example;

import javax.xml.bind.annotation.XmlAttribute;

public class City {

    private String name;
    private String code;

    public City() {
    }

    public City(String name, String code) {
        this.name = name;
        this.code = code;
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
    @XmlAttribute(name="Code")
    public void setCode(String code) {
        this.code = code;
    }

    @Override
    public String toString() {
        return "City{" +
                "Name='" + name + '\'' +
                ", Code='" + code + '\'' +
                '}';
    }
}
