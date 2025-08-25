using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaDeCena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Dialogo()
    {
        SceneManager.LoadScene("Dialogo");
    }

    public void Fase()
    {
        SceneManager.LoadScene("Fase");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
