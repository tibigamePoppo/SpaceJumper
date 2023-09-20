using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ResultPanel;
    public gameState currentState { private set; get; }
    public enum gameState
    {
        ingame,
        result,
    }

    public Action GetMeat;

    public void ChangeState(gameState state)
    {
        currentState = state;
        switch (state)
        {
            case gameState.ingame:
                ResultPanel.SetActive(false);
                break;
            case gameState.result:
                ResultPanel.SetActive(true);
                break;
            default:
                break;
        }
    }
    void Start()
    {
        ChangeState(gameState.ingame);
        GetMeat = CompleteStage;
    }

    private void CompleteStage()
    {
        ChangeState(gameState.result);
    }
    
    public void reStartStage()
    {
        ChangeState(gameState.ingame);
    }
}
