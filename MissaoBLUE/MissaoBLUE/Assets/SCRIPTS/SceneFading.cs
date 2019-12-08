using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFading : MonoBehaviour
{
    public Texture2D fadeTexture;
    public float fadeSpeed = 0.8f;
    private int textureHierarchy = -1000;
    private float textureAlpha = 1.0f;
    private int fadeDirection = -1;

    void OnGUI()
    {

        textureAlpha += fadeDirection * fadeSpeed * Time.deltaTime;
        textureAlpha = Mathf.Clamp01(textureAlpha);
        GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, textureAlpha);
        GUI.depth = textureHierarchy;
        GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeTexture);

       
    }
 public float Fade (int direction)
        {
            fadeDirection = direction;
            return (fadeSpeed);

        }

        void OnLevelWasLoaded()
        {
            Fade(-1);
        }




}
