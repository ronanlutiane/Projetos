package com.example.va3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {

    private EditText edValorImovel;
    private EditText edQtdeQuartos;
    private EditText edQtdeGaragens;

    private TextView txtValorImovel;
    private TextView txtQtdeQuartos;
    private TextView txtQtdeGaragens;
    private TextView txtValorFinal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edValorImovel = findViewById(R.id.edValorImovel);
        edQtdeQuartos = findViewById(R.id.edQtdeQuartos);
        edQtdeGaragens = findViewById(R.id.edQtdeGaragens);
        txtValorImovel = findViewById(R.id.txtValorImovel);
        txtQtdeQuartos = findViewById(R.id.txtQtdeQuartos);
        txtQtdeGaragens = findViewById(R.id.txtQtdeGaragens);
        txtValorFinal = findViewById(R.id.txtValorFinal);
    }

    public void Calcular (View v) {

        double valorInicial;
        double valorQuartosAdicionais = 0;
        double valorGaragens = 20000;
        double valorFinal;

        valorInicial = Double.parseDouble(edValorImovel.getText().toString());
        if (Double.parseDouble(edQtdeQuartos.getText().toString()) > 0 ) {
            valorQuartosAdicionais = 11500 * Double.parseDouble(edQtdeQuartos.getText().toString());
        }

        if (Double.parseDouble(edQtdeGaragens.getText().toString()) > 0) {
            valorGaragens = valorGaragens * Double.parseDouble(edQtdeGaragens.getText().toString());
        }

        valorFinal = valorInicial + valorQuartosAdicionais + valorGaragens;

        String resultado = new DecimalFormat("#,##0.00").format(valorFinal);
        txtValorFinal.setText("Valor final do Imovel : R$ " + resultado);
    }
}