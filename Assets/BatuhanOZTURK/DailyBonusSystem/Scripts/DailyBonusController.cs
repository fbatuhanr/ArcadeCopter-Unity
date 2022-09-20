using System;
using UnityEngine;
using System.Collections;
using System.Linq;

public class DailyBonusController : MonoBehaviour
{
    public BonusItem[] BonusItems;
    public RectTransform Arrow;
    public AudioSource SpineSound;
    public AudioSource ChoiceEndedSound;

    void Update () {
        Time.timeScale = 1;
    }

    public void ChoiceRandom()
    {
        var choice = ProbabilityController.ChoiceRandom(BonusItems);
        StartCoroutine(
            RotateToAngle(new Vector3(0,0,-1),
            Arrow.rotation.eulerAngles.z,
            Arrow.rotation.eulerAngles.z + (360 - Arrow.rotation.eulerAngles.z) + BonusItems[choice].Angle, 15, EndRandomChoice));
    }

    public void EndRandomChoice()
    {
        ChoiceEndedSound.Play();
    }

    IEnumerator RotateToAngle(Vector3 rotateAxis,float currentAngle, float targetAngleValue,  float speed = 30, Action endFired = null)
    {
        var itemSoundAngle = currentAngle + (360/BonusItems.Length);
        while (true)
        {
            var step = ((targetAngleValue - currentAngle) + speed) * Time.deltaTime;
            if (currentAngle + step > targetAngleValue)
            {
                if (targetAngleValue == 675)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = true;

                    targetAngleValue = 0;
                }            
                else if (targetAngleValue == 630)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = true;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }              
                else if (targetAngleValue == 585)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = true;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }
                else if (targetAngleValue == 540)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = true;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }
                else if (targetAngleValue == 495)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = true;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }         
                else if (targetAngleValue == 450)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = true;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }           
                else if (targetAngleValue == 405)
                {
                    GunlukBonusOdul.Yuzde2 = false;
                    GunlukBonusOdul.Yuzde8 = true;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }
                else if (targetAngleValue == 360)
                {
                    GunlukBonusOdul.Yuzde2 = true;
                    GunlukBonusOdul.Yuzde8 = false;
                    GunlukBonusOdul.Yuzde10_1 = false;
                    GunlukBonusOdul.Yuzde25_1 = false;
                    GunlukBonusOdul.Yuzde5 = false;
                    GunlukBonusOdul.Yuzde10_2 = false;
                    GunlukBonusOdul.Yuzde15 = false;
                    GunlukBonusOdul.Yuzde25_2 = false;

                    targetAngleValue = 0;
                }

                step = targetAngleValue - currentAngle;
                Arrow.Rotate(rotateAxis, step);
                if (endFired != null)
                    endFired();

                break;
            }
            currentAngle += step;
            if (currentAngle >= itemSoundAngle)
            {
                SpineSound.Play();
                itemSoundAngle = currentAngle + (360 / BonusItems.Length);
            }
            Arrow.Rotate(rotateAxis, step);

            yield return null;
        }
    }
}