using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    public void teleport(GameObject player){
        player.transform.position = new Vector3(3.10f,1.26f,-45.33f);
    }
}
