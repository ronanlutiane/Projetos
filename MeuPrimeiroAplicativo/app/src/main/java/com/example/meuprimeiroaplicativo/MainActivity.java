package com.example.meuprimeiroaplicativo;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText edNum1;
    private EditText edNum2;
    private TextView txtResultado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Instancia as variáveis locais
        edNum1 = findViewById(R.id.edNum1);
        edNum2 = findViewById(R.id.edNum2);
        txtResultado = findViewById(R.id.txtResultado);

    }

    public void Calcular (View v) {

        int num1 = Integer.parseInt(edNum1.getText().toString());
        int num2 = Integer.parseInt(edNum2.getText().toString());
        int result = num1 + num2;

        txtResultado.setText("Resultado é " + Integer.toString(result));
    }

}