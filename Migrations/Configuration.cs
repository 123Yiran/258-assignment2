namespace assignment2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using assignment2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<assignment2.Data.assignment2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "assignment2.Data.assignment2Context";
        }

        protected override void Seed(assignment2.Data.assignment2Context context)
        {
            var destinies = new List<Destiny>
             {
                //存护
                new Destiny {Name = "The Preservation" ,IsInverted = true,Description = "Destiny in the hands of the Aeons \"Kurippu.\"\r\nWaiting, sacrifice, and protective actions represent the \"Preservation\" destiny.",ImagePath = "~/Image/destiny-icon/cunhu.png" },
                //毁灭
                new Destiny {Name = "The Destruction" ,IsInverted = true, Description = "Destiny governed by the Aeons \"Nanuk.\"\r\nRecklessness, anger, and destructive behavior are manifestations of the \"Destruction\" destiny.",ImagePath = "~/Image/destiny-icon/huimie.png" },
                //智识
                new Destiny {Name = "The Erudition" ,IsInverted = false,Description = "Destiny guided by the Aeons \"Boshoku Son.\"\r\nThinking, logic, and strategic behavior exemplify the \"Erudition\" destiny." ,ImagePath = "~/Image/destiny-icon/zhishi.png"},
                //丰饶
                new Destiny {Name = "The Abundance",IsInverted = false, Description = " Destiny governed by the Aeons \"Yakushi.\"\r\nSelflessness, altruism, and healing actions define the \"Abundance\" destiny." ,ImagePath = "~/Image/destiny-icon/fengrao.png"},
                //虚无
                new Destiny {Name = "The Nihility" ,IsInverted = true,Description = "Destiny under the governance of the Aeons\"IX.\"\r\nLaziness, weariness, and meaningless actions characterize the \"Void\" destiny.",ImagePath = "~/Image/destiny-icon/xuwu.png" },      
                //巡猎
                new Destiny {Name = "The Hunt",IsInverted = true, Description = "Destiny governed by the Aeons \"Ran.\"\r\nResolve, coldness, and vengeful actions embody the \"Hunt\" Destiny ." ,ImagePath = "~/Image/destiny-icon/xunlie.png"},
                //同谐
                new Destiny {Name = "The Harmony", IsInverted =false ,Description = "Destiny ruled by the Aeons \"Shipei.\"\r\nUnderstanding, support, and cooperation are expressions of the \"Harmony\" destiny.",ImagePath = "~/Image/destiny-icon/tongxie.png" },
             };
            destinies.ForEach(c => context.Destinies.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var characters = new List<Character>
            {

                new Character
                {
                    Name = "Himeko",
                    Description = "An adventurous scientist who encountered the Astral Express as a\r\nyoung girl when it got stranded in her home world.\r\nYears later, Himeko finally repaired the train and began her\r\njourney to the stars, but she realized that this was only the\r\nbeginning. On her trailblazing journey, she would need many\r\nmore companion...\r\nAnd while they may have different destinations, they all gaze at\r\nthe same starry sky.",
                    Age = 91,
                    Faction = "train",
                    Attribute = "Fire",
                    ImagePath = "~/Image/CaractersIcon/Jinzi-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Erudition").ID
                },
                new Character
                {
                   Name = "welt",
                    Description = "The wise and experienced former Anti-Entropy Sovereign who\r\ninherits the name of the world -_- Welt. He has saved Earth from\r\nannihilation time and time again.\r\nAfter the incident with St. Fountain came to a close, Welt had no\r\nchoice but to venture with the initiator of the incident to the\r\nother side of the portal.\r\nPerhaps even he did not expect the new journey nor companions\r\nthat awaited him there.",
                    Age = 95,
                    Faction = "train",
                    Attribute = "Imaginary Number",
                    ImagePath = "~/Image/CaractersIcon/welt.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                },
                new Character
                {
                   Name = "Dan heng",
                    Description = "A cold and reserved young man who wields a spear known as\r\nCloud-Piercer.\r\nHe acts as the Express' guard on its long trailblazing expedition.\r\nDan Heng never talks much about his past. In fact, he joined the\r\nExpress Crew to escape from it. But can the Express really help\r\nhim outrun his past?",
                    Age = 200,
                    Faction = "train",
                    Attribute = "Wind",
                    ImagePath = "~/Image/CaractersIcon/Danheng.png",
                    DestinyID = destinies.Single(c => c.Name == "The Hunt").ID
                },

                 new Character
                {
                   Name = "March 7th",
                    Description = "A spirited, quirky young girl who is into all the things girls her\r\nage should be interested in, for example, taking photos.\r\nShe was awakened from a piece of drifting eternal ice only to\r\nfind out that she knows nothing about herself or her past. While\r\ninitially in low spirits due to her lack of identity, she decided ta\r\nname herself after the date she came into this new life.\r\nAnd thus, on that day, March 7th was born.",
                    Age = 300,
                    Faction = "train",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/seven.png",
                    DestinyID = destinies.Single(c => c.Name == "The Preservation").ID
                },
                  new Character
                {
                   Name = "Kafka",
                    Description = "On the Interastral Peace Corporation's wanted list, Kafka' entry\r\nonly has two things\r\nher name,and a single sentence:\r\nLikes\r\ncollecting coats\r\nLittle is known about this Stellaron Hunter, other than that she is\r\none of Destin's Slave Elio's most trusted members.\r\nIn order to achieve Elio's envisioned future, Kafka gets to work.",
                    Age = 100,
                    Faction = "Starcore Hunter",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/Kfk-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                },
                   new Character
                {
                   Name = "Silver Wolf",
                    Description = "The universe is just another game to this super hacker.\r\nNo matter how thorny the defense system, Silver Wolf can crack\r\nit with ease. Her hacking battle with Screwllum of the Genius\r\nSociety has become stuff of legends in the hacking world.\r\nHow many more levels are there to beat in the universe? Silver\r\nWolf looks forward to finding out.",
                    Age = 100,
                    Faction = "Starcore Hunter",
                    Attribute = "Quantum",
                    ImagePath = "~/Image/CaractersIcon/wolf.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                },
                    new Character
                {
                   Name = "Arlsn",
                    Description = "The inarticulate head of Herta Space Station's Security\r\nDepartment\r\nWhile scientific research is beyond his understanding, Arlan is\r\nwilling to risk his life to protect the staff who value research so\r\nvery much. He is used to the pain and wears his scars like badges\r\nof honor\r\nOnly when holding Peppy does the boy finally let down his guard\r\nand show a rare smile.",
                    Age = 354,
                    Faction = "Herta Space Station",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/Alan.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                },
                     new Character
                {
                   Name = "Asta",
                    Description = "A fiercely inquisitive and energetic young girl, she is the Lead\r\nResearcher of Herta Space Station.\r\nWhether it is managing opinionated staff, or courteously but,\r\nfirmly responding to the Intelligentsia Guild, Asta handles it all\r\neffortlessly.\r\nAfter all. commanding a space station is much easier than taking\r\nover her family business!",
                    Age = 50,
                    Faction = "Herta Space Station",
                    Attribute = "Fire",
                    ImagePath = "~/Image/CaractersIcon/Aisitan-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Harmony").ID
                },
                 new Character
                {
                   Name = "Herta",
                    Description = "Herta Space Station's true master.\r\nAs the human with the highest IQ on The Blue, she only does\r\nwhat she's interested in, dropping whatever project immediately\r\nthe moment she loses interest _- the best example being the\r\nspace station.\r\nShe typically appears in the form of a remote-controlled puppet.\r\n\"It's about seventy percent similar to how I looked as a child.\"\r\n--Herta",
                    Age = 200,
                    Faction = "Herta Space Station/Genius Club",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/Heita-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Erudition").ID
                },
                new Character
                {
                   Name = "Gepard",
                    Description = "The honorable and upstanding captain of the Silverman Guards\r\nwho bears the noble Landau family name.\r\nIn the frost-whipped city of Belobog, life can still go on in\r\nnormality..\r\nThis is in no small part thanks to Gepard and his Silvermane\r\nGuards who protect the peace of everyday life.",
                    Age = 35,
                    Faction = "Jarilo-VI",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/Jiepade-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Preservation").ID
                },new Character
                {
                   Name = "Bronya",
                    Description = "Heir to the Supreme Guardian of Belobog, she is the young and\r\ncapable commander of the Silvermane Guards.\r\nBronya received rigorous education from an early age, and\r\npossesses the grace and affinity as expected of an heir.\r\nHowever, after witnessing the abysmal conditions in the\r\nUnderworld, seeds of doubt began growing in Belobog's future\r\nleader's mind.\r\n*Can all the training I've received really help me lead the people\r\nto the lives they want?*",
                    Age = 20,
                    Faction = "Jarilo-VI",
                    Attribute = "Wind",
                    ImagePath = "~/Image/CaractersIcon/Buluoniya-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Harmony").ID
                },
                new Character
                {
                   Name = "Seele",
                    Description = "A spirited and valiant member of Wildfire who grew up in the\r\nperilous Underworld of Belobog. She is accustomed to being on\r\nher own.\r\nThe protectors and the protected, the oppressors and the\r\noppressed.…. The world Seele grew up knowing was just a simple\r\ndichotomy...\r\nThat is, until \"that girl\" appeared.",
                    Age = 18,
                    Faction = "Jarilo-VI",
                    Attribute = "Quantum",
                    ImagePath = "~/Image/CaractersIcon/Xier-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Hunt").ID
                },
                new Character
                {
                   Name = "Clara",
                    Description = "A young girl raised by a robot, her perceptiveness and tenacity\r\nare far beyond her years.\r\nFor Clara, Svarog's logical calculations are law and infallible,\r\nThat is, until she realized that the results from \"calculations\" don't\r\nalways necessarily bring joy to everyone.\r\nThe once shy little gird then decided to cast aside her timidness.",
                    Age = 18,
                    Faction = "Jarilo-VI",
                    Attribute = "Physics",
                    ImagePath = "~/Image/CaractersIcon/kelala-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                },
                new Character
                {
                   Name = "Sampo",
                    Description = "A silver-tongued salesman, Where there is profit to be made, you\r\ncan be sure Sampo is nearby.\r\nSampo's unique knowledge makes it hard not to approach him\r\nfor help, but becoming his \"customer\" is not necessarily a good\r\nthing.\r\nAfter all, \"customers\" can quickly turn into \"commodities\" for the\r\nright price.",
                    Age = 131,
                    Faction = "The Fool",
                    Attribute = "Wind",
                    ImagePath = "~/Image/CaractersIcon/Sangbo-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                },
                new Character
                {
                   Name = "Pela",
                    Description = "The meticulous Intelligence Officer of the Silvermane Guards.\r\nWhile young, she is undeniably brilliant.\r\nWhether it relates to maneuvering troops, distributing supplies,\r\nor the terrain, Pela can answer any problems with calm certainty.\r\nAs for her phone case...\r\n\"It has nothing to do with work, captain.\"",
                    Age = 31,
                    Faction = "Jarilo-VI",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/peila.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                }, new Character
                {
                   Name = "Serval",
                    Description = "The free and rebellious eldest daughter of the Landau family,\r\nonce à dose friend of Cacolia, her interests has now led her to\r\nbecome a mechanic\r\nIn the perpetually winter stricken Belobog, she opened a\r\nworkshop called \"Neverwinter* that puts business on hold from\r\ntime to time for rock 'n' roll performances.\r\nAnd should anyone ask her about the workshop's profitability.\r\n\"This is just a hobby, dear, I'm not short of money.\"",
                    Age = 41,
                    Faction = "Jarilo-VI",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/xiluwan.png",
                    DestinyID = destinies.Single(c => c.Name == "The Erudition").ID
                }, new Character
                {
                   Name = "Natasha",
                    Description = "A fastidious doctor who always wears a curious smile,.\r\nIn the Underworld where medical resources are few and far\r\nbetween, Natasha is one of the very few doctors whom the\r\nDeople can turn to.\r\nEven the rambunctious Hook would politely greet her...\r\n\"Hi. Auntie Natasha.\"",
                    Age = 51,
                    Faction = "Jarilo-VI",
                    Attribute = "Physics",
                    ImagePath = "~/Image/CaractersIcon/natasha.png",
                    DestinyID = destinies.Single(c => c.Name == "The Abundance").ID
                }, new Character
                {
                   Name = "Hook",
                    Description = "Head of the adventure squad The Moles, she calls herself Pitch-\r\nDark Hook the Great.\r\nShe doesn't like to be called a *kid® and believes she can handle\r\nthings herself without any help from adults,\r\nAdults adventure into the Fragmentum, Sampo adventures on the\r\nsurface, and patients take their risky adventure seeking treatment\r\nfrom Natasha_\r\nUnder the leadership of Hook, children can also have their own\r\nadventures!",
                    Age = 631,
                    Faction = "Jarilo-VI",
                    Attribute = "Fire",
                    ImagePath = "~/Image/CaractersIcon/Hook.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                }, new Character
                {
                   Name = "Jing Yuan",
                    Description = "Although his appearance may be one of indolence, the Cloud\r\nKnight general who commands the Xianzhou Luofu is more\r\nmeticulous than seemingly meets the eye.\r\nHe does not consider saving a situation from the brink of disaster\r\nto be a show of wisdom, and is thus fastidious with routine\r\naffairs to avoid any potential problems.\r\nDue to his careful management, the Xianzhou have enjoyed many\r\nyears of peace, with Jing Yuan's seemingly lazy demeanor having\r\neared him the moniker of\r\n\"Dozing General.\"",
                    Age = 801,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/jingyuan-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Erudition").ID
                }, new Character
                {
                   Name = "Yanqing",
                    Description = "The spirited lieutenant of the Xianzhou Luofu, and also its most\r\nproficient swordsman.\r\nHe is born for swords and obsessed with them. Whenever a\r\nsword rests in his hand, none would dare to underestimate this\r\ngenius still in the early days of his youth.\r\nPerhaps the only thing capable of dulling his treasured blade's\r\nsharp edge is time.",
                    Age = 631,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/Yanqing-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Hunt").ID
                }, new Character
                {
                   Name = "Bailiu",
                    Description = "A vivacious young lady of the Vidyadhara race, she is known as\r\nthe \"Healer Lady\" due to her expertise with medicine.\r\nShe often dishes out unorthodox prescriptions such as \"Stay well\r\nhydrated\" and \"Get a good night's rest\r\nBailu cannot bear to see people suffer, and that's why you'll see\r\nher with her eyes shut tightly as she cures ailments.\r\n\"As long as they're cured, that's all that matters, right?\"",
                    Age = 231,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/bailu.png",
                    DestinyID = destinies.Single(c => c.Name == "The Abundance").ID
                },
                new Character
                {
                   Name = "Tingyun",
                    Description = "A silver-tongued Foxian giri, Tingyun is the Head Representative\r\nof the Whistling Flames, a merchant guild officially approved by\r\nthe Sky-Faring Commission.\r\nShe has such a way with words that often leaves her audience\r\neagerly waiting for more of her captivating tales, As a result of\r\nher supervision, the Xianzhou trade fairs are now known\r\nthroughout the galaxy.\r\n\"Try one's best to avoid conflict when possible, and persuade\r\nthose who can be persuaded\r\n\" that's Tingyun's motto.",
                    Age = 231,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Lightning",
                    ImagePath = "~/Image/CaractersIcon/tingyun.png",
                    DestinyID = destinies.Single(c => c.Name == "The Harmony").ID
                },
                new Character
                {
                   Name = "Sushang",
                    Description = "A naive and enthusiastic newcomer to the Cloud Knights who\r\nwields a greatsword.\r\nShe yearns for the historic legends of the Cloud Knights, and is\r\neager to become such a legendary figure herself.\r\nAs such, Sushang firmly believes in tr philosophies \"be eager to\r\nhelp those in need,\" \"do one good deed a day and reflect on\r\noneself three times a day,\" leading her to busy days full of\r\nhelping others.",
                    Age = 130,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Physics",
                    ImagePath = "~/Image/CaractersIcon/.png",
                    DestinyID = destinies.Single(c => c.Name == "The Hunt").ID
                },
                new Character
                {
                   Name = "Qingque",
                    Description = "An average Diviner or the Livination Commission, who will never\r\nslack off when it comes to slacking off.\r\nShe passed the Divination Commission's entrance exam to please\r\nher parents, only to discover what she had originally thought to\r\nbe a relaxing public servant job to instead be very intensive and\r\na worker's nightmare.\r\nAfter several years of experience, Qingque had finally honed her\r\ncraft- No matter which department she changes to, she\r\nremains the lowest level of Niviners.\r\n\"When there's nothing else left to do, why not bury your head in\r\na book or play cards? What more could I ask for?\"",
                    Age = 111,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Quantum",
                    ImagePath = "~/Image/CaractersIcon/qingque.png",
                    DestinyID = destinies.Single(c => c.Name == "The Erudition").ID
                },
                new Character
                {
                   Name = "Topaz and Numby",
                    Description = "All in one",
                    Age = 201,
                    Faction = "Interstellar Peace Corporation",
                    Attribute = "Fire",
                    ImagePath = "~/Image/CaractersIcon/tuopa.png",
                    DestinyID = destinies.Single(c => c.Name == "The Hunt").ID
                },
                new Character
                {
                   Name = "Guinaifen",
                    Description = "An outworlder who ended up residing on the Xianzhou b\r\naccident. She is now a passionate and vivacious street performer.\r\nWith her real name being Guinevere, Guinaifen is the Xianzhou\r\nname given to her by her good friend Sushang.\r\nFaced with a whole new life on the Loufu and relying on her\r\nadoration of Xianzhou culture, Guinaifen quickly learned skills\r\nthat would keep her clothed and fed - such as slurping noodles\r\nin a handstand, smashing slabs without harming the people it\r\nwuasplacedupon,catching Dullets wuith bare hands, and so on.",
                    Age = 123,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Fire",
                    ImagePath = "~/Image/CaractersIcon/gui.png",
                    DestinyID = destinies.Single(c => c.Name == "The Nihility").ID
                },
                new Character
                {
                   Name = "Jingliu",
                    Description = "One of the legendary heroes making up the High-Cloud Quintet,\r\nand bestowed with the title \"Transcendent Flash\".\r\nHaving ascended beyond mortal concepts of victory, she chose to\r\nwalk a different path to obtain the power capable of slaying\r\ngods.\r\nThereafter, one Sword Champion of the Loufu was removed from\r\nthe Xianzhou's records, and one nameless traitor was added.",
                    Age = 1300,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Ice",
                    ImagePath = "~/Image/CaractersIcon/jingliu.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                },
                new Character
                {
                   Name = "Dan Heng Imbibitor Lunae",
                    Description = "Dan Heng's true Vidyadhara form, revealed after accepting the\r\nresidual powers from the previous reincarnation of \"Imbibitor Lunae\".\r\n-\r\nUpon accepting the majestic horns atop his crown, he must\r\naccept all the merits and faults attributed to that person.\r\nHowever, he was never himself.",
                    Age = 201,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Imaginary Number",
                    ImagePath = "~/Image/CaractersIcon/DanhengYinyue-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                },
                 new Character
                {
                   Name = "Fu Xuan",
                    Description = "The head of the Xianzhou Luofu's Divination Commission and\r\nconfident, no-nonsense sage.\r\nUsing her third eye and the Matrix of Prescience, Fu Xuan\r\ncalculates the Xianzhou's navigational route and predicts the\r\nfortune of future events. She firmly believes that everything she\r\ndoes is the \"best solution\" for the situation.\r\nFu Xuan is waiting for the general's promised \"abdication\". -\r\nHowever, that day still seems…. very far away.",
                    Age = 221,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Quantum",
                    ImagePath = "~/Image/CaractersIcon/Fuxuan-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Preservation").ID
                },
                  new Character
                {
                   Name = "Lynx",
                    Description = "The youngest daughter of the Landau family, and one of\r\nBelobog's best extreme environments explorers.\r\nShe is highly capable of action despite her apparent lack of\r\nmotivation, She only appears introverted and lazy to avoid\r\nunnecessary socialization.\r\nAs for what counts as unnecessary socialization - \"Um, aren't all\r\nsocialization unnecessary?\"",
                    Age = 31,
                    Faction = "Unknown",
                    Attribute = "Quantum",
                    ImagePath = "~/Image/CaractersIcon/lingke.png",
                    DestinyID = destinies.Single(c => c.Name == "The Abundance").ID
                },
                   new Character
                {
                   Name = "Blade",
                    Description = "A swordsman who abandoned his body to become a blade, Birth\r\nname unknown.\r\nHe pledged loyalty to Destiny's Slave and possessed a terrifying\r\nself-healing ability.\r\nBlade wields an ancient sword riddled with cracks, just like his\r\nbody and his mind.",
                    Age = 851,
                    Faction = "Starcore Hunter",
                    Attribute = "Wind",
                    ImagePath = "~/Image/CaractersIcon/ren.png",
                    DestinyID = destinies.Single(c => c.Name == "The Destruction").ID
                },
               new Character
                {
                   Name = "Yukong",
                    Description = "The Xianzhou Luofu's Had of the Sky-Faring Commission is\r\ngentle, yet seasoned and authoritative.\r\nHaving been a pilot since young, she had become the\r\ncommission's head with her outstanding combat achievements,\r\nyet she no longer flies due to a particularly brutal battle.\r\nNow, her shine had already dimmed as she shifted her focus to\r\nofficial duties, but she is always seen guiding the course of the\r\nLuofu.",
                    Age = 235,
                    Faction = "The Xianzhou Luofu",
                    Attribute = "Imaginary Number",
                    ImagePath = "~/Image/CaractersIcon/yukong.png",
                    DestinyID = destinies.Single(c => c.Name == "The Harmony").ID
                },
                new Character
                {
                   Name = "Luocha",
                    Description = "A handsome blond young man who carries a giant coffin on his\r\nback.\r\nAs an intergalactic merchant, he was unfortunately caught in the\r\nXianzhou Luofu's Stellaron crisis,\r\nAnd that is how he found his mastery of medicine to come in\r\nhandy.",
                    Age = 56,
                    Faction = "Uknown",
                    Attribute = "Imaginary Number",
                    ImagePath = "~/Image/CaractersIcon/Luocha-icon.png",
                    DestinyID = destinies.Single(c => c.Name == "The Abundance").ID
                },
            };
            characters.ForEach(c => context.Characters.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
