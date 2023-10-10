package com.example.cupidconnect;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void Pessoa1 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity2.class);
        startActivity(myintent);
    }

    public void Pessoa2 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity3.class);
        startActivity(myintent);
    }

    public void Pessoa3 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity4.class);
        startActivity(myintent);
    }

    public void Pessoa4 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity5.class);
        startActivity(myintent);
    }

    public void Pessoa5 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity6.class);
        startActivity(myintent);
    }

    public void Pessoa6 (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity7.class);
        startActivity(myintent);
    }
}