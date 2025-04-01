using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eleccion2rpueba : MonoBehaviour
{
    public List<int> numbersToChooseFrom = new List<int>(); // Lista de números posibles
    private List<int> chosenNumbers = new List<int>(); // Lista de números ya elegidos
    int randomNumber;
    [SerializeField] public Sprite[] ConjuntoObjetos = new Sprite[40];
    [SerializeField] public Image[] Objetos40 = new Image[40];

    void Start()
    {
        // Llena la lista de números posibles con valores del 1 al 40 (por ejemplo)
        for (int i = 0; i <= 39; i++)
        {
            numbersToChooseFrom.Add(i);
        }
    }

    void Update()
    {
        // Simula el proceso de elegir un número aleatorio al presionar la tecla de espacio
        
    }

    public void PickRandomNumber()
    {
        for (int i = 0; i < 40; i++)
        {
            if (numbersToChooseFrom.Count > 0)
            {
            // Genera un índice aleatorio dentro del rango de la lista de números posibles
            int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

            // Obtiene el número correspondiente al índice aleatorio
            randomNumber = numbersToChooseFrom[randomIndex];

            // Procesa el número elegido (en este caso, solo lo imprime)
            Debug.Log("Número elegido: " + randomNumber);

            // Agrega el número a la lista de números elegidos
            chosenNumbers.Add(randomNumber);

            // Remueve el número elegido de la lista de números posibles
            numbersToChooseFrom.RemoveAt(randomIndex);

            
                Objetos40[i].sprite = ConjuntoObjetos[randomNumber];
            }
        }

        
       
    }
}
