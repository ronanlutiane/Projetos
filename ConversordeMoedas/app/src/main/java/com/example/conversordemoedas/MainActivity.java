package com.example.conversordemoedas;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {

    private EditText edValorBrl;
    private TextView txtValorDolar;
    private TextView txtValorConvertido;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edValorBrl = findViewById(R.id.edValorBrl);
        txtValorConvertido = findViewById(R.id.txtValorConvertido);
        txtValorDolar = findViewById(R.id.txtValorDolar);
    }


    public void Converter (View v) {

        double valorBrl = Double.parseDouble(edValorBrl.getText().toString());

        double valorDolar = 5.15;
        String resultado = new DecimalFormat("#,##0.00").format(valorBrl / valorDolar);



        txtValorDolar.setText("Valor do dolar: " + Double.toString(valorDolar));
        txtValorConvertido.setText(" Valor em dólar: " + resultado);
    }
}