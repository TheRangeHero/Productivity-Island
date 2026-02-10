using UnityEngine;
using UnityEditor;

public class RenameSelected
{
    [MenuItem("Tools/Rename Selected")]

    static void Rename()
    {
        GameObject[] selected = Selection.gameObjects;

        if (selected.Length == 0)
        {
            Debug.LogWarning("No objects selected.");
            return;
        }

        for (int i = 0; i < selected.Length; i++)
        {
            selected[i].name = $"{selected[i].transform.parent.name}_{i + 1}";
        }
    }
}
