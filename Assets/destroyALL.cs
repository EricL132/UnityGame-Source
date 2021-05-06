using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyALL : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Awake(){
        if(GameObject.FindGameObjectWithTag("Player")){
            Destroy(GameObject.Find("Music"));
            Destroy(GameObject.Find("Main Camera"));
            Destroy(GameObject.Find("Canvas"));
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
  
    }
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
