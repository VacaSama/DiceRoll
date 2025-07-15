using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll;
/// <summary>
/// The Die Class: Represents a die with a specified number of sides.
/// Often used in games, but can be used for other things and
/// die have random number generation.
/// </summary>
public class Die
{
    private static readonly Random rand = new();
    private const byte MAX_SIDES = 20;
    /// <summary>
    /// Gets the number of sides of the die.
    /// </summary>
    public byte NumberOfSides { get; init; } // private set; because we don't want external changes

    public byte FaceValue { get; private set; } // this is the value of the die when it is done rolling

    /// <summary>
    /// Initializes a new instance of the 
    /// <see cref="Die"/> class with a specified number of sides.
    /// </summary>
    /// <param name="numSides"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Die(byte numSides) // byte is used to limit the number of sides possible to 0 - 255
    {
        // here we are going to make an exception if the number is euqal to 0 or less than 20 sides 
        if (numSides == 0 || numSides > MAX_SIDES)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides),
                $"{nameof(numSides)} has to be greater than 0 and less than 225");
        }
        NumberOfSides = numSides;
        // Forces the die to start at a random face value when created.
        Roll();
    }
    /// <summary>
    /// Simulates rolling the die and returns the resulting face value.
    /// </summary>
    /// <remarks>The face value is determined by generating a random number between 1 and the number of sides
    /// on the die. The result is stored in the <see cref="FaceValue"/> property.</remarks>
    /// <returns>A byte representing the face value of the die after the roll. The value will be between 1 and <see
    /// cref="NumberOfSides"/>, inclusive.</returns>

    public byte Roll()
    {
        FaceValue = Convert.ToByte(rand.Next(1, NumberOfSides));

        return FaceValue;
    }
}

