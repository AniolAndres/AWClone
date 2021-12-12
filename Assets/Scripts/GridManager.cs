using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField]
    private TileView TilePrefab;

    private List<TileController> tileControllers;

    public void Start()
    {
        GenerateGrid(6, 6);
    }

    public void GenerateGrid(int width, int height)
    {
        tileControllers = new List<TileController>();

        for (int x = 0; x < width; ++x)
        {
            for(int y = 0; y < height; ++y)
            {
                var newTileView = Instantiate(TilePrefab, new Vector3(x - (float)width / 2 + 0.5f, y-(float)height / 2 + 0.5f), Quaternion.identity, this.transform);
                newTileView.name = $"Tile {x} - {y}";
                var newTileModel = new TileModel(x, y);
                var newTileController = new TileController(newTileView, newTileModel);
                tileControllers.Add(newTileController);
                newTileController.OnCreate();
            }            
        }
    }

    //private void CenterCamera()
    //{
    //    var cameraMain = Camera.main;
    //    cameraMain.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);
    //}
}
