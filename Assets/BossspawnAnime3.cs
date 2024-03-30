using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossspawnanim3 : MonoBehaviour
{
    
    public GameObject bossspawnanime;
    public GameObject bossspawnanime2;
    public Transform posSpawnAnim;
    public static int activateSpawnAnim = 0;
    public GameObject parentObject;


    // Start is called before the first frame update
    void Update()
    {
        if (activateSpawnAnim == 1)
        {
            Vector3 posi = posSpawnAnim.position;
            Instantiate(bossspawnanime, posi, Quaternion.identity);
            activateSpawnAnim = 0;


        }
        if (activateSpawnAnim == 2)
        {
            Vector3 posi = posSpawnAnim.position;
            GameObject bossSpawn = Instantiate(bossspawnanime2, posi, Quaternion.identity);
            bossSpawn.transform.parent = parentObject.transform;
            activateSpawnAnim = 0;


        }
    }

    // Update is called once per frame

}

