using UnityEngine;

public class BGParallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 0.25f;

    private void Awake() 
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() 
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}