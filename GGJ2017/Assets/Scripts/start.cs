using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour {

    public Sprite[] sprites;
    public int current = 0;

    void Start()
    {

        SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();

        //StartCoroutine(FlashSprites(sprites, 5, 0.05f));
        StartCoroutine(FlashSprites(sprites, 50, 0.4f));
    }


    IEnumerator FlashSprites(SpriteRenderer[] sprites, int numTimes, float delay, bool disable = false)
    {
        // number of times to loop
        for (int loop = 0; loop < numTimes; loop++)
        {
            // cycle through all sprites
            for (int i = 0; i < sprites.Length; i++)
            {
                if (disable)
                {
                    // for disabling
                    sprites[i].enabled = false;
                }
                else
                {
                    // for changing the alpha
                    //sprites[i].color = new Color(sprites[i].color.r, sprites[i].color.g, sprites[i].color.b, 0.5f);
                    sprites[i].color = new Color(sprites[i].color.r, sprites[i].color.g, sprites[i].color.b, 0f);
                }
            }

            // delay specified amount
            yield return new WaitForSeconds(delay);

            // cycle through all sprites
            for (int i = 0; i < sprites.Length; i++)
            {
                if (disable)
                {
                    // for disabling
                    sprites[i].enabled = true;
                }
                else
                {
                    // for changing the alpha
                    sprites[i].color = new Color(sprites[i].color.r, sprites[i].color.g, sprites[i].color.b, 1);
                }
            }

            // delay specified amount
            yield return new WaitForSeconds(delay);
        }
    }

}