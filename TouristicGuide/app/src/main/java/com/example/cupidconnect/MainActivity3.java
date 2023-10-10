package com.example.cupidconnect;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class MainActivity3 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main3);
    }

    public  void Retornar(View v)
    {
        Intent myintent = new Intent (MainActivity3.this, MainActivity.class);
        startActivity(myintent);
    }

    public void Ir(View v)
    {
        // Latitude e longitude do local desejado
        double latitude = -19.9195;
        double longitude = -43.9421;

        // Constrói a URI com os parâmetros de destino
        Uri gmmIntentUri = Uri.parse("geo:" + latitude + "," + longitude + "?z=16&q=" + Uri.encode("Nome do Local"));

        // Cria a intenção (Intent) com a ação de visualizar o mapa
        Intent mapIntent = new Intent(Intent.ACTION_VIEW, gmmIntentUri);
        mapIntent.setPackage("com.google.android.apps.maps"); // Define o pacote do Google Maps

        // Verifica se o aplicativo do Google Maps está instalado
        if (mapIntent.resolveActivity(getPackageManager()) != null) {
            // Abre o aplicativo do Google Maps
            startActivity(mapIntent);
        } else {
            // Redireciona para a página do Google Maps na Play Store
            startActivity(new Intent(Intent.ACTION_VIEW, Uri.parse("market://details?id=com.google.android.apps.maps")));
        }
    }
}