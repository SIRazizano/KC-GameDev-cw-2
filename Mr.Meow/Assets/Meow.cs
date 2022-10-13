using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "|| Mr.Meow ||";
        int heroHeight = 166;
        int heroAge = 16;
        string heroSuperPower = "!! Mr.Meow Punch !!";
        string villainName = "|| Dog Scoobar ||";
        float villainHeight = 1.5f;
        int villainAge = 4;
        string villainSuperPower = "!! Baby Sharky Dog !!";
        int ageDifference = heroAge - villainAge;
        print("Your Hero Is : " + heroName + ", his age is : " + heroAge + ". His height is so much difficult to believe but... : " + heroHeight + "cm!!! He has a powerfull superpower he named it: " + heroSuperPower);
        print("Just wait for it... Your opponent is : " + villainName + ", his age is : " + villainAge + ". His height says he is nothing at all... : " + villainHeight + "cm!!! He has a baby superpower he named it: " + villainSuperPower);

        heroHeight += 5;
        villainSuperPower = "None";
        print($"Your Hero Is : {heroName}, his age is : {heroAge}. His height is so much difficult to believe but... : {heroHeight}cm!!! ( edited :) ) He has a powerfull superpower he named it: {heroSuperPower}");
        print($"Just wait for it... Your opponent is : {villainName}, his age is : {villainAge}. His height says he is nothing at all... : {villainHeight}cm!!! He changed his superpower to: {villainSuperPower}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
