using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> StageObjects;
    void Start()
    {
        foreach (var item in StageObjects)
        {
            item.SetActive(false);
        }
        StageObjects[Configs.StageNum].SetActive(true);
    }
}
