using UnityEngine;
using TMPro;
using System;
using System.Collections;


public class EscreverTexto : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI texto;
    [TextArea]
    [SerializeField] private string mensagem;
    [SerializeField] private float velocidade = 0.5f;

    private bool escrevendo = false;

    void Start()
    {
        texto.text = "";
        StartCoroutine(DigitarTexto());
    }

    private IEnumerator DigitarTexto()
    {
        escrevendo = true;

        foreach (char letra in mensagem)
        {
            texto.text += letra;
            yield return new WaitForSeconds(velocidade);
        }
        escrevendo = false;
    }

   
}
