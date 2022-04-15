using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustHander : MonoBehaviour
{

    private Color color;

    void Start()
    {
        color = color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // ��
            color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // ���F
            color = new Color(0.0f, 1.0f, 1.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // ��
            color = new Color(0.0f, 1.0f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // ��
            color = new Color(1.0f, 1.0f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // ��
            color = new Color(1.0f, 0.5f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // ��
            color = new Color(1.0f, 0.0f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // ��
            color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // ��
            color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // �\��
            color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            // �\��
            color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        }
        else
        {

        }


    }

    public Color SetColor()
    {
        return color;
    }
}
