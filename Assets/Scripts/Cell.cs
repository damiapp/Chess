﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Image outlineImage;
    [HideInInspector]
    public Vector2Int boardPosition = Vector2Int.zero;
    [HideInInspector]
    public Board board = null;
    [HideInInspector]
    public RectTransform rectTransform = null;

    public void Setup(Vector2Int newBoardPosition, Board newBoard)
    {
        boardPosition = newBoardPosition;
        board = newBoard;

        rectTransform = GetComponent<RectTransform>();
    }
    
}
