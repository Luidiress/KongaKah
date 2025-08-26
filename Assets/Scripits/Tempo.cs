using TMPro;
using UnityEngine;

public class Tempo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoTimer;
    [SerializeField] private GameObject telaVitoria;
    [SerializeField] private GameObject telaDerrota;
    private bool jogoAtivo = true;
    public float tempoTotal = 120f;
    private bool Tag = false;


    void Start()
    {
        telaVitoria.SetActive(false);
        telaDerrota.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!jogoAtivo) return;
        {
            tempoTotal -= Time.deltaTime;
            int minutos = Mathf.FloorToInt(tempoTotal / 60);
            int segundos = Mathf.FloorToInt(tempoTotal % 60);
            textoTimer.text = $"Tempo: {minutos:00}:{segundos:00}";

            if (tempoTotal <= 0f)
            {
                Derrota();
            }
           
            
        }
    }

    private void Vitoria()
    {
        jogoAtivo = false;
        telaVitoria.SetActive(true);
    }

    private void Derrota()
    {
        jogoAtivo = false;
        telaDerrota.SetActive(true);
    }
}
