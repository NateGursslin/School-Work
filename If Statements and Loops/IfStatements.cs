using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
   public int homework = 15;

    void Start()
    {
        if (homework > 0)
        {
            Debug.Log("Do Your Homework!");
        }
        else if(homework < 0)
        {
            Debug.Log("How???!!??");
        }

        else
        {
            Debug.Log("Liar!");
        }
    }

}
