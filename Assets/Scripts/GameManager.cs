using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Board board;

    // Start is called before the first frame update
    void Start()
    {
        board.Create();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
