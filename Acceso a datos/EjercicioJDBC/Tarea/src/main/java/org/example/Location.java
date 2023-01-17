package org.example;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.ArrayList;

@XmlRootElement(name="Location")
public class Location {

        private ArrayList<CountryRegion> countryRegion;

    public Location() {
    }

    public Location(ArrayList<CountryRegion> countryRegion) {
        this.countryRegion = countryRegion;
    }

    public ArrayList<CountryRegion> getCountryRegion() {
        return countryRegion;
    }
    @XmlElement(name = "CountryRegion")
    public void setCountryRegion(ArrayList<CountryRegion> countryRegion) {
        this.countryRegion = countryRegion;
    }

    @Override
    public String toString() {
        return "Location{" +
                "countryRegion=" + countryRegion +
                '}';
    }
}
