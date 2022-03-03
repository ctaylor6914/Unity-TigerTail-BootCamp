using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TigerTail;

public class TargetScore : MonoBehaviour
{
    [SerializeField] private ScoreBoard scoreboard;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out ThrowableSnowball snowball))
        {
            if(snowball.currentState == ThrowableSnowball.State.Thrown)
            {
                scoreboard.AddScore(1);
                this.gameObject.SetActive(false);
            }
            
        }
    }
}
