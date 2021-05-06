using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class checkAnswer : MonoBehaviour
{
    public Text inputField;
    public GameObject Image;
    public string Answer;

    void Start(){   
        
    }
    void Update(){

    }
    public void checkInput(){
        if(inputField.text==Answer){
            if(GameObject.FindGameObjectsWithTag("Question").Length==1){
                GameObject inv = GameObject.Find("InventoryCanvas");
                GameObject player = GameObject.Find("Player");
                Destroy(player);
                Destroy(inv);
                permaBool.insideInput = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
            Destroy(Image);
            
        }else{
            inputField.text = "";
        }
        
    }
}
