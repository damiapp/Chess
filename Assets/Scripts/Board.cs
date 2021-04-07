using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{

    public GameObject cellPrefab;

    [HideInInspector]
    public Cell[,] allCells = new Cell[8, 8];
    // Start is called before the first frame update
    public void Create()
    {
        int br = 1;
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j<8; j++)
            {

                br++;
                GameObject newCell = Instantiate(cellPrefab,transform);

                RectTransform rectTransform = newCell.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2((j * 100) + 50, (i * 100) + 50);

                allCells[i,j] = newCell.GetComponent<Cell>();
                allCells[i,j].Setup(new Vector2Int(i,j), this);
                if (br % 2 != 0)
                {
                    allCells[i, j].GetComponent<Image>().color = new Color32(230, 220, 186, 255);
                }
            }
            br++;
        }
    }
}
