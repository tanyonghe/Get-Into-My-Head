using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    public Button button;
    public float incrVal = 0.07f;
    public float decrVal = 0.03f;
    private float currVal = 0.5f;

    // Update is called once per frame
    void Update() {
        decrement();
        updateColor();

    }

    void updateColor()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = new Color(1 - currVal, currVal, currVal);
        button.colors = cb;
    }
    
        void increment()
    {
        if (currVal + incrVal <= 1)
        {
            currVal += incrVal;
        }
    }
    void decrement()
    {
        float valToDecr = decrVal * Time.deltaTime;

        Debug.Log(currVal);

        if (currVal - valToDecr >= 0)
        {
            currVal -= valToDecr;
        }
    }
}
