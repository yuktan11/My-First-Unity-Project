using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Block[] blocks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyAllBlocks())
        {// game clear
            Debug.Log("Game Clear!!");
        }
    }
    // has all blocks destroyed 
    private bool DestroyAllBlocks()
    {
        foreach (Block b in blocks)
        {
            if(b != null)
            {
                return false;
            }
        }
        return true;
    }

}
