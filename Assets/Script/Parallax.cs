using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   private MeshRenderer meshRenderer;

   public float animationSpeed = 1f;

   private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // we are multiplying it on x direction animationSpeed * Time.deltaTime  and y direction will be 0
        // because it need to move on x direction and not on y direction
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime,0);
    }
}
