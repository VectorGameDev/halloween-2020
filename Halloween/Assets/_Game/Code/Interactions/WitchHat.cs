﻿// Vector Game Dev
// Halloween 2020
// Game Dev Session

// Which Hat
// This is the hat that will give abilities to the
// player.
// Also it attaches itself to the player.



public class WitchHat : Interaction
{

    public override void Interact ( PlayerController controller )
    {

        base.Interact ( controller );

        // disable the Interact component
        // so that the player cannot active this again
        isActive = false;

        // attach itself to the player
        controller.SetNewHat ( transform );

    }

}
