using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    private bool posOccupied;
    // Start is called before the first frame update
    void Start()
    {
        posOccupied=Physics.CheckBox(GetComponent<BoxCollider>().center,GetComponent<BoxCollider>().size);
    }

    // Update is called once per frame
    void Update()
    {
        if(posOccupied){
            Destroy(gameObject);
        }
        if(Input.GetKeyDown("r")){
            Destroy(gameObject);
        }
    }
}
