using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Text text;
    public float fadetime;
    void Start()
    {
    }

    void Update()
    {
        fadetime -= Time.deltaTime;

        if (fadetime < 0)
        {
            Color color = text.color;
            color.a = color.a <= 0 ? 1 : color.a - 0.01f;
            text.color = color;
            if (color.a < 0)
            {
                text.enabled = false;
            }
        }
    }
}