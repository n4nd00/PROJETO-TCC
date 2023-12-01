using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCamera : MonoBehaviour
{



    public GameObject Jogador;
    Transform personagem;
    void Start()
    {
        personagem = Jogador.GetComponent<Transform>();
    }


    void LateUpdate()
    {
        if (personagem != null)
        {
            // Calcula a posição atrás do personagem
            Vector3 posicaoAtras = personagem.position - personagem.forward * 7+ Vector3.up * 6;

            // Define a posição da câmera
            transform.position = posicaoAtras;

            // Obtém a rotação do personagem
            Quaternion rotacaoPersonagem = personagem.rotation;

            // Aplica a rotação do personagem à câmera, mantendo o valor Z e limitando o valor Y
            Quaternion novaRotacao = Quaternion.Euler(transform.rotation.eulerAngles.x, rotacaoPersonagem.eulerAngles.y, rotacaoPersonagem.eulerAngles.z);

            // Define a rotação da câmera
            transform.rotation = novaRotacao;
        }
    }
}
