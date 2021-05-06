using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkIfInput : MonoBehaviour
{
    GameObject[] field;
    void Start(){
        
    }
    void Update()
    {
        field = GameObject.FindGameObjectsWithTag("QuestionInput");
        for(var i = 0 ;i<field.Length;i++){
            InputField checkField = field[i].GetComponent<InputField>();
            if(checkField.isFocused){
                permaBool.insideInput=true;
                break;
            }
            if(i==field.Length-1){
                permaBool.insideInput=false;
            }
        }
        
    }
}
