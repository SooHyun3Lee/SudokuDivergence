using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private int mainNum; //main number for the tile
    private List<int> noteNums = new List<int>(); //candidate numbers for the tile

    // need to restrict inputs to 1~9, anything else will be treated as 0
    public void MainNumInput(int num) { if (num < 10 && num > 0) mainNum = num; }

    public void ResetMainNum() { mainNum = 0; }

    public void NoteNumsInput(int num) 
    {
        if (num > 9 || num < 1) return;
        if (noteNums.Contains(num)) { noteNums.Remove(num); }
        else noteNums.Add(num); 
    }


    // if mainNo==0 display noteNo, else display mainNo

}
