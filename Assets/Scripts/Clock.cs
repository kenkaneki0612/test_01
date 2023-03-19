using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private int addhour;

    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    public Transform hoursTransform, minutesTransform, secondsTransform;

    private void Awake()
    {
        DateTime time = DateTime.Now;
        TimeSpan timechange = new System.TimeSpan(addhour, 0, 0);
        DateTime setTime = time.Add(timechange);

        hoursTransform.localRotation = Quaternion.Euler(0f, setTime.Hour * degreesPerHour, 0f);

        minutesTransform.localRotation = Quaternion.Euler(0f, setTime.Minute * degreesPerMinute, 0f);

        secondsTransform.localRotation = Quaternion.Euler(0f, setTime.Second * degreesPerSecond, 0f);
    }

    private void Update()
    {

        UpdateDiscription();
    }

    void UpdateDiscription()
    {
        DateTime time = DateTime.Now;
        TimeSpan timechange = new System.TimeSpan(addhour, 0, 0);
        DateTime setTime = time.Add(timechange);
        hoursTransform.localRotation = Quaternion.Euler(0f, setTime.Hour * degreesPerHour, 0f);

        minutesTransform.localRotation = Quaternion.Euler(0f, setTime.Minute * degreesPerMinute, 0f);

        secondsTransform.localRotation = Quaternion.Euler(0f, setTime.Second * degreesPerSecond, 0f);
    }
}
