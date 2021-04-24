using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        //create a variable to store your name
        //create a variable to store your age
        //create a variable to sotre your speed
        //create a health variable
        //create a score variable
        //variable to check if all keys were collected
        //variable for ammo count

        public string myName = "Damian";
        public int myAge = 42;
        public float mySpeed = 3.5f;
        public int health = 80;

        public int score = 120;
        public bool hasAllKeys;
        public int ammoCount = 55;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hey, my name is " + myName);
        Debug.Log("Age: " + myAge);
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Keys: " + hasAllKeys);
        Debug.Log("Ammo: " + ammoCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
