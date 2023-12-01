using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoFrente : BotoesBase {

    public GameObject Jogador;
    public GameObject botaoinicia;
    public GameObject acoes;
    public string nomeAcao = "Frente";
    public Text textoBotao;
    public override void realizaAcao()
    {     
        Jogador.GetComponent<ControlaJogador>().andar = true;       
        if (Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count == 0)
        {
            acoes.GetComponent<mostraAcao>().desativaAcao();          
        }
    }
    public void adicionaAcao()
    {
        if(acoes.GetComponent<mostraAcao>().contador == acoes.GetComponent<mostraAcao>().botoesAcoes.Count){
            return;
        }
        Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Add(GetComponent<BotaoFrente>());
        acoes.GetComponent<mostraAcao>().mostrarAcao(Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count, nomeAcao);
    }
}
