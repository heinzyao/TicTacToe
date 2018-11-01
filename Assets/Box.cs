using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    public int row;
    public int col;
    public GameObject core;
    public GameObject GameTitle;

    void OnMouseDown()
    {
        int[,] boxes = core.GetComponent<GameController>().boxes;

      
        if (boxes[row, col] == 0 && core.GetComponent<GameController>().flag % 2 == 0)
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<GameController>().icon[0];
            core.GetComponent<GameController>().flag = core.GetComponent<GameController>().flag + 1;
            boxes[row, col] = 1;

        }
        else if (boxes[row, col] == 0 && core.GetComponent<GameController>().flag % 2 != 0)
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<GameController>().icon[1];
            core.GetComponent<GameController>().flag = core.GetComponent<GameController>().flag + 1;
            boxes[row, col] = 2;
        }
   

        if (
        (boxes[0, 0] == 1 && boxes[0, 1] == 1 && boxes[0, 2] == 1)
        || (boxes[1, 0] == 1 && boxes[1, 1] == 1 && boxes[1, 2] == 1)
        || (boxes[2, 0] == 1 && boxes[2, 1] == 1 && boxes[2, 2] == 1)
        || (boxes[0, 0] == 1 && boxes[1, 1] == 1 && boxes[2, 2] == 1)
        || (boxes[0, 2] == 1 && boxes[1, 1] == 1 && boxes[2, 0] == 1)
        || (boxes[0, 0] == 1 && boxes[1, 0] == 1 && boxes[2, 0] == 1)
        || (boxes[0, 1] == 1 && boxes[1, 1] == 1 && boxes[2, 1] == 1)
        || (boxes[0, 2] == 1 && boxes[1, 2] == 1 && boxes[2, 2] == 1)

 )
        {
            GameTitle.GetComponent<TextMesh>().text = "O Win!";
        }

        else if (
                (boxes[0, 0] == 2 && boxes[0, 1] == 2 && boxes[0, 2] == 2)
                 || (boxes[1, 0] == 2 && boxes[1, 1] == 2 && boxes[1, 2] == 2)
                 || (boxes[2, 0] == 2 && boxes[2, 1] == 2 && boxes[2, 2] == 2)
                 || (boxes[0, 0] == 2 && boxes[1, 1] == 2 && boxes[2, 2] == 2)
                 || (boxes[0, 2] == 2 && boxes[1, 1] == 2 && boxes[2, 0] == 2)
                 || (boxes[0, 0] == 2 && boxes[1, 0] == 2 && boxes[2, 0] == 2)
                 || (boxes[0, 1] == 2 && boxes[1, 1] == 2 && boxes[2, 1] == 2)
                 || (boxes[0, 2] == 2 && boxes[1, 2] == 2 && boxes[2, 2] == 2)
                )
        {
            GameTitle.GetComponent<TextMesh>().text = "X Win!";
        }
        else if (core.GetComponent<GameController>().flag == 9)

        {
           GameTitle.GetComponent<TextMesh>().text = "It's a Tie!";
        }

    }
}
