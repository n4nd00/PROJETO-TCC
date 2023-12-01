using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaFase : MonoBehaviour {
    public GameObject TerminouTexto;
    public GameObject Jogador;
    public GameObject fundoTexto; 
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se entrou na área de trigger de um objeto específico
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            TerminouTexto.SetActive(true);
            fundoTexto.SetActive(true);
            Jogador.GetComponent<ControlaJogador>().terminouCaminho = true;
            Jogador.GetComponent<ControlaJogador>().Audios[7].Play();
        }
    }
}
