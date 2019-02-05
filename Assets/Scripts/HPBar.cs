using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    public ScriptableFloat HP;
    public ScriptableFloat Mana;
    // Start is called before the first frame update
    void Start()
    {
        print(HP.Value);
    }

    // Update is called once per frame
    void Update()
    {
        HP.subValue(10);
        print(HP.Value);
    }
    
}
