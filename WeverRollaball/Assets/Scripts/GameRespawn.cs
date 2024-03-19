using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
   public float threshold;

    void FixedPosition()
    {
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
