using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Player;
    
    public float speed = 2.0f;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    void Update () {
        float interpolation = speed * Time.deltaTime;
      /*   
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, Player.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, Player.transform.position.x, interpolation);
        this.transform.position = position; */

        Vector3 targetPosition = new Vector3(Player.transform.position.x,Player.transform.position.y,transform.position.z);
        targetPosition.x = Mathf.Clamp(targetPosition.x,minPosition.x,maxPosition.y);
        targetPosition.y = Mathf.Clamp(targetPosition.y,minPosition.y,maxPosition.y);
        transform.position = Vector3.Lerp(transform.position,targetPosition,interpolation);
        
       
    }
}
