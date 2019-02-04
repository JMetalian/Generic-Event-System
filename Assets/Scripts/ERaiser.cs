using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERaiser : MonoBehaviour
{
    public GameEvent willBeRaised;

    public void Raiser(){
        if(willBeRaised!=null){
            willBeRaised.Raise();
        }

        else{
            print("In appropriate event raising: "+ gameObject.name);
        }
    }
}
