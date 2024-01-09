using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class BoardScript : MonoBehaviour
{
    public Color lightCol;
    public Color darkCol;

    static void DrawSquare(squareCo){


    }
    void CreateGraphicalBoard () { 
        for (int file = 0; file <8; file ++)
        {
            for (int rank = 0; rank < 8; rank++)
            {
                bool isLightSquare = (file + rank) % 2 != 0;

                var squareColour = (isLightSquare) ? lightCol : darkCol;
                var position = new Vector2(-3.5f + file, -3.5f + rank);

                DrawSquare(squareColour, position);
            }
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        CreateGraphicalBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
