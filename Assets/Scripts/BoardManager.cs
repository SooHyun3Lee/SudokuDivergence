using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private bool isFilled = false;
    //private bool isCorrect = false;

    //private Tile[,] masterBoard = new Tile[9,9]; //9x9 array of Tiles
    private Tile[] masterBoard = new Tile[81]; //9x9 array of Tiles

    /* when the player inputs a number, add it to corresponding row, col, and 
     * box List to be used for duplicate checking later on */
    private List<int>[] rows = new List<int>[9];
    private List<int>[] cols = new List<int>[9];
    private List<int>[] boxes = new List<int>[9];

    /* determine which List to access by using division and mod
     * i.e.) (pos / 9) , (pos mod 9) to get (row, col) coordinate
     */
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {

        }
    }

    // if isFilled && isCorrect, sudoku cleared
}
