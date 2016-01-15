using UnityEngine;
using System.Collections;

public class TestScript1 : MonoBehaviour {

    int myInt = 13;

    void Start() {

        myInt = multiplyByItself(myInt);
        Debug.Log(myInt);
    }

    int multiplyByItself(int number)

   {
    int ret;
    ret = number * number;
    return ret;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
