using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour {

    public Text hpValue;
    private int hp;
    private int dmg;
    

	// Use this for initialization
	void Start () {
        hp = 100;
        dmg = 25;
	
	    }

    void OnCollisionEnter(Collision col)
     {
        if (col.transform.tag == "Enemy")
        {
            hp = Damage(hp);
            hpValue.text = hp.ToString();
            
            if (hp <= 0)
            {
                Application.LoadLevel("Midterm Project");
            }

        }

        else if (col.transform.tag == "Killbox")
            {
                Application.LoadLevel("Midterm Project");
            }
           
     }
    int Damage (int hp)
    {
        int ret;
        ret = hp - dmg;
        hp = ret;
        return hp;
    }

    }

        
    
	
