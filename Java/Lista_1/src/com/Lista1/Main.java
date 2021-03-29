/*
** Author: Szymon Scholz
 */
package com.Lista1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Map;
import java.util.Objects;

public class Main {
    static InputStreamReader strumien = new InputStreamReader(System.in);
    static BufferedReader bufor = new BufferedReader(strumien);
    static ArrayList<Kolekcja> kolekcje = new ArrayList<Kolekcja>();
    static int idKolekcji = 0, idPlyty = 0, idUtworu = 0;

    public static void main(String[] args) throws IOException {
        String tekst;

        while (true){
            System.out.println("========= Lista 1 =========");
            System.out.println("1: Zadanie 1 - Kalkulator średniej");
            System.out.println("2: Zadanie 2");
            System.out.println("3: Zadanie 3");
            System.out.println("0: Koniec \n");
            System.out.print("Wybierz zadanie: ");

            try {
                tekst = bufor.readLine();
            }
            catch (IOException e){
                e.printStackTrace();
                return;
            }
            System.out.println(tekst);
            if (tekst.equals("1")) zadanie1();
            if (tekst.equals("2")) zadanie2();
            if (tekst.equals("3")) zadanie3();
            if (tekst.equals("0")) return;
        }

    }

    public static void zadanie1() {
        float ocena = 0, waga = 0, sumaOcenXWag = 0, sumaWag = 0;
        String menu;

        while (true){
            System.out.println("========= Kalkulator średniej =========");
            System.out.println("1: Dodaj ocenę");
            System.out.println("2: Wylicz średnią");
            System.out.println("3: Wyczyść dane");
            System.out.println("0: Powrót do menu \n");
            System.out.print("Wybierz opcję: ");

            try {
                menu = bufor.readLine();
            }
            catch (IOException e){
                e.printStackTrace();
                return;
            }

            if (menu.equals("1")) {
                System.out.print("Ocena: ");
                try {
                    ocena = Float.parseFloat(bufor.readLine());
                }
                catch (Exception e){
                    e.printStackTrace();
                    return;
                }

                System.out.print("Waga: ");
                try {
                    waga = Float.parseFloat(bufor.readLine());
                }
                catch (Exception e){
                    e.printStackTrace();
                    return;
                }

                sumaOcenXWag += ocena*waga;
                sumaWag += waga;
            }
            if (menu.equals("2")) {
                System.out.println("Twoja średnia: " + sumaOcenXWag/sumaWag);
            }
            if (menu.equals("3")) {
                sumaOcenXWag = 0;
                sumaWag = 0;
            }
            if (menu.equals("0")) return;
        }
    }

    public static void zadanie2() {
        float wynik = 0;
        int n;
        String menu;

        System.out.println("========= Kalkulator Ciągu =========");
        System.out.println("1: Policz ciąg");
        System.out.println("0: Powrót do menu \n");
        System.out.print("Wybierz opcję: ");

        try {
            menu = bufor.readLine();
        }
        catch (IOException e){
            e.printStackTrace();
            return;
        }

        if (menu.equals("1")) {
            System.out.print("Podaj \"n\": ");
            try {
                n = Integer.parseInt(bufor.readLine());
            }
            catch (Exception e){
                e.printStackTrace();
                return;
            }

            for (int i = 1; i <= n; i++) {
                if (i % 2 == 1) {
                    wynik+=1/(i+n);
                } else {
                    wynik-=1/(i+n);
                }
            }
        }

        if (menu.equals("0")) return;
    }


    public static void zadanie3() {
        String menu;

        while (true){
            System.out.println("========= Menedzer płyt cd =========");
            System.out.println("1: Wyświetl kolekcje");
            System.out.println("2: Wybierz kolekcje");
            System.out.println("3: Utwórz kolekcje");
            System.out.println("4: Szukaj wykonawcy");
            System.out.println("0: Powrót do menu \n");
            System.out.print("Wybierz opcję: ");

            try {
                menu = bufor.readLine();
            }
            catch (IOException e){
                e.printStackTrace();
                return;
            }

            if (menu.equals("1")) {
                for (int i = 0; i < kolekcje.size(); i++){
                    System.out.format("Kolekcja nr: %d \n", i);
                    System.out.format("Nazwa kolekcji: %s \n", kolekcje.get(i).getNazwaKolekcji());
                }
            }
            if (menu.equals("2")) {
                int idKol;
                System.out.println("========= Wybierz kolekcje =========");
                System.out.print("Podaj id kolekcji: ");
                try {
                    idKol = Integer.parseInt(bufor.readLine());
                }
                catch (IOException e){
                    e.printStackTrace();
                    return;
                }
                obslugaKolekcja(idKol);
            }

            if (menu.equals("3")) {
                String nazwaKolekcji;
                System.out.println("========= Dodawanie kolekcji =========");
                System.out.print("Podaj nazwę kolekcji: ");
                try {
                    nazwaKolekcji = bufor.readLine();
                    kolekcje.add(new Kolekcja(nazwaKolekcji));
                }
                catch (IOException e){
                    e.printStackTrace();
                    return;
                }
            }
            if (menu.equals("4")) {
                kolekcje.get(0).szykajWykonawcyUtworu();
            }
            if (menu.equals("0")) {
                break;
            }
        }
    }

    static void obslugaKolekcja(int nrKol){
        String menu;
        while (true) {
            System.out.format("========= Kolekcja %s ========= \n", kolekcje.get(nrKol).getNazwaKolekcji());
            System.out.println("1: Wyświetl płyty");
            System.out.println("2: Wybierz płytę");
            System.out.println("3: Utwórz płytę");
            System.out.println("0: Powrót do menu kolekcji \n");
            System.out.print("Wybierz opcję: ");
            try {
                menu = bufor.readLine();
            } catch (IOException e) {
                e.printStackTrace();
                return;
            }

            if (menu.equals("1")) {
                System.out.format("Kolekcja nr: %d \n", nrKol);
                System.out.format("Nazwa kolekcji: %s \n", kolekcje.get(nrKol).getNazwaKolekcji());
                kolekcje.get(nrKol).wyswietlPlyty();
            }

            if (menu.equals("2")) {
                int idCD;
                System.out.println("========= Wybierz płytę =========");
                System.out.print("Podaj id płyty: ");
                try {
                    idCD = Integer.parseInt(bufor.readLine());
                }
                catch (IOException e){
                    e.printStackTrace();
                    return;
                }
                obslugaPlyty(nrKol, idCD);
            }

            if (menu.equals("3")) {
                String tytul, wykonawca, wydawca;
                int rokWydania;
                float cena;
                System.out.println("========= Dodawanie plyty =========");
                try {
                    System.out.print("Podaj tytuł płyty: ");
                    tytul = bufor.readLine();
                    System.out.print("Podaj wykonawcę płyty: ");
                    wykonawca = bufor.readLine();
                    System.out.print("Podaj wydawcę płyty: ");
                    wydawca = bufor.readLine();
                    System.out.print("Podaj rok wydania płyty: ");
                    rokWydania = Integer.parseInt(bufor.readLine());
                    System.out.print("Podaj cenę płyty: ");
                    cena = Float.parseFloat(bufor.readLine());
                }
                catch (IOException e){
                    e.printStackTrace();
                    return;
                }
                kolekcje.get(nrKol).addPlyta(new PlytaCD(
                        tytul,
                        wykonawca,
                        wydawca,
                        rokWydania,
                        cena
                ));
            }
            if (menu.equals("0")) {
                break;
            }
        }
    }

    static void obslugaPlyty(int nrKol, int idCD){
        String menu;
        while (true) {
            System.out.format("========= Płyta %s ========= \n", kolekcje.get(nrKol).getPlyty().get(idCD).getTytul());
            System.out.println("1: Wyświetl utwory");
            System.out.println("2: Utwórz utwór");
            System.out.println("0: Powrót do menu kolekcji \n");
            System.out.print("Wybierz opcję: ");
            try {
                menu = bufor.readLine();
            } catch (IOException e) {
                e.printStackTrace();
                return;
            }

            if (menu.equals("1")) {
                kolekcje.get(nrKol).getPlyty().get(idCD).wyswietlPlyte();
                kolekcje.get(nrKol).getPlyty().get(idCD).wyswietlUtwory();
            }
            if (menu.equals("2")) {
                String autor, wykonawca;
                int czasTrwania;
                System.out.println("========= Dodawanie utworu =========");
                try {
                    System.out.print("Podaj autora utworu: ");
                    autor = bufor.readLine();
                    System.out.print("Podaj wykonawcę utworu: ");
                    wykonawca = bufor.readLine();
                    System.out.print("Podaj czas trwania utworu: ");
                    czasTrwania = Integer.parseInt(bufor.readLine());
                }
                catch (IOException e){
                    e.printStackTrace();
                    return;
                }
                kolekcje.get(nrKol).getPlyty().get(idCD).addUtwor(
                        new Utwor(autor, wykonawca, czasTrwania)
                );
            }
            if (menu.equals("0")) {
                break;
            }
        }
    }
}
