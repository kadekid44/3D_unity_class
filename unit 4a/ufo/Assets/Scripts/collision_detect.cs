using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detect : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
      Destroy(gameObject);
      Destroy(other.gameObject);
   }
}
