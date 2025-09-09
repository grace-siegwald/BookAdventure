using UnityEngine;
using UnityEngine.TextCore.Text;

public class LearningCurve : MonoBehaviour
{
    int CurrentAge = 22;
    public int AddedAge = 1;
    public float Pi = 3.14f;
    public string FirstName = "Grace";
    public bool IsStudent = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ComputeAge();
        //Debug.Log($"A string can have variables like '{FirstName}' inserted directly!");
        //Debug.LogFormat($"A string can have variables like {0} inserted directly!", FirstName);
        //Debug.Log("A string can have variables like '" + FirstName + "' inserted directly!");

        int CharacterLevel = 0;
        //GenerateCharacter("Hornet", CharacterLevel);

        int NextSkillLevel = GenerateCharacter("Hornet", CharacterLevel);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Knight", CharacterLevel));

        //Hero's Trial
        Debug.Log(HerosTrialMethod(10));
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Method for calculating age.
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }

    public int HerosTrialMethod(int number)
    {
        return number;
    }
}
