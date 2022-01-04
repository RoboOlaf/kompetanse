using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Død : MonoBehaviour
{
    if (rb.position.y<-1f) {
        FindObjectOfType<gamemanager>().EndGame();
    }
}
