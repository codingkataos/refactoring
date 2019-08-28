package org.codingkataos.refactoring.move;

public class Book {
    private String name;
    private String author;
    private String content;

    public boolean contains(String word){
        return content.contains(word);
    }

    public String getAuthor(){
        return author;
    }

    public String exportToPDF(){
        return convertToPDF();
    }

    public String getName() {
        return name;
    }

    public void sendContentTo(String email){
        // send content to email.
    }

    private String convertToPDF(){
        return content;
    }
}
