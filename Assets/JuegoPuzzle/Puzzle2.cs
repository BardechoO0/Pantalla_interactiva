using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    //Los posibls puzzles que hay
    [SerializeField] GameObject[] Puzzles;

    [SerializeField] GameObject padre;

    //Lugares de instancia de las piezas segun si es puzzle a completar o las piezas que colocar
    public Transform lugar_puzzle;
    public Transform[] lugar_piezas;

    

    //metodo para poder iniciar a jugar
    public void Jugar(int x)
    {
        
        //Segun el numero del boton se crea un numero elegindo, este instancia un tipo de puzzle concreto
        Instantiate(Puzzles[x].gameObject.transform.GetChild(0),lugar_puzzle.localPosition, Quaternion.identity).SetParent(padre.transform);
        
        //Las pizzas del puzzle se colocan de forma aletatotia en tres posibles lugares
        for (int y = 0; y < Puzzles[x].gameObject.transform.GetChild(1).gameObject.transform.childCount; y++)
        {
            int j;
            do
            {
                j = Random.Range(0, lugar_piezas.Length);

            } while (lugar_piezas[j] == null);

            Instantiate(Puzzles[x].gameObject.transform.GetChild(1).gameObject.transform.GetChild(y), lugar_piezas[j].localPosition, Quaternion.identity).SetParent(padre.transform);
            lugar_piezas[j] = null;
        }

        
    }

    //Juego para que sea Aleatorio
    public void Jugar2()
    {
        int x = Random.Range(0, Puzzles.Length);
        Instantiate(Puzzles[x].gameObject.transform.GetChild(0), lugar_puzzle.localPosition, Quaternion.identity);

        for (int y = 0; y < Puzzles[x].gameObject.transform.GetChild(1).gameObject.transform.childCount; y++)
        {
            int j;
            do
            {
                j = Random.Range(0, lugar_piezas.Length);

            } while (lugar_piezas[j] == null);

            Instantiate(Puzzles[x].gameObject.transform.GetChild(1).gameObject.transform.GetChild(y), lugar_piezas[j].localPosition, Quaternion.identity);
            lugar_piezas[j] = null;
        }

        
    }

}
