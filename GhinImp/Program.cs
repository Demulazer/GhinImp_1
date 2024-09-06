using GhinImp;

var characterGroup = new CharacterGroup(new List<Character>());


characterGroup.AddCharacter("Fire Pudge", "Pyro", 100, new Skill { SkillName = "Searing Onslaught", Damage = 200 });
characterGroup.AddCharacter("Fire Pudge nomer 2", "Pyro", 200, new Skill { SkillName = "Searing Pudge", Damage = 2000 });
characterGroup.AddCharacter("Water Pudge", "Hydro", 80, new Skill { SkillName = "Mirror Reflection of Doom", Damage = 150 });
characterGroup.AddCharacter("Mnemonic Pudge", "Anemo", 70, new Skill { SkillName = "Skyward Sonnet", Damage = 120 });


var attackCalculator = new AttackCalculator();

var highAttackers = characterGroup.FilterCharacters(c => attackCalculator.CalculateAverageAttack(c) > 80);

foreach (var character in highAttackers)
{
    Console.WriteLine(
        $"Character: {character.Name}, Average Attack: {attackCalculator.CalculateAverageAttack(character):F2}");
}

var sortedCharacters = characterGroup.SortCharactersByName();

foreach (var character in sortedCharacters)
{
    Console.WriteLine($"Character: {character.Name}");
}

Console.WriteLine($"Number of Pyro characters: {characterGroup.CountCharactersByElement("Pyro")}");
