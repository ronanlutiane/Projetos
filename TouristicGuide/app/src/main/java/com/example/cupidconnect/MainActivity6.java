package com.example.cupidconnect;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class MainActivity6 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main6);
    }

    public  void Retornar(View v)
    {
        Intent myintent = new Intent (MainActivity6.this, MainActivity.class);
        startActivity(myintent);
    }

    public void Ligar(View v)
    {
        Intent myintent = new Intent(Intent.ACTION_DIAL);
        String cellphone_number = "(11) 5432-1098";

        myintent.setData(Uri.parse("tel:" + cellphone_number));
        startActivity(myintent);
    }

}