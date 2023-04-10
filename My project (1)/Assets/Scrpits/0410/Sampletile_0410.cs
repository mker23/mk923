using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampletile_0410 : MonoBehaviour
{
    public GameObject file_001;
    public GameObject file_002;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
          for (int j = 0; j < 10; j++)
            {
               GameObject temp = (GameObject)Instantiate(file_001);
               temp.transform.position = new Vector3(i, 0, j);
             }
           for (int j = 10; j < 20; j++)
            {
                GameObject temp = (GameObject)Instantiate(file_002);
                temp.transform.position = new Vector3(i, 0, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
