package com.Lista1;

import java.util.ArrayList;
import java.util.Scanner;

public class Kolekcja {
    private String nazwaKolekcji;
    private ArrayList<PlytaCD> plyty;

    public Kolekcja(
            String nazwaKolekcji
    ) {
        setNazwaKolekcji(nazwaKolekcji);
        plyty = new ArrayList<PlytaCD>();
    }

    public String getNazwaKolekcji() {return this.nazwaKolekcji;}
    public ArrayList<PlytaCD> getPlyty() {return this.plyty;}

    public void setNazwaKolekcji(String nazwaKolekcji) {
        try {
            this.nazwaKolekcji = nazwaKolekcji;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }

    public void setPlyta(PlytaCD plyta, int numer) {
        if (numer > this.plyty.size()){
            throw new ArrayIndexOutOfBoundsException("CD not found.");
        }

        this.plyty.set(numer, plyta);
    }

    public void addPlyta(PlytaCD plyta) {
        if (this.plyty.size() > 10){
            throw new UnsupportedOperationException("Collection size can't be greater than 10 elements.");
        }

        this.plyty.add(plyta);
    }

    public void wyswietlPlyty(){
        for (int i = 0; i < plyty.size(); i++){
            System.out.format("Płyta nr: %d \n", i);
            plyty.get(i).wyswietlPlyte();
        }
    }

    public void szykajWykonawcyUtworu(){
        Scanner skaner = new Scanner(System.in);
        String tekst;
        System.out.print("Podaj nazwę wykonawcy: ");
        tekst = skaner.nextLine();

        for (int i=0; i< plyty.size(); i++){
            for (int j=0; j < plyty.get(i).getUtwory().size(); j++){
                if (plyty.get(i).getUtwory().get(j).getWykonawca().equals(tekst)){
                    plyty.get(i).wyswietlPlyte();
                }
            }
        }
        // wypisz tytuły płyt z wykonawcą
    }
}
