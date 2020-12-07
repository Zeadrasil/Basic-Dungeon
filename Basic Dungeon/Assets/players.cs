using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    private int strength, agility, dexterity, wisdom, endurance, intelligence, clarity, resilience;
    private double health, stamina, mana, exp;
    private int maxHealth, maxStamina, maxMana, nextLevelExp;
    private int level, statPoints;
    private string name;
    
    public int getStrength()
    {
        return strength;
    }
    public int getAgility()
    {
        return agility;
    }
    public int getDexterity()
    {
        return dexterity;
    }
    public int getWisdom()
    {
        return wisdom;
    }
    public int getEndurance()
    {
        return endurance;
    }
    public int getIntelligence()
    {
        return intelligence;
    }
    public int getClarity()
    {
        return clarity;
    }
    public int getResilience()
    {
        return resilience;
    }
    public double getHealth()
    {
        return health;
    }
    public double getStamina()
    {
        return stamina;
    }
    public double getMana()
    {
        return mana;
    }
    public double getExp()
    {
        return exp;
    }
    public int getMaxHealth()
    {
        return maxHealth;
    }
    public int getMaxStamina()
    {
        return maxStamina;
    }
    public int getMaxMana()
    {
        return maxMana;
    }
    public int getNextLevelExp()
    {
        return nextLevelExp;
    }
    public int getLevel()
    {
        return level;
    }
    public string getName()
    {
        return name;
    }

    public void Players()
    {
        strength = 10;
        agility = 10;
        dexterity = 10;
        wisdom = 10;
        endurance = 10;
        intelligence = 10;
        clarity = 10;
        resilience = 10;
        health = 100;
        stamina = 50;
        mana = 50;
        exp = 0;
        maxHealth = 100;
        maxStamina = 50;
        maxMana = 50;
        nextLevelExp = 10;
        level = 0;
        statPoints = 0;
        name = "";
    }

    public void changeStrength(int value)
    {
        strength += value;
    }
    public void changeAgility(int value)
    {
        agility += value;
    }
    public void changeDexterity(int value)
    {
        dexterity += value;
    }
    public void changeWisdom(int value)
    {
        wisdom += value;
    }
    public void changeEndurance(int value)
    {
        endurance += value;
    }
    public void changeIntelligence(int value)
    {
        intelligence += value;
    }
    public void changeClarity(int value)
    {
        clarity += value;
    }
    public void changeResilience(int value)
    {
        resilience += value;
    }
    public void changeHealth(double value)
    {
        health += value;
    }
    public void changeStamina(double value)
    {
        stamina += value;
    }
    public void changeMana(double value)
    {
        mana += value;
    }
    public void changeExp(double value)
    {
        exp += value;
    }
    public void changeMaxHealth(int value)
    {
        maxHealth = value;
        health = maxHealth;
    }
    public void changeMaxStamina(int value)
    {
        maxStamina = value;
        stamina = maxStamina;
    }
    public void changeMaxMana(int value)
    {
        maxMana = value;
        mana = maxMana;
    }
    public void changeNextLevelExp()
    {
        changeExp((double)(-getNextLevelExp()));
        int storage = getLevel() % 30;
        switch (storage)
        {
            case 0:
            {
                nextLevelExp *= 1.1;
                break;
            }
            case 1:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (12 / 11));
                break;
            }
            case 2:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (13 / 12));
                break;
            }
            case 3:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (14 / 13));
                break;
            }
            case 4:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (15 / 14));
                break;
            }
            case 5:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (16 / 15));
                break;
            }
            case 6:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (9 / 8));
                break;
            }
            case 7:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (10 / 9));
                break;
            }
            case 8:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (11 / 10));
                break;
            }
            case 9:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (12 / 11));
                break;
            }
            case 10:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (13 / 12));
                break;
            }
            case 11:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (14 / 13));
                break;
            }
            case 12:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (31 / 28));
                break;
            }
            case 13:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (34 / 31));
                break;
            }
            case 14:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (37 / 34));
                break;
            }
            case 15:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (40 / 37));
                break;
            }
            case 16:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (43 / 40));
                break;
            }
            case 17:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (46 / 43));
                break;
            }
            case 19:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (49 / 46));
                break;
            }
            case 20:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (52 / 49));
                break;
            }
            case 21:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (14 / 13));
                break;
            }
            case 22:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (15 / 14));
                break;
            }
            case 23:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (16 / 15));
                break;
            }
            case 24:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (17 / 16));
                break;
            }
            case 25:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (18 / 17));
                break;
            }
            case 26:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (13 / 12));
                break;
            }
            case 27:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (14 / 13));
                break;
            }
            case 28:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (23 / 21));
                break;
            }
            case 29:
            {
                nextLevelExp = (Math.Ceiling(getNextLevelExp() * (25 / 23));
                break;
            }
            default:
            {
                break;
            }
        }  
    }
    public void changeLevel()
    {
        level++;
    }
    public void changeStatPoints(int s, int a, int d, int w, int e, int i, int c, int r)
    {
        int tempLevelStorage = (getLevel() - 1) / 10;
        switch (tempLevelStorage)
        {
            case 0:
            {
                statPoints += getLevel();
                changeStrength(s);
                changeAgility(a);
                changeDexterity(d);
                changeWisdom(w);
                changeEndurance(e);
                changeIntelligence(i);
                changeClarity(c);
                changeResilience(r);
                break;
            }
            case 1:
            {
                statPoints += 2 * getLevel() - 10;
                changeStrength(s * 2);
                changeAgility(a * 2);
                changeDexterity(d * 2);
                changeWisdom(w * 2);
                changeEndurance(e * 2);
                changeIntelligence(i * 2);
                changeClarity(c * 2);
                changeResilience(r * 2);
                break;
            }
            case 2:
            {
                statPoints += 3 * getLevel() - 30;
                changeStrength(s * 4);
                changeAgility(a * 4);
                changeDexterity(d * 4);
                changeWisdom(w * 4);
                changeEndurance(e * 4);
                changeIntelligence(i * 4);
                changeClarity(c * 4);
                changeResilience(r * 4);
                break;
            }
            case 3:
            {
                statPoints += 4 * getLevel() - 60;
                changeStrength(s * 6);
                changeAgility(a * 6);
                changeDexterity(d * 6);
                changeWisdom(w * 6);
                changeEndurance(e * 6);
                changeIntelligence(i * 6);
                changeClarity(c * 6);
                changeResilience(r * 6);
            }
            case 4:
            {
                statPoints += 5 * getLevel() - 100;
                changeStrength(s * 9);
                changeAgility(a * 9);
                changeDexterity(d * 9);
                changeWisdom(w * 9);
                changeEndurance(e * 9);
                changeIntelligence(i * 9);
                changeClarity(c * 9);
                changeResilience(r * 9);
                break;
            }
            case 5:
            {
                statPoints += 6 * getLevel() - 150;
                changeStrength(s * 11);
                changeAgility(a * 11);
                changeDexterity(d * 11);
                changeWisdom(w * 11);
                changeEndurance(e * 11);
                changeIntelligence(i * 11);
                changeClarity(c * 11);
                changeResilience(r * 11);
                break;
            }
            case 6:
            {
                statPoints += 7 * getLevel() - 150;
                changeStrength(s * 15);
                changeAgility(a * 15);
                changeDexterity(d * 15);
                changeWisdom(w * 15);
                changeEndurance(e * 15);
                changeIntelligence(i * 15);
                changeClarity(c * 15);
                changeResilience(r * 15);
                break;
            }
            case 7:
            {
                statPoints += 8 * getLevel() - 210;
                changeStrength(s * 17);
                changeAgility(a * 17);
                changeDexterity(d * 17);
                changeWisdom(w * 17);
                changeEndurance(e * 17);
                changeIntelligence(i * 17);
                changeClarity(c * 17);
                changeResilience(r * 17);
                break;
            }
            case 8:
            {
                statPoints += 9 * getLevel() - 280;
                changeStrength(s * 21);
                changeAgility(a * 21);
                changeDexterity(d * 21);
                changeWisdom(w * 21);
                changeEndurance(e * 21);
                changeIntelligence(i * 21);
                changeClarity(c * 21);
                changeResilience(r * 21);
                break;
            }
            case 9:
            {
                statPoints += 10 * getLevel() - 360;
                changeStrength(s * 24);
                changeAgility(a * 24);
                changeDexterity(d * 24);
                changeWisdom(w * 24);
                changeEndurance(e * 24);
                changeIntelligence(i * 24);
                changeClarity(c * 24);
                changeResilience(r * 24);
                break;
            }
            case 10:
            {
                statPoints += 11 * getLevel() - 450;
                changeStrength(s * 28);
                changeAgility(a * 28);
                changeDexterity(d * 28);
                changeWisdom(w * 28);
                changeEndurance(e * 28);
                changeIntelligence(i * 28);
                changeClarity(c * 28);
                changeResilience(r * 28);
                break;
            }
            default:
            {
                break;
            }
        }
    }
}
public class RedOrcSwordsman : Players
{
    public void RedOrcSwordsman()
    {
        changeStrength(6);
        changeIntelligence(-6);
        changeResilience(2);
        changeAgility(-2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(6, 0, 0, 0, 0, 0, 0, 2);
    }
}
public class RedOrcDefender : Players
{
    public void RedOrcDefender()
    {
        changeStrength(4);
        changeResilience(4);
        changeIntelligence(-4);
        changeAgility(-4);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(4, 0, 0, 0, 0, 0, 0, 4);
    }
}
public class RedOrcBrawler : Players
{
    public void RedOrcBrawler()
    {
        changeStrength(5);
        changeResilience(3);
        changeIntelligence(-5);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(5, 0, 0, 0, 0, 0, 0, 3);
    }
}
public class RedOrcArcher : Players
{
    public void RedOrcArcher()
    {
        changeClarity(-1);
        changeIntelligence(-3);
        changeStrength(3);
        changeDexterity(1);
        changeResilience(-2);
        changeAgility(2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 3, 1, 0, 0, 0, 0, 1);
    }
}
public class RedOrcRogue : Players
{
    public void RedOrcRogue()
    {
        changeClarity(-3);
        changeIntelligence(-3);
        changeStrength(3);
        changeDexterity(3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 1, 3, 0, 0, 0, 0, 1);
    }
}
public class RedOrcScout : Players
{
    public void RedOrcScout()
    {
        changeClarity(-2);
        changeIntelligence(-3);
        changeStrength(3);
        changeDexterity(2);
        changeResilience(-1);
        changeAgility(1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 2, 2, 0, 0, 0, 0, 1);
    }
}
public class RedOrcWizard : Players
{
    public void RedOrcWizard()
    {
        changeClarity(1);
        changeDexterity(-1);
        changeResilience(3);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 0, 0, 0, 0, 3, 1, 1);
    }
}
public class RedOrcSorceror : Players
{
    public void RedOrcSorceror()
    {
        changeClarity(3);
        changeIntelligence(-2);
        changeStrength(2);
        changeDexterity(-3);
        changeResilience(1);
        changeAgility(-1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 0, 0, 0, 0, 1, 3, 1);
    }
}
public class RedOrcMage : Players
{
    public void RedOrcMage()
    {
        changeClarity(2);
        changeIntelligence(-1);
        changeStrength(1);
        changeDexterity(-2);
        changeResilience(1);
        changeAgility(-1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 0, 0, 0, 0, 2, 2, 1);
    }
}
public class GreenOrcSwordsman : Players
{
    public void GreenOrcSwordsman()
    {
        changeStrength(5);
        changeResilience(3);
        changeIntelligence(-5);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(5, 0, 0, 0, 0, 0, 0, 3);
    }
}
public class GreenOrcDefender : Players
{
    public void GreenOrcDefender()
    {
        changeStrength(3);
        changeResilience(5);
        changeIntelligence(-3);
        changeAgility(-4);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 0, 0, 0, 0, 0, 0, 5);
    }
}
public class GreenOrcBrawler : Players
{
    public void GreenOrcBrawler()
    {
        changeStrength(4);
        changeResilience(4);
        changeIntelligence(-4);
        changeAgility(-4);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(4, 0, 0, 0, 0, 0, 0, 4);
    }
}
public class GreenOrcArcher : Players
{
    public void GreenOrcArcher()
    {
        changeClarity(-1);
        changeIntelligence(-2);
        changeStrength(2);
        changeDexterity(1);
        changeAgility(1);
        changeStrength(-1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 3, 1, 0, 0, 0, 0, 2);
    }
}
public class GreenOrcRogue : Players
{
    public void GreenOrcRogue()
    {
        changeClarity(-3);
        changeIntelligence(-2);
        changeStrength(2);
        changeDexterity(3);
        changeResilience(1);
        changeAgility(-1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 1, 3, 0, 0, 0, 0, 2);
    }
}
public class GreenOrcScout : Players
{
    public void GreenOrcScout()
    {
        changeClarity(-2);
        changeIntelligence(-2);
        changeStrength(2);
        changeDexterity(2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 2, 2, 0, 0, 0, 0, 2);
    }
}
public class GreenOrcWizard : Players
{
    public void GreenOrcWizard()
    {
        changeClarity(1);
        changeIntelligence(1);
        changeStrength(-1);
        changeDexterity(-1);
        changeResilience(2);
        changeAgility(-2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 0, 0, 0, 0, 3, 1, 2);
    }
}
public class GreenOrcSorceror : Players
{
    public void GreenOrcSorceror()
    {
        changeClarity(3);
        changeDexterity(-3);
        changeResilience(2);
        changeAgility(-2);
        changeIntelligence(-1);
        changeStrength(1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 0, 0, 0, 0, 1, 3, 2);
    }
}
public class GreenOrcMage : Players
{
    public void GreenOrcMage()
    {
        changeClarity(2);
        changeDexterity(-2);
        changeResilience(2);
        changeAgility(-2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 0, 0, 0, 0, 2, 2, 2);
    }
}
public class YellowOrcSwordsman : Players
{
    public void YellowOrcSwordsman()
    {
        changeStrength(4);
        changeResilience(4);
        changeIntelligence(-4);
        changeAgility(-4);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(4, 0, 0, 0, 0, 0, 0, 4);
    }
}
public class YellowOrcDefender : Players
{
    public void YellowOrcDefender()
    {
        changeStrength(2);
        changeResilience(6);
        changeIntelligence(-2);
        changeAgility(-6);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(2, 0, 0, 0, 0, 0, 0, 6);
    }
}
public class YellowOrcBrawler : Players
{
    public void YellowOrcBrawler()
    {
        changeStrength(3);
        changeResilience(5);
        changeIntelligence(-3);
        changeAgility(-5);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(3, 0, 0, 0, 0, 0, 0, 5);
    }
}
public class YellowOrcArcher : Players
{
    public void YellowOrcArcher()
    {
        changeClarity(-1);
        changeIntelligence(-1);
        changeStrength(1);
        changeDexterity(1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 3, 1, 0, 0, 0, 0, 3);
    }
}
public class YellowOrcRogue : Players
{
    public void YellowOrcRogue()
    {
        changeClarity(-3);
        changeIntelligence(-1);
        changeStrength(1);
        changeDexterity(3);
        changeResilience(2);
        changeAgility(-2);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 1, 3, 0, 0, 0, 0, 3);
    }
}
public class YellowOrcScout : Players
{
    public void YellowOrcScout()
    {
        changeClarity(-2);
        changeIntelligence(-1);
        changeStrength(1);
        changeDexterity(2);
        changeResilience(1);
        changeAgility(-1);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 2, 2, 0, 0, 0, 0, 3);
    }
}
public class YellowOrcWizard : Players
{
    public void YellowOrcWizard()
    {
        changeClarity(1);
        changeIntelligence(2);
        changeStrength(-2);
        changeDexterity(-1);
        changeResilience(3);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 0, 0, 0, 0, 3, 1, 3);
    }
}
public class YellowOrcSorceror : Players
{
    public void YellowOrcSorceror()
    {
        changeClarity(3);
        changeDexterity(-3);
        changeResilience(3);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 0, 0, 0, 0, 1, 3, 3);
    }
}
public class YellowOrcMage : Players
{
    public void YellowOrcMage()
    {
        changeClarity(2);
        changeIntelligence(1);
        changeStrength(-1);
        changeDexterity(-2);
        changeResilience(3);
        changeAgility(-3);
    }

    public void levelUp()
    {
        changeHealth(getMaxHealth());
        changeStamina(getMaxStamina());
        changeMana(getMaxMana());
        changeNextLevelExp();
        changeLevel();
        changeStatPoints(1, 0, 0, 0, 0, 2, 2, 3);
    }
}