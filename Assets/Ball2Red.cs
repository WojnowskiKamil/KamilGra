using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2Red : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedBall2")
        {
            Destroy(other.gameObject);           
            Liczniki.LicznikPilekCz++;
        }

        if (other.gameObject.tag == "GreenBall2")
        {
            Liczniki.LicznikPilekCz--;
        }
    }
}
