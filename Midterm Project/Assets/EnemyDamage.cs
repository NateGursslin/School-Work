using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {

	// Use this for initialization
	void onCollisionEnter (Collision col) {
	  
        if(col.transform.tag == "Killbox")
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
