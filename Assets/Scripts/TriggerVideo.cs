using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class TriggerVideo : MonoBehaviour
{
    public EventTrigger.TriggerEvent trigger;
    public Transform TargettingObject;
    public Video RenderVideoTextureObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallBehavior ball = collision.gameObject.GetComponent<BallBehavior>();

        if (ball != null)
        {
            BaseEventData data = new BaseEventData(EventSystem.current);
            trigger.Invoke(data);
        }
    }

    private void Update()
    {
        transform.position = TargettingObject.position;
        RenderVideoTextureObject.transform.position = new Vector3(RenderVideoTextureObject.transform.position.x, TargettingObject.position.y); // отслеживаем позицию для видео
    }
}
