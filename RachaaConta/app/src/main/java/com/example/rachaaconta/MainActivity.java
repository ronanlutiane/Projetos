package com.example.rachaaconta;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.text.DecimalFormat;

public class MainActivity extends AppCompatActivity {

    private EditText edConsumo;
    private EditText edCouvert;
    private EditText edQtdePessoas;
    VlrTaxa;
    private TextView txtVlrConta;
    private TextView txtVlrPessoa;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edConsumo = findViewById(R.id.edConsumo);
        edCouvert = findViewById(R.id.edCouvert);
        edQtdePessoas = findViewById(R.id.edQtdePessoas);
        txtVlrTaxa = findViewById(R.id.txtVlrTaxa);
        txtVlrConta = findViewById(R.id.txtVlrConta);
        txtVlrPessoa = findViewById(R.id.txtVlrPessoa);
    }

    public void Calcular (View v) {

        if (edConsumo.getText().toString().length() == 0) {
            edConsumo.setError("Valor de consumo inválido!");
        }
        else if (edQtdePessoas.getText().toString().length() == 0) {
            edQtdePessoas.setError("O numero de pessoas precisa ser diferente de 0!!");
        }

        int qtdePessoas = Integer.parseInt(edQtdePessoas.getText().toString());
        double valorConsumo = Double.parseDouble(edConsumo.getText().toString());
        double totalCouvert = Double.parseDouble(edCouvert.getText().toString()) * qtdePessoas;
        double totalConsumo = valorConsumo + totalCouvert;
        double vlrTaxa = totalConsumo * 0.1;
        double totalConta = totalConsumo + vlrTaxa;
        double vlrPessoa = totalConta / qtdePessoas;
        String resultado = new DecimalFormat("#,##0.00").format(vlrPessoa);

        txtVlrTaxa.setText(Double.toString(vlrTaxa));
        txtVlrConta.setText(Double.toString(totalConta));
        txtVlrPessoa.setText(resultado);
    }
}