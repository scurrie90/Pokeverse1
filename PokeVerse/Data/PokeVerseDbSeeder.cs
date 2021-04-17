﻿using Microsoft.EntityFrameworkCore;
using PokeVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeVerse.Data
{
    public class PokeVerseDbSeeder
    {
        public static async Task SeedPokeData(PokeVerseDbContext pokeVerseContext)
        {
            if (!await pokeVerseContext.Pokemon.AnyAsync())
            {
                await pokeVerseContext.Pokemon.AddRangeAsync(GetPreconfiguredPokemon());
                await pokeVerseContext.SaveChangesAsync();
            }

            if (!await pokeVerseContext.Types.AnyAsync())
            {
                await pokeVerseContext.Types.AddRangeAsync(GetPreconfiguredTypes());
                await pokeVerseContext.SaveChangesAsync();
            }
        }

        static IEnumerable<Pokemon> GetPreconfiguredPokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon(1, "Bulbasaur", "Grass", "Poison", 49, 49, 45),
                new Pokemon(2, "Ivysaur", "Grass", "Poison", 62, 63, 60),
                new Pokemon(3, "Venusaur", "Grass", "Poison", 82, 83, 80),
                new Pokemon(4, "Charmander", "Fire", "", 52, 43, 65),
                new Pokemon(5, "Charmeleon", "Fire", "", 64, 58, 80),
                new Pokemon(6, "Charizard", "Fire", "Flying", 84, 78, 100),
                new Pokemon(7, "Squirtle", "Water", "", 48, 65, 43),
                new Pokemon(8, "Wartortle", "Water", "", 63, 80, 58),
                new Pokemon(9, "Blastoise", "Water", "", 83, 100, 78),
                new Pokemon(10, "Caterpie", "Bug", "", 30, 35, 45),
                new Pokemon(11, "Metapod", "Bug", "", 20, 55, 30),
                new Pokemon(12, "Butterfree", "Bug", "Flying", 45, 50, 70),
                new Pokemon(13, "Weedle", "Bug", "Poison", 35, 30, 50),
                new Pokemon(14, "Kakuna", "Bug", "Poison", 25, 50, 35),
                new Pokemon(15, "Beedrill", "Bug", "Poison", 90, 40, 75),
                new Pokemon(16, "Pidgey", "Normal", "Flying", 45, 40, 56),
                new Pokemon(17, "Pidgeotto", "Normal", "Flying", 60, 55, 71),
                new Pokemon(18, "Pidgeot", "Normal", "Flying", 80, 75, 101),
                new Pokemon(19, "Rattata", "Normal", "", 56, 35, 72),
                new Pokemon(20, "Raticate", "Normal", "", 81, 60, 97),
                new Pokemon(21, "Spearow", "Normal", "Flying", 60, 30, 70),
                new Pokemon(22, "Fearow", "Normal", "Flying", 90, 65, 100),
                new Pokemon(23, "Ekans", "Poison", "", 60, 44, 55),
                new Pokemon(24, "Arbok", "Poison", "", 95, 69, 80),
                new Pokemon(25, "Pikachu", "Electric", "", 55, 40, 90),
                new Pokemon(26, "Raichu", "Electric", "", 90, 55, 110),
                new Pokemon(27, "Sandshrew", "Ground", "", 75, 85, 40),
                new Pokemon(28, "Sandslash", "Ground", "", 100, 110, 65),
                new Pokemon(29, "Nidoran♀", "Poison", "", 47, 52, 41),
                new Pokemon(30, "Nidorina", "Poison", "", 62, 67, 56),
                new Pokemon(31, "Nidoqueen", "Poison", "Ground", 92, 87, 76),
                new Pokemon(32, "Nidoran♂", "Poison", "", 57, 40, 50),
                new Pokemon(33, "Nidorino", "Poison", "", 72, 57, 65),
                new Pokemon(34, "Nidoking", "Poison", "Ground", 102, 77, 85),
                new Pokemon(35, "Clefairy", "Fairy", "", 45, 48, 35),
                new Pokemon(36, "Clefable", "Fairy", "", 70, 73, 60),
                new Pokemon(37, "Vulpix", "Fire", "", 41, 40, 65),
                new Pokemon(38, "Ninetales", "Fire", "", 76, 75, 100),
                new Pokemon(39, "Jigglypuff", "Normal", "Fairy", 45, 20, 20),
                new Pokemon(40, "Wigglytuff", "Normal", "Fairy", 70, 45, 45),
                new Pokemon(41, "Zubat", "Poison", "Flying", 45, 35, 55),
                new Pokemon(42, "Golbat", "Poison", "Flying", 80, 70, 90),
                new Pokemon(43, "Oddish", "Grass", "Poison", 50, 55, 30),
                new Pokemon(44, "Gloom", "Grass", "Poison", 65, 70, 40),
                new Pokemon(45, "Vileplume", "Grass", "Poison", 80, 85, 50),
                new Pokemon(46, "Paras", "Bug", "Grass", 70, 55, 25),
                new Pokemon(47, "Parasect", "Bug", "Grass", 95, 80, 30),
                new Pokemon(48, "Venonat", "Bug", "Poison", 55, 50, 45),
                new Pokemon(49, "Venomoth", "Bug", "Poison", 65, 60, 90),
                new Pokemon(50, "Diglett", "Ground", "", 55, 25, 95),
                new Pokemon(51, "Dugtrio", "Ground", "", 100, 50, 120),
                new Pokemon(52, "Meowth", "Normal", "", 45, 35, 90),
                new Pokemon(53, "Persian", "Normal", "", 70, 60, 115),
                new Pokemon(54, "Psyduck", "Water", "", 52, 48, 55),
                new Pokemon(55, "Golduck", "Water", "", 82, 78, 85),
                new Pokemon(56, "Mankey", "Fighting", "", 80, 35, 70),
                new Pokemon(57, "Primeape", "Fighting", "", 105, 60, 95),
                new Pokemon(58, "Growlithe", "Fire", "", 70, 45, 60),
                new Pokemon(59, "Arcanine", "Fire", "", 110, 80, 95),
                new Pokemon(60, "Poliwag", "Water", "", 50, 40, 90),
                new Pokemon(61, "Poliwhirl", "Water", "", 65, 65, 90),
                new Pokemon(62, "Poliwrath", "Water", "Fighting", 95, 95, 70),
                new Pokemon(63, "Abra", "Psychic", "", 20, 15, 90),
                new Pokemon(64, "Kadabra", "Psychic", "", 35, 30, 105),
                new Pokemon(65, "Alakazam", "Psychic", "", 50, 45, 120),
                new Pokemon(66, "Machop", "Fighting", "", 80, 50, 35),
                new Pokemon(67, "Machoke", "Fighting", "", 100, 70, 45),
                new Pokemon(68, "Machamp", "Fighting", "", 130, 80, 55),
                new Pokemon(69, "Bellsprout", "Grass", "Poison", 75, 35, 40),
                new Pokemon(70, "Weepinbell", "Grass", "Poison", 90, 50, 55),
                new Pokemon(71, "Victreebel", "Grass", "Poison", 105, 65, 70),
                new Pokemon(72, "Tentacool", "Water", "Poison", 40, 35, 70),
                new Pokemon(73, "Tentacruel", "Water", "Poison", 70, 65, 100),
                new Pokemon(74, "Geodude", "Rock", "Ground", 80, 100, 20),
                new Pokemon(75, "Graveler", "Rock", "Ground", 95, 115, 35),
                new Pokemon(76, "Golem", "Rock", "Ground", 120, 130, 45),
                new Pokemon(77, "Ponyta", "Fire", "", 85, 55, 90),
                new Pokemon(78, "Rapidash", "Fire", "", 100, 70, 105),
                new Pokemon(79, "Slowpoke", "Water", "Psychic", 65, 65, 15),
                new Pokemon(80, "Slowbro", "Water", "Psychic", 75, 110, 30),
                new Pokemon(81, "Magnemite", "Electric", "Steel", 35, 70, 45),
                new Pokemon(82, "Magneton", "Electric", "Steel", 60, 95, 70),
                new Pokemon(83, "Farfetch'd", "Normal", "Flying", 90, 55, 60),
                new Pokemon(84, "Doduo", "Normal", "Flying", 85, 45, 75),
                new Pokemon(85, "Dodrio", "Normal", "Flying", 110, 70, 110),
                new Pokemon(86, "Seel", "Water", "", 45, 55, 45),
                new Pokemon(87, "Dewgong", "Water", "Ice", 70, 80, 70),
                new Pokemon(88, "Grimer", "Poison", "", 80, 50, 25),
                new Pokemon(89, "Muk", "Poison", "", 105, 75, 50),
                new Pokemon(90, "Shellder", "Water", "", 65, 100, 40),
                new Pokemon(91, "Cloyster", "Water", "Ice", 95, 180, 70),
                new Pokemon(92, "Gastly", "Ghost", "Poison", 35, 30, 80),
                new Pokemon(93, "Haunter", "Ghost", "Poison", 50, 45, 95),
                new Pokemon(94, "Gengar", "Ghost", "Poison", 65, 60, 110),
                new Pokemon(95, "Onix", "Rock", "Ground", 45, 160, 70),
                new Pokemon(96, "Drowzee", "Psychic", "", 48, 45, 42),
                new Pokemon(97, "Hypno", "Psychic", "", 73, 70, 67),
                new Pokemon(98, "Krabby", "Water", "", 105, 90, 50),
                new Pokemon(99, "Kingler", "Water", "", 130, 115, 75),
                new Pokemon(100, "Voltorb", "Electric", "", 30, 50, 100),
                new Pokemon(101, "Electrode", "Electric", "", 50, 70, 150),
                new Pokemon(102, "Exeggcute", "Grass", "Psychic", 40, 80, 40),
                new Pokemon(103, "Exeggutor", "Grass", "Psychic", 95, 85, 55),
                new Pokemon(104, "Cubone", "Ground", "", 50, 95, 35),
                new Pokemon(105, "Marowak", "Ground", "", 80, 110, 45),
                new Pokemon(106, "Hitmonlee", "Fighting", "", 120, 53, 87),
                new Pokemon(107, "Hitmonchan", "Fighting", "", 105, 79, 76),
                new Pokemon(108, "Lickitung", "Normal", "", 55, 75, 30),
                new Pokemon(109, "Koffing", "Poison", "", 65, 95, 35),
                new Pokemon(110, "Weezing", "Poison", "", 90, 120, 60),
                new Pokemon(111, "Rhyhorn", "Ground", "Rock", 85, 95, 25),
                new Pokemon(112, "Rhydon", "Ground", "Rock", 130, 120, 40),
                new Pokemon(113, "Chansey", "Normal", "", 5, 5, 50),
                new Pokemon(114, "Tangela", "Grass", "", 55, 115, 60),
                new Pokemon(115, "Kangaskhan", "Normal", "", 95, 80, 90),
                new Pokemon(116, "Horsea", "Water", "", 40, 70, 60),
                new Pokemon(117, "Seadra", "Water", "", 65, 95, 85),
                new Pokemon(118, "Goldeen", "Water", "", 67, 60, 63),
                new Pokemon(119, "Seaking", "Water", "", 92, 65, 68),
                new Pokemon(120, "Staryu", "Water", "", 45, 55, 85),
                new Pokemon(121, "Starmie", "Water", "Psychic", 75, 85, 115),
                new Pokemon(122, "Mr. Mime", "Psychic", "Fairy", 45, 65, 90),
                new Pokemon(123, "Scyther", "Bug", "Flying", 110, 80, 105),
                new Pokemon(124, "Jynx", "Ice", "Psychic", 50, 35, 95),
                new Pokemon(125, "Electabuzz", "Electric", "", 83, 57, 105),
                new Pokemon(126, "Magmar", "Fire", "", 95, 57, 93),
                new Pokemon(127, "Pinsir", "Bug", "", 125, 100, 85),
                new Pokemon(128, "Tauros", "Normal", "", 100, 95, 110),
                new Pokemon(129, "Magikarp", "Water", "", 10, 55, 80),
                new Pokemon(130, "Gyarados", "Water", "Flying", 125, 79, 81),
                new Pokemon(131, "Lapras", "Water", "Ice", 85, 80, 60),
                new Pokemon(132, "Ditto", "Normal", "", 48, 48, 48),
                new Pokemon(133, "Eevee", "Normal", "", 55, 50, 55),
                new Pokemon(134, "Vaporeon", "Water", "", 65, 60, 65),
                new Pokemon(135, "Jolteon", "Electric", "", 65, 60, 130),
                new Pokemon(136, "Flareon", "Fire", "", 130, 60, 65),
                new Pokemon(137, "Porygon", "Normal", "", 60, 70, 40),
                new Pokemon(138, "Omanyte", "Rock", "Water", 40, 100, 35),
                new Pokemon(139, "Omastar", "Rock", "Water", 60, 125, 55),
                new Pokemon(140, "Kabuto", "Rock", "Water", 80, 90, 55),
                new Pokemon(141, "Kabutops", "Rock", "Water", 115, 105, 80),
                new Pokemon(142, "Aerodactyl", "Rock", "Flying", 105, 65, 130),
                new Pokemon(143, "Snorlax", "Normal", "", 110, 65, 30),
                new Pokemon(144, "Articuno", "Ice", "Flying", 85, 100, 85),
                new Pokemon(145, "Zapdos", "Electric", "Flying", 90, 85, 100),
                new Pokemon(146, "Moltres", "Fire", "Flying", 100, 90, 90),
                new Pokemon(147, "Dratini", "Dragon", "", 64, 45, 50),
                new Pokemon(148, "Dragonair", "Dragon", "", 84, 65, 70),
                new Pokemon(149, "Dragonite", "Dragon", "Flying", 134, 95, 80),
                new Pokemon(150, "Mewtwo", "Psychic", "", 110, 90, 130),
                new Pokemon(151, "Mew", "Psychic", "", 100, 100, 100),
            };
        }

        static IEnumerable<Models.Type> GetPreconfiguredTypes()
        {
            return new List<Models.Type>()
            {
                new Models.Type("Normal"),
                new Models.Type("Fighting"),
                new Models.Type("Flying"),
                new Models.Type("Poison"),
                new Models.Type("Ground"),
                new Models.Type("Rock"),
                new Models.Type("Bug"),
                new Models.Type("Ghost"),
                new Models.Type("Steel"),
                new Models.Type("Fire"),
                new Models.Type("Water"),
                new Models.Type("Grass"),
                new Models.Type("Electric"),
                new Models.Type("Psychic"),
                new Models.Type("Ice"),
                new Models.Type("Dragon"),
                new Models.Type("Fairy"),
            };
        }
    }
}