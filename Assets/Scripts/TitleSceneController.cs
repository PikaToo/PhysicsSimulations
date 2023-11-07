using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SampleStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CannonStart()
    {
        SceneManager.LoadScene("CannonScene");
    }

    public void ForcesStart()
    {
        SceneManager.LoadScene("ForcesScene");
    }

    public void SnellsStart()
    {
        SceneManager.LoadScene("SnellsScene");
    }

    public void ThermalStart()
    {
        SceneManager.LoadScene("ThermalScene");
    }

    public void CircularStart()
    {
        SceneManager.LoadScene("CircularScene");
    }

    public void HarmonicStart()
    {
        SceneManager.LoadScene("HarmonicScene");
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
