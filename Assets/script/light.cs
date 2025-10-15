using System.Collections;
using UnityEngine;

public class TrafficLightCycleight : MonoBehaviour
{
    public Renderer redLight;
    public Renderer yellowLight;
    public Renderer greenLight;

    private void Start()
    {
        StartCoroutine(TrafficLightCycle());
    }

    IEnumerator TrafficLightCycle()
    {
        while (true)
        {

            SetLight(true, false, false);
            yield return new WaitForSeconds(5f);


            SetLight(false, true, false);
            yield return new WaitForSeconds(2f);


            SetLight(false, false, true);
            yield return new WaitForSeconds(5f);


            SetLight(false, true, false);
            yield return new WaitForSeconds(2f);
        }
    }

    void SetLight(bool redOn, bool yellowOn, bool greenOn)
    {

        SetEmission(redLight, redOn);
        SetEmission(yellowLight, yellowOn);
        SetEmission(greenLight, greenOn);

    }

    void SetEmission(Renderer rend, bool on)
    {
        if (on)
        {
            rend.material.EnableKeyword("_EMISSION");
        }
        else
        {
            rend.material.DisableKeyword("_EMISSION");
        }
    }
}
