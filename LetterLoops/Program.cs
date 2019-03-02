﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some letters!");
            var input = Console.ReadLine().ToLower();
            var loopCount = 0;
            //var myCharacters = new List<string>();

            //foreach (var character in input)
            //{
            //    var letterString = character.ToString().ToUpper();
            //    letterString += new string(character, loopCount);

            //    myCharacters.Add(letterString);

            //    loopCount++;
            //}

            //Console.WriteLine(string.Join('-', myCharacters));

            var output = string.Join('-', input.ToCharArray().Select(c => c.ToString().ToUpper() + new string(c, loopCount++)));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
