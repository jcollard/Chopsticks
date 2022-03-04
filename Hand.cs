using System;

public class Hand 
{
    private int digits = 1;
    public int Digits 
    {
        get => digits;
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Cannot set digits to a negative value.");
            }
            digits = value % 6;
        }
    }

    public bool IsAlive => digits > 0;
    public bool IsDead => !IsAlive;

    /// <summary>
    /// Given a hand to attack, attacks the hand
    /// </summary>
    public void Attack(Hand toAttack) => toAttack.Digits += this.digits;
    
    public void Transfer(Hand toTransfer, int amount)
    {
        if (this.digits < amount)
        {
            throw new ArgumentException("Cannot transfer more digits than a hand has.");
        }
        if (toTransfer.Digits + amount > 4)
        {
            throw new ArgumentException("Cannot transfer more digits than a hand can have");
        }
        toTransfer.Digits += amount;
        this.Digits  -= amount;
    }
    
}