using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Text text;
    public float fadetime;
    void Start()
    {
        text.enabled = false;
    }

    void Update()
    {
        fadetime -= Time.deltaTime;

        if (fadetime < 0)
        {
            Color color = text.color;
            color.a = color.a <= 0 ? 0 : color.a + 0.01f;
            text.color = color;
            if (color.a > 1)
            {
                text.enabled = true;
            }
        }
    }
}