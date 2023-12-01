using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaJogador : MonoBehaviour
{
    private Vector3 direcao;
    public bool andar;
    public bool errouCaminho;
    public bool terminouCaminho;
    private float dist;
    private float distInicial;
    private int countCaminho;    
    private float distAtual;
    private Animator animatorJogador;
    public List<GameObject> listaDeGameObjects;
    public List<BotoesBase> listaDeAcoes;
    public List<AudioSource> Audios;
    public GameObject BotaoIniciar;
    public GameObject acoesTela;
    public GameObject textoUI;
    public GameObject fundoTexto;
    public Rigidbody rigidBodyJogador;

    private void Start()
    {
        distInicial = Vector3.Distance(transform.position, listaDeGameObjects[0].transform.position);
        listaDeAcoes = new List<BotoesBase>();
        countCaminho = 0;
        Time.timeScale = 1;
        rigidBodyJogador = gameObject.GetComponent<Rigidbody>();
        animatorJogador = GetComponent<Animator>();
    }
    private void Update()
    {
        dist = Vector3.Distance(transform.position, listaDeGameObjects[countCaminho].transform.position);       
        if (dist<0.5)
        {
            countCaminho++;
            listaDeAcoes.RemoveAt(0);
            distInicial = Vector3.Distance(transform.position, listaDeGameObjects[countCaminho].transform.position);
            if (listaDeAcoes.Count == 0)
            {
                animatorJogador.SetBool("Movimentando", false);
                BotaoIniciar.GetComponent<BotaoIniciar>().terminou = 0;
            }
            andar = false;
            TocarAudio();
        }
        if (listaDeAcoes.Count == 0)
        {
            animatorJogador.SetBool("Movimentando", false);
            BotaoIniciar.GetComponent<BotaoIniciar>().terminou = 0;
            acoesTela.GetComponent<mostraAcao>().desativaAcao();
        }
        distAtual = Vector3.Distance(transform.position, listaDeGameObjects[countCaminho].transform.position);
        if (distAtual > distInicial + 3)
        {
            Time.timeScale = 0;
            textoUI.SetActive(true);
            fundoTexto.SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                if (SceneManager.GetActiveScene().name == "Jogo")
                {
                    SceneManager.LoadScene("Jogo");
                }
                else
                {
                    SceneManager.LoadScene("Fase2");
                }               
            }
        }
        if (errouCaminho == true)
        {
            Time.timeScale = 0;
            if (Input.GetButtonDown("Fire1"))
            {
                if (SceneManager.GetActiveScene().name == "Jogo")
                {
                    SceneManager.LoadScene("Jogo");
                }
                else
                {
                    SceneManager.LoadScene("Fase2");
                }
            }
        }
        if (terminouCaminho == true)
        {
            
            if (Input.GetButtonDown("Fire1"))
            {
                if (SceneManager.GetActiveScene().name == "Jogo")
                {
                    SceneManager.LoadScene("Fase2");
                }
                else
                {
                    SceneManager.LoadScene("MenuInicial");
                }
            }
        }
    }
    private void FixedUpdate()
    {
        if (andar == true)
        {
            if (transform.rotation.eulerAngles.y == listaDeGameObjects[countCaminho].transform.rotation.eulerAngles.y)
            {
                 dist = Vector3.Distance(transform.position, listaDeGameObjects[countCaminho].transform.position);               
                 animatorJogador.SetBool("Movimentando", true);
                 dist = Vector3.Distance(transform.position, listaDeGameObjects[countCaminho].transform.position);
                 Vector3 direcao = listaDeGameObjects[countCaminho].transform.position - transform.position;
                 rigidBodyJogador.MovePosition(rigidBodyJogador.position +direcao.normalized * 5 * Time.deltaTime);                             
            }
            else
            {
                animatorJogador.SetBool("Movimentando", true);
                rigidBodyJogador.MovePosition
                           (rigidBodyJogador.position +
                           transform.forward * 5 * Time.deltaTime);
            }
        }
    }
    void TocarAudio()
    {
         Audios[countCaminho-1].Play(); 
        
    }
}


