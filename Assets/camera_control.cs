using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    public GameObject Player;
    public GameObject kam;
    Vector3 pozicija;

    void LateUpdate()
    {

        pozicija = new Vector3(Player.transform.position.x, Player.transform.position.y, kam.transform.position.z);
        kam.transform.position = pozicija;
    }
}


