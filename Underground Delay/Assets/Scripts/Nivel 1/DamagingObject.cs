using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingObject : MonoBehaviour
{
    public int damageAcount = 1; //Cantida de da�o que quita el objeto que hace da�o.
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        HeartSystem character = collision.gameObject.GetComponent<HeartSystem>();
        if (character != null)
        {
            character.TakeDamage(damageAcount);
        }
    }
}
