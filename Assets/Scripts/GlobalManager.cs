using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{

    private IGameplayState currentState;

    private void Start() {
        currentState = new NothingSelectedState();
        currentState.ChangeState += ChangeState;
    }

    private void ChangeState(StateEnum newState) {

        currentState.ChangeState -= ChangeState;

        switch (newState) {
            case StateEnum.NothingSelected:
                currentState = new NothingSelectedState();
                break;

            case StateEnum.UnitSelected:
                currentState = new UnitSelectedState();
                break;
        }

        currentState.ChangeState += ChangeState;
    }

    private void Update() {

        currentState.Update();
    }
}
