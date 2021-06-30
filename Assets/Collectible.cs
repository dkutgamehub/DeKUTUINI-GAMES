using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
        private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
             //add points and add powerup abilities
            Destroy(this.gameObject);
        }
    }


}
