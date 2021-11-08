using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OWL : Bird
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider.radius= (float)(Collider.radius+0.5);
    }
}
