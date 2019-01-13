using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Green : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenBall2")
        {
            Destroy(other.gameObject);
            Liczniki.LicznikPilekZ++;
        }

        if (other.gameObject.tag == "RedBall2")
        {
            Liczniki.LicznikPilekZ--;
        }
    }
}
