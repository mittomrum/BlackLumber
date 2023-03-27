
using UnityEngine;

public class TerrainGenerator : MonoBehaviour   {
    public int depth = 20;
    public int width = 500;
    public int height = 500;

    private void Start() {
        Terrain terrain = GetComponent<Terrain>();
    }

}