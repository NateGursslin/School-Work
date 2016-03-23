using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] EnemyTypes;
    private float delay;
    // Use this for initialization
    void Start() {
        delay = 2;
        InvokeRepeating("Spawn", 0, delay);

    }
    void Spawn()
    {
        int spawn = 0;
        while (spawn < EnemyTypes.Length)
        {
            Vector3 position = transform.position;
            position.x += spawn;
            

            Instantiate(EnemyTypes[spawn], position, Quaternion.identity);

            spawn++;
        }
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}
