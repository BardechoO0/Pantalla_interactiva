using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eleccion2rpueba : MonoBehaviour
{
    public List<int> numbersToChooseFrom = new List<int>(); // Lista de n�meros posibles
    private List<int> chosenNumbers = new List<int>(); // Lista de n�meros ya elegidos
    int randomNumber;
    [SerializeField] public Sprite[] ConjuntoObjetos = new Sprite[40];
    [SerializeField] public Image[] Objetos40 = new Image[40];

    void Start()
    {
        // Llena la lista de n�meros posibles con valores del 1 al 40 (por ejemplo)
        for (int i = 0; i <= 39; i++)
        {
            numbersToChooseFrom.Add(i);
        }
    }

    void Update()
    {
        // Simula el proceso de elegir un n�mero aleatorio al presionar la tecla de espacio
        
    }

    public void PickRandomNumber()
    {
        for (int i = 0; i < 40; i++)
        {
            if (numbersToChooseFrom.Count > 0)
            {
            // Genera un �ndice aleatorio dentro del rango de la lista de n�meros posibles
            int randomIndex = Random.Range(0, numbersToChooseFrom.Count);

            // Obtiene el n�mero correspondiente al �ndice aleatorio
            randomNumber = numbersToChooseFrom[randomIndex];

            // Procesa el n�mero elegido (en este caso, solo lo imprime)
            Debug.Log("N�mero elegido: " + randomNumber);

            // Agrega el n�mero a la lista de n�meros elegidos
            chosenNumbers.Add(randomNumber);

            // Remueve el n�mero elegido de la lista de n�meros posibles
            numbersToChooseFrom.RemoveAt(randomIndex);

            
                Objetos40[i].sprite = ConjuntoObjetos[randomNumber];
            }
        }

        
       
    }
}
