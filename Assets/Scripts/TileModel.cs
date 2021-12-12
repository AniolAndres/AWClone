using UnityEngine;
using System.Collections;


public class TileModel
{
    public ActorScript actor;

    public int X { get; }

    public int Y { get; }

    public TileModel(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}
