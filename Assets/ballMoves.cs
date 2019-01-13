using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMoves : MonoBehaviour {

    public Vector3 vectorRight = new Vector3(1f, 0,0);
    public Vector3 vectorLeft = new Vector3(-1f, 0,0);

    public bool moveLeft = false;

        
        
        // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if (moveLeft==false)
        {
            transform.Translate(vectorRight);
        }
        else if (moveLeft == true)
        {
            transform.Translate(vectorLeft);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Wall")
        {
            if (moveLeft==false)
            {
                moveLeft = true;
            }
            else if (moveLeft == true)
            {
                moveLeft = false;
            }
        }

    }


}
