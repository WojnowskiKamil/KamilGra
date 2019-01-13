using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
        public GameObject Desk1;
        public GameObject Desk2;
    
    void Start()
    {
        Liczniki.Licznik = 0;
        Liczniki.LicznikPilekCz = 0;
        Liczniki.LicznikPilekZ = 0;
        Desk1 = GameObject.FindGameObjectWithTag("Desk1");
        Desk1.SetActive(false);
        Desk2 = GameObject.FindGameObjectWithTag("Desk2");
        Desk2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Liczniki.LicznikPilekCz >= 3 && Liczniki.LicznikPilekZ>=3)
        {
            GameObject platform = GameObject.FindGameObjectWithTag("Platform");
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = platform.transform.position;

            Liczniki.LicznikPilekCz = 0;
            Liczniki.LicznikPilekZ = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            SceneManager.LoadScene(0);
            Liczniki.Licznik = 0;
        }
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            Liczniki.Licznik++;
            Debug.Log(Liczniki.Licznik);
        }
        if (other.gameObject.tag == "Teleport")
        {
            GameObject teleport = GameObject.FindGameObjectWithTag("Boisko");
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (Liczniki.Licznik >= 4)
            {
                player.transform.position = teleport.transform.position;
            }
        }
        if (other.gameObject.tag == "GameEnd")
        {
            Debug.Log("Wygrałeś");
            Application.Quit();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="Desk")
        {
            Destroy(other.gameObject);
            Desk1.SetActive(true);
        }
        else if (other.gameObject.tag == "Desk1")
        {
            Destroy(other.gameObject);
            Desk2.SetActive(true);
        }
    }
}

public static class Liczniki
{
    public static int Licznik;
    public static int LicznikPilekCz;
    public static int LicznikPilekZ;
}
