using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationBar : MonoBehaviour
{
    private Text _text;
    public void InıtNotification(String notificationText)
    {
        _text.text = notificationText;
    }

    public void DestroyNotification()
    {
        Destroy(gameObject);
    }
}
