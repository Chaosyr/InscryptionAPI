using InscryptionAPI.Helpers;
using UnityEngine;

namespace InscryptionAPI.Ascension;

public static partial class StarterDeckExtensions
{
    private static Sprite GetPortrait(Texture2D portrait, TextureHelper.SpriteType spriteType, FilterMode? filterMode = null)
    {
        return portrait.ConvertTexture(spriteType, filterMode ?? FilterMode.Point);
    }
}
