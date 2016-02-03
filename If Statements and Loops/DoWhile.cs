using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour {

	
	void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print("Continuing!");
        }
        while (shouldContinue == true);
	
	}
	
	
	void Update () {
	
	}
}
