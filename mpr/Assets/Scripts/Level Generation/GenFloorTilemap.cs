using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GenFloorTilemap : MonoBehaviour
{
    [SerializeField] private int roomWidth;
    [SerializeField] private int roomHeight;
    [SerializeField] private int roomsWide;
    [SerializeField] private int roomsTall;
    [SerializeField]private TileBase[] tiles;
    private Tilemap tilemap;

    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        for(int y = 0; y < roomHeight * roomsTall; y++)
        {
            for(int x = 0; x < roomWidth * roomsWide; x++)
            {
                int r = Random.Range(0, tiles.Length);
                Vector3Int position = tilemap.WorldToCell(new Vector3(x, y, 0));
                tilemap.SetTile(position, tiles[r]);
            }
        }
    }
}
