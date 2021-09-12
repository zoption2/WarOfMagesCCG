using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountVisual : MonoBehaviour
{
    [SerializeField] private List<GameObject> elements;

    public void ShowAllOf(int count)
    {
        if (count <= elements.Count)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].SetActive(i < count);
            }
        }
        else
        {
            ShowErrorMassage();
        }
    }

    public void ShowIndexed(int index)
    {
        if (index < elements.Count)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].SetActive(i == index);
            }
        }
        else
        {
            ShowErrorMassage();
        }
    }

    private void ShowErrorMassage()
    {
        throw new System.ArgumentOutOfRangeException();
    }
}
