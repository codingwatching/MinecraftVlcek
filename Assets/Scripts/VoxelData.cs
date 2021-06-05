using UnityEngine;

public static class VoxelData
{
    public static readonly int ChunkWidth = 16;
    public static readonly int ChunkHeight = 128;
    public static readonly int TextureAliasSizeInBlocks = 4;
    public static float NormalizedBlockTexturesSize => 1f / (float)TextureAliasSizeInBlocks;

    public static readonly Vector3[] SideChecks =
    {
        new Vector3(0.0f, 0.0f, -1.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, -1.0f, 0.0f),
        new Vector3(-1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f)
    };

    /// <summary>
    /// Every cube has 8 vertexes, each vertex has a different x, y, z coordinates
    /// depending on its position.
    /// </summary>
    public static readonly Vector3[] VoxelVertices =
    {
        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f),
    };

    /// <summary>
    /// Each array entry is one square of the cube (two triangles combined),
    /// i.e. Top Face is the top side of the cube
    /// (vertexes 3, 7, 2 are first triangle and 2, 7, 6 is the second one)
    /// </summary>
    public static readonly int[,] VoxelSides =
    {
        {0, 3, 1, 2}, // Back Face
		{5, 6, 4, 7}, // Front Face
		{3, 7, 2, 6}, // Top Face
		{1, 5, 0, 4}, // Bottom Face
		{4, 7, 0, 3}, // Left Face
		{1, 2, 5, 6}  // Right Face
    };

    public static readonly Vector2[] VoxelUvs =
    {
        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 1.0f),
    };
}
