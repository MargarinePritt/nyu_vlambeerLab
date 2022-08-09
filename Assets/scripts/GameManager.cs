using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform pathmakerSpherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r")){
            Instantiate(pathmakerSpherePrefab,transform.position,Quaternion.identity);
            Pathmaker.globalTileCount=0;
        }
    }
}
