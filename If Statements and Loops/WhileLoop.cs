using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

    int numberOfEnemies = 15;

	void Start ()
    {

        while(numberOfEnemies > 0)
        {
            Debug.Log("Headshot!");
            numberOfEnemies--;
        }
	
	}
	
	
	void Update () {
	
	}
}
