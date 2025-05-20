using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    /// <summary>
    /// Particule system to activate/desactivate
    /// </summary>
    public GameObject particuleSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        particuleSystem.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LightOnLightOff()
    {
        particuleSystem.SetActive(!particuleSystem.activeSelf);
    }
}
