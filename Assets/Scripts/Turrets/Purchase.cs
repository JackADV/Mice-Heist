using UnityEngine;

public class Purchase : MonoBehaviour
{
    public Color hoverColor;
    public Color clickColor;

    public GameObject impacteffect;

    private Renderer rend;
    private Color startColor;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseUpAsButton()
    {
        GameObject effectIns = (GameObject)Instantiate(impacteffect);
        Destroy(effectIns, 2f);

        rend.material.color = clickColor;
    }
    

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
