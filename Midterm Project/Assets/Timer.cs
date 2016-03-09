using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float time = 25;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        CheckTimer();
	}

    void CheckTimer ()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
}
