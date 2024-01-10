using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class BoardScript : MonoBehaviour
{
    public int boardSize = 8;
    public float squareSize = 1.0f;
    public Color lightColor = Color.white;
    public Color darkColor= Color.black;

    void Start()
    {
        GenerateChessboard();
    }

    void GenerateChessboard()
    {
        for (int row = 0; row < boardSize; row++)
        {
            for (int col = 0; col < boardSize; col++)
            {
                bool isLightSquare = (row + col) % 2 == 0;
                Color squareColor = isLightSquare ? lightColor : darkColor;
                Vector3 squarePosition = new Vector3(col * squareSize, -row * squareSize, 0f);

                CreateSquare(squarePosition, squareColor);
            }
        }
    }

    void CreateSquare(Vector3 position, Color color)
    {
        GameObject square = GameObject.CreatePrimitive(PrimitiveType.Quad);
        square.transform.position = position;
        square.transform.localScale = new Vector3(squareSize, squareSize, 1f);

        Renderer renderer = square.GetComponent<Renderer>();
        renderer.material.color = color;
    }
}
