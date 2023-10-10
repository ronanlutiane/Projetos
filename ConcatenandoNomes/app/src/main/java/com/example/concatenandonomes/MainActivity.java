package com.example.concatenandonomes;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    private EditText edFirstName;
    private EditText edLastName;
    //private TextView txtName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edFirstName = findViewById(R.id.edFirstName);
        edLastName = findViewById(R.id.edLastName);
        //txtName = findViewById(R.id.txtName);
    }

    public void Concatenar (View v) {

        if (edFirstName.getText().toString().length() == 0) {
            edFirstName.setError("Primeiro nome inválido!");
        }
        else if (edLastName.getText().toString().length() == 0) {
            edLastName.setError("Sobrenome inválido!!");
        }

        String nome = edFirstName.getText().toString().concat(" " + edLastName.getText().toString());
        //txtName.setText("Seu nomé é: " + nome);

        //Parte 2

        //Cria um objeto de mensagem na tela
        AlertDialog.Builder msg = new AlertDialog.Builder(this);

        //Configura o seu titulo
        msg.setTitle("Resultado");

        //Configura o conteúdo na mensagem. Mudar para a sua variavel apos o sinal de +
        msg.setMessage("Meu nome completo é: " + nome);

        //Configura para o botão de OK aparecer na tela
        msg.setNeutralButton("OK", null);

        //Exibe a mensagem na tela
        msg.show();

    }
}