package com.Lista1;

public class Utwor {
    private String autor, wykonawca;
    private int czasTrwania;

    public Utwor(
            String autor,
            String wykonawca,
            int czasTrwania
    ) {
        setAutor(autor);
        setWykonawca(wykonawca);
        setCzasTrwania(czasTrwania);
    }

    public String getAutor()        {return this.autor;}
    public String getWykonawca()    {return this.wykonawca;}
    public int getCzasTrwania()     {return this.czasTrwania;}

    public void setAutor(String autor){
        try {
            this.autor = autor;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setWykonawca(String wykonawca){
        try {
            this.wykonawca = wykonawca;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
    public void setCzasTrwania(int czasTrwania){
        try {
            this.czasTrwania = czasTrwania;
        } catch (Exception e) {
            e.printStackTrace();
            return;
        }
    }
}
