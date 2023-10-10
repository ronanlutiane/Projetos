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

    public void Pampulha (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity2.class);
        startActivity(myintent);
    }

    public void Estacao (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity3.class);
        startActivity(myintent);
    }

    public void Igreja (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity4.class);
        startActivity(myintent);
    }

    public void Liberdade (View v) {
        Intent myintent = new Intent (MainActivity.this, MainActivity5.class);
        startActivity(myintent);
    }
}