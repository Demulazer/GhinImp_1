using GhinImp;

var characterGroup = new CharacterGroup();


characterGroup.AddCharacter("Diluc", "Pyro", 100, new Skill { SkillName = "Searing Onslaught", Damage = 200 });
characterGroup.AddCharacter("Mona", "Hydro", 80, new Skill { SkillName = "Mirror Reflection of Doom", Damage = 150 });
characterGroup.AddCharacter("Venti", "Anemo", 70, new Skill { SkillName = "Skyward Sonnet", Damage = 120 });

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
