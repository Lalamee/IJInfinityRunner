using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out Player player))
        {
            player.ApplyDamage(1);
        } 
        
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
