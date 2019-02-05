using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewFloat",menuName = "float")]
public class ScriptableFloat : ScriptableObject{
    public float Value;
    public void subValue(float val){
        if(Value >= val){
            Value -= val;
        }
        else{
            Value = 0;
        } 

    }
}


