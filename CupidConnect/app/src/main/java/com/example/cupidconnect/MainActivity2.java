package com.example.cupidconnect;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class MainActivity2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
    }

    public  void Retornar(View v)
    {
        Intent myintent = new Intent (MainActivity2.this, MainActivity.class);
        startActivity(myintent);
    }

    public void Ligar(View v)
    {
        Intent myintent = new Intent(Intent.ACTION_DIAL);
        String cellphone_number = "(11) 9876-5432";

        myintent.setData(Uri.parse("tel:" + cellphone_number));
        startActivity(myintent);
    }
}