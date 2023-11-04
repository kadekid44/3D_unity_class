using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_to_be_picked_up : MonoBehaviour
{
private void OnCollisionEnter (Collision collision)
{
    if(collision.collider.CompareTag("item"))
    {
Destroy(collision.gameObject);
    }
}
private void OnTriggerEnter(Collider other)
{
if(other.CompareTag("item"))
{
    Destroy(other.gameObject);
}
}
}