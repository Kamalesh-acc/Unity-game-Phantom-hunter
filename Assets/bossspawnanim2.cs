using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class bossspawnanim2 : MonoBehaviour
{
    public GameObject bossspawnanime;
    public Transform posSpawnAnim;
    public static int activateSpawnAnim = 0;
   

    // Start is called before the first frame update
    void Update()
    {
        if (activateSpawnAnim == 1)
        {
            Vector3 posi = posSpawnAnim.position;
            Instantiate(bossspawnanime, posi, Quaternion.identity);
            activateSpawnAnim = 0;


        }
    }

    // Update is called once per frame

}
