using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private bool isFilled = false;
    private bool isCorrect = false;

    //private Tile[,] masterBoard = new Tile[9,9]; //9x9 array of Tiles
    private Tile[] masterBoard = new Tile[81]; //9x9 array of Tiles

    // if isFilled && isCorrect, sudoku cleared
}
