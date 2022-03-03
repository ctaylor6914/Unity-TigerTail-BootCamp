using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TigerTail;

public class DamageableTarget : MonoBehaviour, IDamageable
{
    [SerializeField] private ScoreBoard scoreboard;

    public void TakeDamage(GameObject source, float damage)
    {
        if (source.TryGetComponent(out ThrowableSnowball snowball))
        {
            if (snowball.currentState == ThrowableSnowball.State.Thrown)
            {
                scoreboard.AddScore(1);
                this.gameObject.SetActive(false);
            }

        }
    }
}
