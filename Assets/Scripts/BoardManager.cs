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

    // determine which List to access by using division and mod

    public void Update()
    {
        // assume pos is the index of the tile selected
        // row = div
        // col = mod
        // box = each if case
        int pos = 0; // get input from user clicking tile
        int div = pos / 9;
        int mod = pos % 9;
        int box;
        if (div < 3)
        {
            if (mod < 3)
            {
                box = 0;
            }
            else if (mod < 6)
            {
                box = 1;
            }
            else
            {
                box = 2;
            }
        }
        else if (div < 6)
        {
            if (mod < 3)
            {
                box = 3;
            }
            else if (mod < 6)
            {
                box = 4;
            }
            else
            {
                box = 5;
            }
        }
        else
        {
            if (mod < 3)
            {
                box = 6;
            }
            else if (mod < 6)
            {
                box = 7;
            }
            else
            {
                box = 8;
            }
        }

        bool isDuplicate = false;

        // adding to each List depending on input
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (rows[div].Contains(1) || cols[mod].Contains(1) || boxes[box].Contains(1))
            {
                isDuplicate = true;
                return;
                // need to be selective about adding to Lists, user might
                // proceed to input numbers in other tiles despite being wrong
            }
            rows[div].Add(1);
            cols[mod].Add(1);
            boxes[box].Add(1);
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            rows[div].Add(2);
            cols[mod].Add(2);
            boxes[box].Add(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            rows[div].Add(3);
            cols[mod].Add(3);
            boxes[box].Add(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            rows[div].Add(4);
            cols[mod].Add(4);
            boxes[box].Add(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            rows[div].Add(5);
            cols[mod].Add(5);
            boxes[box].Add(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            rows[div].Add(6);
            cols[mod].Add(6);
            boxes[box].Add(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            rows[div].Add(7);
            cols[mod].Add(7);
            boxes[box].Add(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            rows[div].Add(8);
            cols[mod].Add(8);
            boxes[box].Add(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            rows[div].Add(9);
            cols[mod].Add(9);
            boxes[box].Add(9);
        }
    }

    // if isFilled && isCorrect, sudoku cleared
}
