using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserAvatar : MonoBehaviour
{
    [SerializeField] private int _skintTintIndex;
    [SerializeField] private int _pantColorIndex;
    [SerializeField] private int _shirtColorIndex;
    [SerializeField] private int _shirtStyleIndex;
    [SerializeField] private int _hairColorIndex;
    [SerializeField] private int _hairStyleIndex;
    [SerializeField] private int _faceIndex;
    [SerializeField] private int _footstyleIndex;
    
    [SerializeField] private GameObject[] head;
    [SerializeField] private GameObject[] neck;
    [SerializeField] private GameObject[] face;
    [SerializeField] private GameObject[] pants;
    [SerializeField] private List<Array> hairStyle;
    [SerializeField] private List<Array> shirtStyle;
    [SerializeField] private GameObject[] leftArm, rightArm;
    [SerializeField] private GameObject[] leftHand, rightHand;
    [SerializeField] private GameObject[] leftLeg, rightLeg;
    [SerializeField] private GameObject[] leftFoot, rightFoot;
    public void ChangeIndex(int partIndex, int value)
    {
        switch (partIndex)
        {
            case 0:
                _skintTintIndex += value;
                break;
            case 1:
                _pantColorIndex += value;
                break;
            case 2:
                _shirtColorIndex += value;
                break;
            case 3:
                _shirtStyleIndex += value;
                break;
            case 4:
                _hairColorIndex += value;
                break;
            case 5:
                _hairStyleIndex += value;
                break;
            case 6:
                _faceIndex += value;
                break;
        }
        UpdateUser();
    }

    private void UpdateUser()
    {
        for (int i = 0; i < head.Length; i++)
        {
            if (i != _skintTintIndex)
            {
                head[i].SetActive(false);
            }
            else
            {
                head[i].SetActive(true);
            }
        }
        for (int i = 0; i < neck.Length; i++)
        {
            if (i != _skintTintIndex)
            {
                neck[i].SetActive(false);
            }
            else
            {
                neck[i].SetActive(true);
            }
        }
        for (int i = 0; i < face.Length; i++)
        {
            if (i != _faceIndex)
            {
                face[i].SetActive(false);
            }
            else
            {
                face[i].SetActive(true);
            }
        }
        for (int i = 0; i < pants.Length; i++)
        {
            if (i != _pantColorIndex)
            {
                pants[i].SetActive(false);
            }
            else
            {
                pants[i].SetActive(true);
            }
        }
        for (int i = 0; i < hairStyle.Count; i++)
        {
            for (int j = 0; j < hairStyle[i].Objects.Length; j++)
            {
                if (i != _hairColorIndex)
                {
                    hairStyle[i].Objects[j].SetActive(false);
                }
                else
                {
                    if (j != _hairStyleIndex)
                    {
                        hairStyle[i].Objects[j].SetActive(false);
                    }
                    else
                    {
                        hairStyle[i].Objects[j].SetActive(true);    
                    }
                }
            }
        }
 
        for (int i = 0; i < shirtStyle.Count; i++)
        {
            for (int j = 0; j < shirtStyle[i].Objects.Length; j++)
            {
                if (i != _shirtColorIndex)
                {
                    shirtStyle[i].Objects[j].SetActive(false);
                }
                else
                {
                    if (j != _shirtStyleIndex)
                    {
                        shirtStyle[i].Objects[j].SetActive(false);
                    }
                    else
                    {
                        shirtStyle[i].Objects[j].SetActive(true);    
                    }
                }
            }
        }

        for (int i = 0; i < leftHand.Length; i++)
        {
            if (i != _skintTintIndex)
            {
                rightHand[i].SetActive(false);
            }
            else
            {
                rightHand[i].SetActive(true);
            }
        }
        for (int i = 0; i < rightHand.Length; i++)
        {
            if (i != _skintTintIndex)
            {
                leftHand[i].SetActive(false);
            }
            else
            {
                leftHand[i].SetActive(true);
            }
        }
        for (int i = 0; i < leftArm.Length; i++)
        {
            if (i != _shirtColorIndex)
            {
                leftArm[i].SetActive(false);
            }
            else
            {
                leftArm[i].SetActive(true);
            }
        }
        for (int i = 0; i < rightArm.Length; i++)
        {
            if (i != _shirtColorIndex)
            {
                rightArm[i].SetActive(false);
            }
            else
            {
                rightArm[i].SetActive(true);
            }
        }
        for (int i = 0; i < leftFoot.Length; i++)
        {
            if (i != _footstyleIndex)
            {
                leftFoot[i].SetActive(false);
            }
            else
            {
                leftFoot[i].SetActive(true);
            }
        }
        for (int i = 0; i < rightFoot.Length; i++)
        {
            if (i != _footstyleIndex)
            {
                rightFoot[i].SetActive(false);
            }
            else
            {
                rightFoot[i].SetActive(true);
            }
        }
        for (int i = 0; i < leftLeg.Length; i++)
        {
            if (i != _pantColorIndex)
            {
                leftLeg[i].SetActive(false);
            }
            else
            {
                leftLeg[i].SetActive(true);
            }
        }
        for (int i = 0; i < rightLeg.Length; i++)
        {
            if (i != _pantColorIndex)
            {
                rightLeg[i].SetActive(false);
            }
            else
            {
                rightLeg[i].SetActive(true);
            }
        }
    }

    [Serializable]
    class Array
    {
        public GameObject[] Objects;
    }
}
