﻿using AutoBattle.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static AutoBattle.Types;

namespace AutoBattle.Characters
{
    /// <summary>
    /// CharacterFactory holds the base logic to create an instance of Character and initialize its fields.
    /// </summary>
    public class CharacterFactory
    {
        public static Character CreateCharacter(CharacterClass characterClass, int index, bool isPlayer)
        {
            var character = new Character(characterClass, isPlayer);
            character.Health = 100;
            character.BaseDamage = 20;
            character.PlayerIndex = index;

            return character;
        }
    }
}