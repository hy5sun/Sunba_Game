using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonikaSpeech : MonoBehaviour
{
    float time;

    void Update()
    {
        if (Button._stage == "stage2") //���ī
        {
            if (time < 0.5f)
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - time);
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, time);
                if (time > 1f)
                {
                    time = 0;
                }
            }

            time += Time.deltaTime;

        }

    }
}
