using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    private const string V = "Hello";

    //bill is 40
    //Tip is 20% based on what the user wants
    //calculate total amount
        public int billAmount = 40;
        public float tip = 20.0f;
        public float totalA;
       



    // Start is called before the first frame update
    void Start()
    {
        totalA = billAmount + billAmount * tip / 100;
        
        Debug.Log("Your bill amount is: $" + totalA);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
