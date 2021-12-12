using System;
using System.Collections.Generic;
using UnityEngine;

public interface IGameplayState
{
    void Update();

    event Action<StateEnum> ChangeState;
}
