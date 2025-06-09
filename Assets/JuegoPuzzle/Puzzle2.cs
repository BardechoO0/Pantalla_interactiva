using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    [SerializeField] GameObject[] Puzzles;

    public Transform lugar_puzzle;

    public Transform[] lugar_piezas;
    public bool[] sitio_collido;
    
    void Start()
    {
       
    }

    public void Jugar(int x)
    {
        Instantiate(Puzzles[x].gameObject.transform.GetChild(0),lugar_puzzle.localPosition, Quaternion.identity);
        
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

        print( "jon-YAKITORY, Konton Boogie / jon-YAKITORY, Hatsune Miku-");
    }

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

        print("jon-YAKITORY, Konton Boogie / jon-YAKITORY, Hatsune Miku-");
    }
    void Update()
    {
        
    }
}
