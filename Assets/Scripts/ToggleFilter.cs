using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ToggleFilter : MonoBehaviour
{
    [SerializeField] UniversalRendererData feature;

    void Start()
    {
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            feature.rendererFeatures[2].SetActive(false);
            feature.rendererFeatures[3].SetActive(false);
            feature.rendererFeatures[4].SetActive(false);
            feature.rendererFeatures[5].SetActive(false);
            feature.rendererFeatures[6].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            feature.rendererFeatures[2].SetActive(true);
            feature.rendererFeatures[3].SetActive(true);
            feature.rendererFeatures[4].SetActive(false);
            feature.rendererFeatures[5].SetActive(false);
            feature.rendererFeatures[6].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            feature.rendererFeatures[2].SetActive(false);
            feature.rendererFeatures[3].SetActive(false);
            feature.rendererFeatures[4].SetActive(true);
            feature.rendererFeatures[5].SetActive(false);
            feature.rendererFeatures[6].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            feature.rendererFeatures[2].SetActive(false);
            feature.rendererFeatures[3].SetActive(false);
            feature.rendererFeatures[4].SetActive(false);
            feature.rendererFeatures[5].SetActive(true);
            feature.rendererFeatures[6].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            feature.rendererFeatures[2].SetActive(false);
            feature.rendererFeatures[3].SetActive(false);
            feature.rendererFeatures[4].SetActive(false);
            feature.rendererFeatures[5].SetActive(false);
            feature.rendererFeatures[6].SetActive(true);
        }
    }
}