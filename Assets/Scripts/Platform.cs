using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float GetSize()
    {
        return spriteRenderer.bounds.max.x - spriteRenderer.bounds.min.x;
    }
}
