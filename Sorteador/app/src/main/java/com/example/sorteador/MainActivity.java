package com.example.sorteador;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.Random;


public class MainActivity extends AppCompatActivity {

    private TextView txtPremio;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtPremio = findViewById(R.id.txtPremio);
        ImageView img= (ImageView) findViewById(R.id.imgSorteio);
        img.setImageResource(R.drawable.logo);
    }

    public void Sortear (View v) {

        Random rand = new Random();
        int num_sorteio = rand.nextInt(6) + 1;

        switch (num_sorteio) {
            //Carro
            case 1:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.carro);
                txtPremio.setText("Parabéns, vc ganhou um carro!!!!");
                break;
            }
            //Casa
            case 2:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.casa);
                txtPremio.setText("Parabéns, vc ganhou uma casa!!!!");
                break;
            }
            //Dinheiro
            case 3:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.dinheiro);
                txtPremio.setText("Parabéns, vc ganhou R$ 10.000 reais!!!!");
                break;
            }
            //Moto
            case 4:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.moto);
                txtPremio.setText("Parabéns, vc ganhou uma moto!!!!");
                break;
            }
            //Notebook
            case 5:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.notebook);
                txtPremio.setText("Parabéns, vc ganhou um notebook!!!!");
                break;
            }
            //Smartphone
            case 6:{
                ImageView img= (ImageView) findViewById(R.id.imgSorteio);
                img.setImageResource(R.drawable.smartphone);
                txtPremio.setText("Parabéns, vc ganhou um Smartphone!!!!");
                break;
            }
        }
    }
}