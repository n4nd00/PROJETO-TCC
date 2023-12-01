using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoIniciar : MonoBehaviour
{
    public GameObject Jogador;
    public List<GameObject> BotoesUI = new List<GameObject>();
    public int terminou = 0;
    public void inicia()
    {
        if (Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count != 0)
        {
            terminou = 1;
            desativaBotoesUI();
        }
               
    }
    private void Update()
    {
        if (terminou == 1)
        {
            Jogador.GetComponent<ControlaJogador>().listaDeAcoes[0].realizaAcao();
        }
        if(Jogador.GetComponent<ControlaJogador>().listaDeAcoes.Count == 0)
        {
            ativaBotoesUI();
        }
    }
    private void desativaBotoesUI()
    {
        foreach (GameObject botao in BotoesUI){
            botao.SetActive(false);
        }
    }

    private void ativaBotoesUI()
    {
        foreach (GameObject botao in BotoesUI)
        {
            botao.SetActive(true);
        }
    }
}

