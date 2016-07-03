using UnityEngine;
using System.Collections;

public class Experience {
    public int experience;
    public int tonextlevel;
    static float experienceprogress;
    Experience(){ experience = 0; }
    Experience(int exp)
    { this.experience = exp; }
    private void SetExp(int exp){this.experience = exp;}
    public int GetExp() { return experience; }
    public float GetExperienceProgress()
    {   return (float)(experience) / (float)(tonextlevel);}
    public static Experience operator +(Experience exp1, Experience exp2)
    {
        return new Experience(exp1.experience + exp2.experience);
    }
    public override string ToString()
    {
        return this.experience.ToString();
    }
}
