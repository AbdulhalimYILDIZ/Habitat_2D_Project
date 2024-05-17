using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour
{
    public character_SO _basicValues;
    public int HP;
    public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        print(gameObject.name + _basicValues.HP);
        HP = _basicValues.HP;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
