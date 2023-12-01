using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class mostraAcao : MonoBehaviour {
    public GameObject Jogador;
    public int contador = 0;
    public List<GameObject> botoesAcoes = new List<GameObject>();
    public void mostrarAcao(int posicao, string textoBotao)
    {
        botoesAcoes[posicao - 1].SetActive(true);
        botoesAcoes[posicao - 1].GetComponentInChildren<TextMeshProUGUI>().text = textoBotao;
        contador++;
    }
    public void desativaAcao()
    {
        contador = 0;
        foreach (GameObject acao in botoesAcoes)
        {
            acao.SetActive(false);
        }
    }
}
