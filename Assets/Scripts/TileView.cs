using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TileView : MonoBehaviour
{
    public event Action OnTileClicked;

    public void FireClickedAction() {
        OnTileClicked?.Invoke();
    }

    public void InstantiateActor(ActorScript actorPrefab) {
        Instantiate(actorPrefab, this.transform);
    }
}
