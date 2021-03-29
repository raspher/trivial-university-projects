package com.Lista1;

import java.util.ArrayList;

public class PlytaCD {
    private String tytul, wykonawca, wydawca;
    private int rokWydania;
    private float cena;
    private ArrayList<Utwor> utwory = new ArrayList<Utwor>();

    public PlytaCD(
            String tytul,
            String wykonawca,
            String wydawca,
            int rokWydania,
            float cena
    ) {
        setTytul(tytul);
        setWykonawca(wykonawca);
        setWydawca(wydawca);
        setRokWydania(rokWydania);
        setCena(cena);
    }

    // getters
    public String getTytul()        {return this.tytul;}
    public String getWykonawca()    {return this.wykonawca;}
    public String getWydawca()      {return this.wydawca;}
    public int getRokWydania()      {return this.rokWydania;}
    public float getCena()          {return this.cena;}
    public ArrayList<Utwor> getUtwory() {return this.utwory;}

    // setters
    public void setTytul(String nowyTytul){
        try {
            this.tytul = nowyTytul;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setWykonawca(String nowyWykonawca){
        try {
            this.wykonawca = nowyWykonawca;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setWydawca(String nowyWydawca){
        try {
            this.wydawca = nowyWydawca;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setRokWydania(int nowyRokWydania){
        try {
            this.rokWydania = nowyRokWydania;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setCena(float nowaCena){
        try {
            this.cena = nowaCena;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void addUtwor(Utwor utwor) {
        if (this.utwory.size() >= 10){
            throw new UnsupportedOperationException("Tracks size can't be greater than 10 elements.");
        }

        this.utwory.add(utwor);
    }
    public void setUtwor(Utwor utwor, int numer) {
        if (numer > this.utwory.size()){
            throw new ArrayIndexOutOfBoundsException("Track not found");
        }

        this.utwory.set(numer, utwor);
    }

    // wyświetlanie
    public void wyswietlPlyte(){
        System.out.println("===========================");
        System.out.format("Nazwa płyty: %s \n", tytul);
        System.out.format("Wykonawca: %s \n", wykonawca);
        System.out.format("Wydawca: %s \n", wydawca);
        System.out.format("Rok wydania: %d \n", rokWydania);
        System.out.format("Cena: %.2f \n", cena);
        System.out.println("===========================");
    }

    public void wyswietlUtwory(){
        for(int i=0; i < utwory.size(); i++){
            System.out.println("---------------------------");
            System.out.format("Utwór nr: %d \n", i);
            System.out.format("Autor: %s \n", utwory.get(i).getAutor());
            System.out.format("Wykonawca: %s \n", utwory.get(i).getWykonawca());
            System.out.format("Czas trwania: %d sekund \n", utwory.get(i).getCzasTrwania());
            System.out.println("---------------------------");
        }
    }
}
