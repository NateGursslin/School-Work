using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        string[] numbers = new string[3];

        numbers[0] = "5";
        numbers[1] = "7";
        numbers[2] = "3";

        foreach (string item in numbers)
        {
            print(item);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
