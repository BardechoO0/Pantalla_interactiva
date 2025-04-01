using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Cronometro2 : MonoBehaviour
{
    private bool levelCompleted = false;
    private float tiempoTranscurrido = 0f;
    public GameObject player;
    public TextMeshProUGUI textoVictoria;
    public TextMeshProUGUI textoTiempo;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textoTiempo.text = tiempoTranscurrido.ToString("F2") + " s";
        /*if ()
        {
            LevelCompletado();
        }*/
    }
    IEnumerator StartTimer()
    {
        tiempoTranscurrido = 0f;

        yield return null;

        while (levelCompleted == false)
        {
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }
    }

    public void StartCorrutina()
    {
        StartCoroutine(StartTimer());
    }
    public void LevelCompletado()
    {
        levelCompleted = true;

        StopCoroutine(StartTimer());

        textoVictoria.text = "Your time: " + tiempoTranscurrido.ToString("F2") + " seconds, AWESOME";

    }
}