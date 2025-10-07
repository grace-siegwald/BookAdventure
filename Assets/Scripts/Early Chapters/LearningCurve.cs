using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class LearningCurve : MonoBehaviour
{
    //int CurrentAge = 22;
    //public int AddedAge = 1;
    //public float Pi = 3.14f;
    //public string FirstName = "Grace";
    //public bool IsStudent = true;

    //Start of Chapter 4 --------------------------
    // public int CurrentGold = 32;

    // public bool PureOfHeart = true;
    // public bool HasSecretIncantation = false;
    // public string RareItem = "Relic Stone";

    // public string CharacterAction = "Attack";

    // public int DiceRoll = 7;

    // public int PlayerLives = 3;

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Chapter 5 ------------------------

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);


        Character hero = new Character();
        Character villain = hero;
        villain.name = "Funky Kong";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();

        Character heroine = new Character("Grace");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();



        //ComputeAge();
        //Debug.Log($"A string can have variables like '{FirstName}' inserted directly!");
        //Debug.LogFormat($"A string can have variables like {0} inserted directly!", FirstName);
        //Debug.Log("A string can have variables like '" + FirstName + "' inserted directly!");

        //int CharacterLevel = 0;
        //GenerateCharacter("Hornet", CharacterLevel);

        //int NextSkillLevel = GenerateCharacter("Hornet", CharacterLevel);
        //Debug.Log(NextSkillLevel);
        //Debug.Log(GenerateCharacter("Knight", CharacterLevel));

        //Hero's Trial
        //Debug.Log(HerosTrialMethod(10));


        //Start of Chapter 4 -----------------
        // Thievery();

        // OpenTreasureChamber();

        // PrintCharacterAction();

        // FindPartyMember();

        // FindInventoryItem();

        // HealthStatus();

    }

    // Update is called once per frame
    void Update()
    {

    }


    /*     void ComputeAge()
        {
            Debug.Log(CurrentAge + AddedAge);
        }

        public int GenerateCharacter(string name, int level)
        {
            //Debug.LogFormat("Character: {0} - Level: {1}", name, level);

            return level += 5;
        } */


    //Start of Chapter 4 --------------------------
    //     public void Thievery()
    //     {
    //         if (CurrentGold > 50)
    //         {
    //             Debug.Log("You're rolling in it!");
    //         }
    //         else if (CurrentGold < 15)
    //         {
    //             Debug.Log("Not much there to steal...");
    //         }
    //         else
    //         {
    //             Debug.Log("Looks like your purse is in the sweet spot.");
    //         }
    //     }

    //     public void OpenTreasureChamber()
    //     {
    //         if (PureOfHeart && RareItem == "Relic Stone")
    //         {
    //             if (!HasSecretIncantation)
    //             {
    //                 Debug.Log("You have the spirit, but not the knowledge.");
    //             }
    //             else
    //             {
    //                 Debug.Log("The treasure is your, worthy hero!");
    //             }
    //         }
    //         else
    //         {
    //             Debug.Log("Come back when you have what it takes...");
    //         }
    //     }

    //     public void PrintCharacterAction()
    //     {
    //         switch (CharacterAction)
    //         {
    //             case "Heal":
    //                 Debug.Log("Potion sent.");
    //                 break;
    //             case "Attack":
    //                 Debug.Log("To arms!");
    //                 break;
    //             default:
    //                 Debug.Log("Shields up..");
    //                 break;
    //         }
    //     }

    //     public void RollDice()
    //     {
    //         switch (DiceRoll)
    //         {
    //             case 7:
    //             case 15:
    //                 Debug.Log("Mediocre damage, not bad.");
    //                 break;
    //             case 20:
    //                 Debug.Log("Critical hit, the creature goes down!");
    //                 break;
    //             default:
    //                 Debug.Log("You completely missed and fell on your face.");
    //                 break;
    //         }
    //     }
    //     public void FindPartyMember()
    //     {
    //         List<string> QuestPartyMembers = new List<string>() { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight" };

    //         foreach (string partyMember in QuestPartyMembers)
    //         {
    //             Debug.LogFormat("{0} - Here!", partyMember);
    //         }

    //         int listLength = QuestPartyMembers.Count;

    //         QuestPartyMembers.Add("Craven the Necromancer");
    //         QuestPartyMembers.Insert(1, "Tanis the Thief");
    //         QuestPartyMembers.RemoveAt(0);

    //         Debug.LogFormat("Party Members: {0}", listLength);

    //         for (int i = 0; i < listLength; i++)
    //         {
    //             Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
    //             if (QuestPartyMembers[i] == "Merlin the Wise")
    //             {
    //                 Debug.Log("Glad you're here Merlin!");
    //             }
    //         }
    //     }

    //     public void FindInventoryItem()
    //     {
    //         Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    //         {
    //             { "Potion", 5 },
    //             { "Antidote", 7 },
    //             { "Asprin", 1 }
    //         };



    //         foreach (KeyValuePair<string, int> kvp in ItemInventory)
    //         {
    //             Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);

    //             if (kvp.Value <= CurrentGold)
    //             {
    //                 Debug.Log("You can afford this item!");
    //             }
    //             else
    //             {
    //                 Debug.Log("Bro, you broke...");
    //             }
    //         }
    //     }

    //     public void HealthStatus()
    //     {
    //         while (PlayerLives > 0)
    //         {
    //             Debug.Log("Still alive!");
    //             PlayerLives--;
    //         }
    //         Debug.Log("Player KO'd...");
    //     }
}