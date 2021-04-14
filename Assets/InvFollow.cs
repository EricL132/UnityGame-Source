using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvFollow : MonoBehaviour
{
    public GameObject Player;
    
    
    void Update () {
        Vector3 position = this.transform.localPosition;
        position.x = Player.transform.position.x;
        position.y = Player.transform.position.y+3f;
        this.transform.localPosition = position;
    }
}
