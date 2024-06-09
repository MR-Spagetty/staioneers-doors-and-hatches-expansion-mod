using System;
using HarmonyLib;
using StationeersMods.Interface;

public class DoorsAndHatches : ModBehaviour
{
    public override void OnLoaded(ContentHandler contentHandler)
    {
        UnityEngine.Debug.Log("Hello From doors and hatches");
        Harmony harmony = new Harmony("DoorsAndHatches");
        doorsandhatches.PrefabPatch.prefabs = contentHandler.prefabs;
        harmony.PatchAll();
        UnityEngine.Debug.Log("DoorsAndHatches Loaded with " + contentHandler.prefabs.Count + " prefab(s)");
    }
}