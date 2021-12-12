using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController 
{

    private readonly TileView view;

    private readonly TileModel model;

    public TileModel Model => model;

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
        Debug.Log($"Tile {model.X} - {model.Y} clicked");
    }

    public void SpawnActor(ActorScript actorPrefab) {
        view.InstantiateActor(actorPrefab);
    }
}
