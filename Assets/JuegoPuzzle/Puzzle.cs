using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public SpriteRenderer Sp1;
    public SpriteRenderer Sp2;

    public Vector2 WS;
    void Start()
    {
        

        WS = Sp1.sprite.textureRect.position;

        Sp2.sprite.vertices.GetLength(Sp1.sprite.vertices.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
