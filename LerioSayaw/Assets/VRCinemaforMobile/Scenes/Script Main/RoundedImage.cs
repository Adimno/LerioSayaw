using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class RoundedImage : MonoBehaviour
{
    [Range(0f, 1f)]
    public float curvness = 1f; // 0 = no curve, 1 = fully rounded

    private Image image;
    private Material roundedMaterial;

    private void Awake()
    {
        image = GetComponent<Image>();

        // Create a material for the rounded effect if it doesn't exist yet
        if (roundedMaterial == null)
        {
            Shader roundedShader = Shader.Find("UI/RoundedImage"); // Ensure you have a custom shader for rounded corners
            if (roundedShader == null)
            {
                Debug.LogError("RoundedImage shader not found. Please create a custom shader named 'UI/RoundedImage'.");
                return;
            }

            roundedMaterial = new Material(roundedShader);
        }

        image.material = roundedMaterial;
    }

    private void Update()
    {
        if (roundedMaterial != null)
        {
            // Update the curvature property in the shader
            roundedMaterial.SetFloat("_Curvness", curvness);
        }
    }
}
