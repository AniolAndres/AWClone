using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileController 
{

    private readonly TileView view;

    private readonly TileModel model;

    public TileController(TileView view, TileModel model){
        this.view = view;
        this.model = model;
    }

    public void OnCreate() {
        view.OnTileClicked += HandleTileClicked;
    }

    public void OnDestroy() {
        view.OnTileClicked -= HandleTileClicked;
    }

    private void HandleTileClicked() {
        Debug.Log("Tile " + view.name + " clicked");
    }
}
