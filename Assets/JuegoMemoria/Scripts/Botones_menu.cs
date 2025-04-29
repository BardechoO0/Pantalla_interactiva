using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Botones_menu : MonoBehaviour
{
    public TMP_InputField Tempo;

    public TMP_InputField Objetos;

    [SerializeField] SimonDice Em;

    public void Tiempo_limite()
    {
        if (Convert.ToInt32(Tempo.text.ToString()) <= 5)
        {
            Tempo.text = "5";
        }else if (Convert.ToInt32(Tempo.text.ToString()) >=120)
        {
            Tempo.text = "120";
        }
    }

    public void Objetos_limite()
    {
        if (Convert.ToInt32(Objetos.text.ToString()) <= 0)
        {
            Objetos.text = "0";
        }
        else if (Convert.ToInt32(Objetos.text.ToString()) >= 14)
        {
            Objetos.text = "14";
        }
    }

    public void Empezar_juego()
    {
        Em.Empezar_2();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
