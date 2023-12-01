using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoDireita : BotoesBase {
    public GameObject Jogador;
    public GameObject acoes;
    public string nomeAcao = "Direita";
    public void adicionaAcao()
    {
        if (acoes.GetComponent<mostraAcao>().contador == acoes.GetComponent<mostraAcao>().botoesAcoes.Count)
        {
            return;
        }
        Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Add(GetComponent<BotaoDireita>());
        acoes.GetComponent<mostraAcao>().mostrarAcao(Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count,nomeAcao);
    }
    public override void realizaAcao()
    {
        Jogador.GetComponent<Transform>().Rotate(0, 90, 0);
        Jogador.GetComponent<ControlaJogador>().listaDeAcoes.RemoveAt(0);
        
        if (Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count == 0)
        {
            acoes.GetComponent<mostraAcao>().desativaAcao();
            Jogador.GetComponent<ControlaJogador>().BotaoIniciar.GetComponent<BotaoIniciar>().terminou = 0;           
        }
        else
        {
            Jogador.GetComponent<ControlaJogador>().BotaoIniciar.GetComponent<BotaoIniciar>().terminou = 1;
        }
    }
}
