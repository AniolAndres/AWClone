using UnityEngine;
using UnityEditor;
using System;
using System.Collections;

public class GridToolsWindow : EditorWindow
{
    private int height;

    private int width;

    private string assetName;

    private TileView tilePrefab;


    [MenuItem("Window/Grid Creator Tool")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(GridToolsWindow));
    }

    void OnGUI()
    {
        GUILayout.Label("Grid dimensions", EditorStyles.boldLabel);

        assetName = EditorGUILayout.TextField("Prefab name", assetName);

        height = EditorGUILayout.IntField("Height", height);
        width = EditorGUILayout.IntField("Width", width);
        tilePrefab = EditorGUILayout.ObjectField("Tile prefab", tilePrefab, typeof(TileView), false) as TileView;

        if (GUILayout.Button("Create"))
        {
            if(tilePrefab == null)
            {
                throw new NotSupportedException("Tile prefab is null!");
            }

            var baseObject = new GameObject();

            var gridComponent = baseObject.AddComponent<GridManager>();

            //gridComponent.GenerateGrid(width, height, tilePrefab);

            baseObject.name = assetName;

            string localPath = "Assets/" + baseObject.name + ".prefab";

            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

            PrefabUtility.SaveAsPrefabAssetAndConnect(baseObject.gameObject, localPath, InteractionMode.UserAction);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Destroy(baseObject);

            Debug.Log("Grid created");
        }
    }
}
