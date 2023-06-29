using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deleteClonePieces : MonoBehaviour
{
    SpawnChess sc1 = new SpawnChess();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Selam CAnım");


    }
    void destroyPieces()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        var numbers = new List<int> { 1001, 1002, 1003, 1004, 
            1005, 1006, 1007, 1008, 1010, 1012, 1013,1014,1015,1016,
        1017,1018,1019,1020,1021,1022,1023,1024,1025,1026
        ,1027,1028,1029,1030,1029,1030,1033,1034};

        Debug.Log(other.GetComponent<PhotonView>().ViewID + other.gameObject.tag);

        /*if (other.GetComponent<PhotonView>().ViewID == 1001)
        {
            Destroy(other.gameObject);
            Debug.Log("if ve foreach çalıştı");
        }

        if (other.GetComponent<PhotonView>().ViewID == 1003)
        {
            Destroy(other.gameObject);
            Debug.Log("if ve foreach çalıştı");
        }*/

        foreach(var number in numbers)
        {
            if(other.GetComponent<PhotonView>().ViewID == number)
            {
                Destroy(other.gameObject);
                Debug.Log("if ve foreach çalıştı");
            }
        }



    }

}
