using System.Linq;
public class Player
{
    private Hand[] hands = { new Hand(), new Hand() };

    public Hand LeftHand => hands[0];
    public Hand RightHand => hands[1];

    /// <summary>
    /// A Player is Dead if they are not alive
    /// </summary>
    public bool IsDead => !IsAlive;

    /// <summary>
    /// A player is alive if any of their hands are alive
    /// </summary>
    public bool IsAlive => hands.Any((h) => h.IsAlive);

    public string GetInfo() => $"Left: {LeftHand.Digits} | Right: {RightHand.Digits}";

}