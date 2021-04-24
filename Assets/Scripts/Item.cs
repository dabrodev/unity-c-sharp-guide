using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //every item has a name
    //every item has a description
    //every item has an image icon
    //every item has an attack strength

        public string itemName = "Sword";
        public string itemDescription = "gold, magic and powerful.";
        public  string imageLink = "https://dabro.dev";
        public int attackStrength  = 300;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The item  " + itemName + "and is " + itemDescription);
        Debug.Log("Image link: " + imageLink);
        Debug.Log("Strength: " + attackStrength);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
