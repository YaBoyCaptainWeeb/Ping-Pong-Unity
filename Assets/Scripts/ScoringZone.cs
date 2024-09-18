using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        BallBehavior ball = other.gameObject.GetComponent<BallBehavior>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            score.Invoke(eventData);
        }
    }
}
