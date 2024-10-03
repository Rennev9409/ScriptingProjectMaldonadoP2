using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablesandfuctions : MonoBehaviour
{    //create a variable of type int and set it to the number 5
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = multiplybytwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }




    int multiplybytwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
    
