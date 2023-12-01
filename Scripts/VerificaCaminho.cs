using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VerificaCaminho : MonoBehaviour {
    public GameObject Jogador;
    public GameObject ErrouCaminhoTexto;
    public GameObject fundoTexto;
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se entrou na área de trigger de um objeto específico
        if (other.gameObject.tag == "Player")
        {
            ErrouCaminhoTexto.SetActive(true);
            fundoTexto.SetActive(true);
            Jogador.GetComponent<ControlaJogador>().errouCaminho = true;
          
        }
    }
}
