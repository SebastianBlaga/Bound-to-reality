using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDuplicateMovement : MonoBehaviour
{
    public GameObject oppositeTile;
    public GameObject currentTile;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentTile.transform.localPosition != oppositeTile.transform.localPosition)
        {
            oppositeTile.transform.localPosition = currentTile.transform.localPosition;
        }
    }
}
