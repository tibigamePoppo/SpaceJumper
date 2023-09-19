using Cinemachine;
using UnityEngine;

public class VirtualCameraStageSet : MonoBehaviour
{
    CinemachineConfiner virtualCamera;
    CompositeCollider2D stageSize;
    void Awake()
    {
        virtualCamera = FindObjectOfType<CinemachineConfiner>();
        stageSize = GetComponent<CompositeCollider2D>();
        virtualCamera.m_BoundingShape2D = stageSize;
    }
}
