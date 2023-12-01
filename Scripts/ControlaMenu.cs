using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlaMenu : MonoBehaviour {
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void jogarJogo()
    {

        StartCoroutine(MudarCena("Jogo"));
    }
    public void sairJogo()
    {
        StartCoroutine(Sair());
    }

    IEnumerator MudarCena(string name)
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(name);
    }
    IEnumerator Sair()
    {
        yield return new WaitForSeconds(0.4f);
        Application.Quit();
    }
}
