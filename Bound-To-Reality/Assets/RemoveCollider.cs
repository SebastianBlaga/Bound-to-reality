using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCollider : MonoBehaviour
{
    public BoxCollider collider;
    public GameObject doorTile1;
    private Vector3 initialPositionTile1;

    void Start()
    {
        initialPositionTile1 = doorTile1.transform.localPosition;

    }

    void Update()
    {
        if(initialPositionTile1 != doorTile1.transform.localPosition)
        collider.enabled = false;
    }
}
