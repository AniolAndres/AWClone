using UnityEngine;
using System.Collections;
using System;

public class UnitSelectedState : IGameplayState {

    public event Action<StateEnum> ChangeState;

    public void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ChangeState?.Invoke(StateEnum.NothingSelected);
        }
    }
}
