using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAttackManager : MonoBehaviour
{
    Timer timer;
    void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    public void Finish()
    {
        timer.StopTimer();
    }
}
